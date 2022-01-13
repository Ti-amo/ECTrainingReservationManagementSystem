using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservationManagementSystem.DAO {
    class ReservationDAO {
        /// <summary>
        /// データベースとのコネクション
        /// </summary>
        private readonly SqlConnection connection;
        /// <summary>
        /// コネクションに関連するトランザクション
        /// </summary>
        private SqlTransaction transaction;
        /// <summary>
        /// コマンド
        /// </summary>
        private SqlCommand command;
        /// <summary>
        /// データリーダー
        /// </summary>
        private SqlDataReader dataReader;

        public ReservationDAO() {
            // データベース接続の作成
            connection = new SqlConnection {
                ConnectionString = ConfigurationManager.ConnectionStrings["reservationdb"].ConnectionString
            };
            connection.Open();
        }

        /// <summary>
        /// 予約IDによる予約を抽出する
        /// </summary>
        /// <param name="reservationId">予約ID</param>
        /// <returns>予約</returns>
        public ReservationEntity FindById(int reservationId) {
            // SQL文：SELECT句
            string query = @"SELECT * 
                            FROM m_reservation r 
                            INNER JOIN m_patient p ON p.patient_id = r.patient_id 
                            INNER JOIN m_status s ON s.status_id = r.status_id 
                            WHERE reservation_id = @reservation_id";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@reservation_id", reservationId);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            ReservationEntity reservationEntity = null;
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                // １予約ずつ抽出する
                reservationEntity = new ReservationEntity {
                    ReservationId = (int)dataReader["reservation_id"],
                    ReservationDate = Convert.ToDateTime(dataReader["reservation_date"]).ToString("yyyy-MM-dd"),
                    PatientId = (string)dataReader["combined_id"],
                    PatientName = (string)dataReader["name"],
                    StatusId = (int)dataReader["status_id"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                    reservationEntity.StatusName = (string)dataReader["status_name"];
                } else {
                    reservationEntity.StatusName = (string)dataReader["status_name_en"];
                }
            }

            command.Dispose();
            dataReader.Close();

            // SQL文：SELECT句
            query = @"SELECT * 
                    FROM t_reservation_exam re 
                    INNER JOIN m_sub_examination se ON se.sub_id = re.sub_id 
                    INNER JOIN m_major_examination me ON me.major_id = se.major_id 
                    WHERE reservation_id = @reservation_id";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@reservation_id", reservationId);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            reservationEntity.Exam = new List<ExamItem>();
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                // １診療項目ずつ抽出する
                ExamItem examItem = new ExamItem {
                    MajorExamId = (int)dataReader["major_id"],
                    SubExamId = (int)dataReader["sub_id"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                    examItem.MajorExamName = (string)dataReader["major_name"];
                    examItem.SubExamName = (string)dataReader["sub_name"];
                } else {
                    examItem.MajorExamName = (string)dataReader["major_name_en"];
                    examItem.SubExamName = (string)dataReader["sub_name_en"];
                }

                // 診療項目をリストに格納する
                reservationEntity.Exam.Add(examItem);
            }

            command.Dispose();
            dataReader.Close();

            return reservationEntity;
        }

        /// <summary>
        /// 最新の予約IDを抽出する
        /// </summary>
        /// <returns>予約ID</returns>
        public int FindLatestReservation() {
            // SQL文：SELECT句
            string query = @"SELECT TOP 1 * 
                            FROM m_reservation 
                            ORDER BY created DESC";

            // コマンドの作成
            command = new SqlCommand(query, connection);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            int reservationId = 1;
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                reservationId = (int)dataReader["reservation_id"];
            }

            command.Dispose();
            dataReader.Close();

            return reservationId;
        }

        /// <summary>
        /// 患者IDによるすべての予約を抽出する
        /// </summary>
        /// <param name="patientId">患者ID</param>
        /// <returns>すべての予約</returns>
        public List<ReservationEntity> FindByPatient(string patientId) {
            // 「EC」と「0」を削除して、intに変換する
            int id = int.Parse(patientId.Remove(0, 2));

            // SQL文：SELECT句
            string query = @"SELECT * 
                            FROM m_reservation r 
                            INNER JOIN m_patient p ON p.patient_id = r.patient_id 
                            INNER JOIN m_status s ON s.status_id = r.status_id 
                            WHERE r.patient_id = @patient_id 
                            ORDER BY reservation_date DESC";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@patient_id", id);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            // すべての予約のリスト
            List<ReservationEntity> reservationList = new List<ReservationEntity>();
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                // １予約ずつ抽出する
                ReservationEntity reservationEntity = new ReservationEntity {
                    ReservationId = (int)dataReader["reservation_id"],
                    ReservationDate = Convert.ToDateTime(dataReader["reservation_date"]).ToString("yyyy-MM-dd"),
                    PatientId = (string)dataReader["combined_id"],
                    PatientName = (string)dataReader["name"],
                    StatusId = (int)dataReader["status_id"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                    reservationEntity.StatusName = (string)dataReader["status_name"];
                } else {
                    reservationEntity.StatusName = (string)dataReader["status_name_en"];
                }

                // 予約をリストに格納する
                reservationList.Add(reservationEntity);
            }

            command.Dispose();
            dataReader.Close();

            foreach (ReservationEntity reservationEntity in reservationList) {
                // SQL文：SELECT句
                query = @"SELECT * 
                        FROM t_reservation_exam re 
                        INNER JOIN m_sub_examination se ON se.sub_id = re.sub_id 
                        INNER JOIN m_major_examination me ON me.major_id = se.major_id 
                        WHERE reservation_id = @reservation_id";

                // コマンドの作成
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);

                // データリーダーの作成
                dataReader = command.ExecuteReader();

                reservationEntity.Exam = new List<ExamItem>();
                // データを１行ずつ抽出する
                while (dataReader.Read()) {
                    // １診療項目ずつ抽出する
                    ExamItem examItem = new ExamItem {
                        MajorExamId = (int)dataReader["major_id"],
                        SubExamId = (int)dataReader["sub_id"]
                    };
                    if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                        examItem.MajorExamName = (string)dataReader["major_name"];
                        examItem.SubExamName = (string)dataReader["sub_name"];
                    } else {
                        examItem.MajorExamName = (string)dataReader["major_name_en"];
                        examItem.SubExamName = (string)dataReader["sub_name_en"];
                    }

                    // 診療項目をリストに格納する
                    reservationEntity.Exam.Add(examItem);
                }

                command.Dispose();
                dataReader.Close();
            }

            return reservationList;
        }

        /// <summary>
        /// 予約日付によるすべての予約を抽出する
        /// </summary>
        /// <param name="reservationDate">予約日付</param>
        /// <returns>すべての予約</returns>
        public List<ReservationEntity> FindByDate(string reservationDate) {
            // SQL文：SELECT句
            string query = @"SELECT * 
                            FROM m_reservation r 
                            INNER JOIN m_patient p ON p.patient_id = r.patient_id 
                            INNER JOIN m_status s ON s.status_id = r.status_id 
                            WHERE reservation_date = CAST(@reservation_date AS Date)";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@reservation_date", reservationDate);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            // すべての予約のリスト
            List<ReservationEntity> reservationList = new List<ReservationEntity>();
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                // １予約ずつ抽出する
                ReservationEntity reservationEntity = new ReservationEntity {
                    ReservationId = (int)dataReader["reservation_id"],
                    ReservationDate = Convert.ToDateTime(dataReader["reservation_date"]).ToString("yyyy-MM-dd"),
                    PatientId = (string)dataReader["combined_id"],
                    PatientName = (string)dataReader["name"],
                    StatusId = (int)dataReader["status_id"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                    reservationEntity.StatusName = (string)dataReader["status_name"];
                } else {
                    reservationEntity.StatusName = (string)dataReader["status_name_en"];
                }

                // 予約をリストに格納する
                reservationList.Add(reservationEntity);
            }

            command.Dispose();
            dataReader.Close();

            foreach (ReservationEntity reservationEntity in reservationList) {
                // SQL文：SELECT句
                query = @"SELECT * 
                        FROM t_reservation_exam re 
                        INNER JOIN m_sub_examination se ON se.sub_id = re.sub_id 
                        INNER JOIN m_major_examination me ON me.major_id = se.major_id 
                        WHERE reservation_id = @reservation_id";

                // コマンドの作成
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);

                // データリーダーの作成
                dataReader = command.ExecuteReader();

                reservationEntity.Exam = new List<ExamItem>();
                // データを１行ずつ抽出する
                while (dataReader.Read()) {
                    // １診療項目ずつ抽出する
                    ExamItem examItem = new ExamItem {
                        MajorExamId = (int)dataReader["major_id"],
                        SubExamId = (int)dataReader["sub_id"]
                    };
                    if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                        examItem.MajorExamName = (string)dataReader["major_name"];
                        examItem.SubExamName = (string)dataReader["sub_name"];
                    } else {
                        examItem.MajorExamName = (string)dataReader["major_name_en"];
                        examItem.SubExamName = (string)dataReader["sub_name_en"];
                    }

                    // 診療項目をリストに格納する
                    reservationEntity.Exam.Add(examItem);
                }

                command.Dispose();
                dataReader.Close();
            }

            return reservationList;
        }

        /// <summary>
        /// 指定した予約を挿入する
        /// </summary>
        /// <param name="reservationEntity">挿入された予約</param>
        /// <returns>挿入されたレコード数</returns>
        public int Insert(ReservationEntity reservationEntity) {
            // 「EC」と「0」を削除して、intに変換する
            int id = int.Parse(reservationEntity.PatientId.Remove(0, 2));

            // SQL文：INSERT句
            string query = @"INSERT INTO m_reservation (patient_id, reservation_date) 
                            VALUES (@patient_id, CAST(@reservation_date AS Date))";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@patient_id", id);
            command.Parameters.AddWithValue("@reservation_date", reservationEntity.ReservationDate);
            int recordNumber = command.ExecuteNonQuery(); // 挿入されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            // 最新の予約IDを抽出する
            reservationEntity.ReservationId = FindLatestReservation();

            foreach (ExamItem examItem in reservationEntity.Exam) {
                // SQL文：INSERT句
                query = @"INSERT INTO t_reservation_exam (reservation_id, sub_id) 
                        VALUES (@reservation_id, @sub_id)";

                // トランザクションの作成
                transaction = connection.BeginTransaction();

                // コマンドの作成
                command = new SqlCommand(query, connection, transaction);
                command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);
                command.Parameters.AddWithValue("@sub_id", examItem.SubExamId);
                command.ExecuteNonQuery();

                transaction.Commit();
                transaction.Dispose();
                command.Dispose();
            }

            return recordNumber;
        }

        /// <summary>
        /// 指定した予約を更新する
        /// </summary>
        /// <param name="reservationEntity">更新された予約</param>
        /// <returns>更新されたレコード数</returns>
        public int Update(ReservationEntity reservationEntity) {
            // SQL文：UPDATE句
            string query = @"UPDATE m_reservation 
                            SET reservation_date = CAST(@reservation_date AS Date) 
                            WHERE reservation_id = @reservation_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);
            command.Parameters.AddWithValue("@reservation_date", reservationEntity.ReservationDate);
            int recordNumber = command.ExecuteNonQuery(); // 更新されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            // SQL文：DELETE句
            query = @"DELETE FROM t_reservation_exam 
                    WHERE reservation_id = @reservation_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);
            command.ExecuteNonQuery();

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            foreach (ExamItem examItem in reservationEntity.Exam) {
                // SQL文：INSERT句
                query = @"INSERT INTO t_reservation_exam (reservation_id, sub_id) 
                        VALUES (@reservation_id, @sub_id)";

                // トランザクションの作成
                transaction = connection.BeginTransaction();

                // コマンドの作成
                command = new SqlCommand(query, connection, transaction);
                command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);
                command.Parameters.AddWithValue("@sub_id", examItem.SubExamId);
                command.ExecuteNonQuery();

                transaction.Commit();
                transaction.Dispose();
                command.Dispose();
            }

            return recordNumber;
        }

        /// <summary>
        /// 指定した予約を削除する
        /// </summary>
        /// <param name="reservationEntity">削除された予約</param>
        /// <returns>削除されたレコード数</returns>
        public int Delete(ReservationEntity reservationEntity) {
            // SQL文：DELETE句
            string query = @"DELETE FROM t_reservation_exam 
                            WHERE reservation_id = @reservation_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);
            command.ExecuteNonQuery();

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            // SQL文：DELETE句
            query = @"DELETE FROM m_reservation 
                    WHERE reservation_id = @reservation_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);
            int recordNumber = command.ExecuteNonQuery(); // 削除されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }

        /// <summary>
        /// 指定した予約の状態を更新する
        /// </summary>
        /// <param name="reservationEntity">更新された予約</param>
        /// <returns>更新されたレコード数</returns>
        public int ChangeStatus(ReservationEntity reservationEntity) {
            // SQL文：UPDATE句
            string query = @"UPDATE m_reservation 
                            SET status_id = @status_id 
                            WHERE reservation_id = @reservation_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@reservation_id", reservationEntity.ReservationId);
            command.Parameters.AddWithValue("@status_id", reservationEntity.StatusId);
            int recordNumber = command.ExecuteNonQuery(); // 更新されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }
    }
}
