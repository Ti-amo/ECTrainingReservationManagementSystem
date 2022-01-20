using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservationManagementSystem.DAO
{
    class ExamDAO
    {
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

        public ExamDAO()
        {
            // データベース接続の作成
            connection = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["reservationdb"].ConnectionString
            };
            connection.Open();
        }

        /// <summary>
        /// すべての診療大項目を抽出する
        /// </summary>
        /// <returns>診療大項目のリスト</returns>
        public List<ExamItem> GetMajorExamList()
        {
            // SQL文：SELECT句
            string query = @"SELECT * 
							FROM m_major_examination";

            // コマンドの作成
            command = new SqlCommand(query, connection);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            List<ExamItem> majorExamList = new List<ExamItem>();
            // データを１行ずつ抽出する
            while (dataReader.Read())
            {
                ExamItem majorExamItem = new ExamItem
                {
                    MajorExamId = (int)dataReader["major_id"],
                    MajorExamName = (string)dataReader["major_name"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP"))
                {
                    majorExamItem.MajorExamName = (string)dataReader["major_name"];
                }
                else
                {
                    majorExamItem.MajorExamName = (string)dataReader["major_name_en"];
                }

                majorExamList.Add(majorExamItem);
            }

            command.Dispose();
            dataReader.Close();

            return majorExamList;
        }

        /// <summary>
        /// 診療大項目IDによるすべての診療小項目を抽出する
        /// </summary>
        /// <param name="majorId">診療大項目ID</param>
        /// <returns>診療小項目のリスト</returns>
        public List<ExamItem> GetSubExamList(int majorId)
        {
            // SQL文：SELECT句
            string query = @"SELECT * 
							FROM m_sub_examination se 
                            INNER JOIN m_major_examination me ON me.major_id = se.major_id 
                            WHERE se.major_id = @major_id";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@major_id", majorId);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            List<ExamItem> subExamList = new List<ExamItem>();
            // データを１行ずつ抽出する
            while (dataReader.Read())
            {
                ExamItem subExamItem = new ExamItem
                {
                    MajorExamId = (int)dataReader["major_id"],
                    SubExamId = (int)dataReader["sub_id"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP"))
                {
                    subExamItem.MajorExamName = (string)dataReader["major_name"];
                    subExamItem.SubExamName = (string)dataReader["sub_name"];
                }
                else
                {
                    subExamItem.MajorExamName = (string)dataReader["major_name_en"];
                    subExamItem.SubExamName = (string)dataReader["sub_name_en"];
                }

                subExamList.Add(subExamItem);
            }

            command.Dispose();
            dataReader.Close();

            return subExamList;
        }

        /// <summary>
        /// 指定した診療大項目を挿入する
        /// </summary>
        /// <param name="examItem">挿入された診療大項目</param>
        /// <returns>挿入されたレコード数</returns>
        public int InsertMajorExam(ExamItem examItem) {
            // SQL文：INSERT句
            string query = @"INSERT INTO m_major_examination (major_name, major_name_en)
							VALUES (@major_name, @major_name_en)";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@major_name", examItem.MajorExamNameJp);
            command.Parameters.AddWithValue("@major_name_en", examItem.MajorExamNameEn);
            command.ExecuteNonQuery();

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            // SQL文：SELECT句
            query = @"SELECT TOP 1 * 
                    FROM m_major_examination 
                    ORDER BY major_id DESC";

            // コマンドの作成
            command = new SqlCommand(query, connection);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            int majorId = 1;
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                majorId = (int)dataReader["major_id"];
            }

            command.Dispose();
            dataReader.Close();

            // SQL文：INSERT句
            query = @"INSERT INTO m_sub_examination (major_id, sub_name, sub_name_en) 
                    VALUES (@major_id, @sub_name, @sub_name_en)";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@major_id", majorId);
            command.Parameters.AddWithValue("@sub_name", examItem.SubExamNameJp);
            command.Parameters.AddWithValue("@sub_name_en", examItem.SubExamNameEn);
            int recordNumber = command.ExecuteNonQuery(); // 挿入されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }

        /// <summary>
        /// 指定した診療小項目を挿入する
        /// </summary>
        /// <param name="examItem">挿入された診療小項目</param>
        /// <returns>挿入されたレコード数</returns>
        public int InsertSubExam(ExamItem examItem) {
            // SQL文：INSERT句
            string query = @"INSERT INTO m_sub_examination (major_id, sub_name, sub_name_en) 
                            VALUES (@major_id, @sub_name, @sub_name_en)";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@major_id", examItem.MajorExamId);
            command.Parameters.AddWithValue("@sub_name", examItem.SubExamNameJp);
            command.Parameters.AddWithValue("@sub_name_en", examItem.SubExamNameEn);
            int recordNumber = command.ExecuteNonQuery(); // 挿入されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }

        /// <summary>
        /// 指定した診療大項目を削除する
        /// </summary>
        /// <param name="examItem">削除された診療大項目</param>
        /// <returns>削除されたレコード数</returns>
        public int DeleteMajorExam(ExamItem examItem) {
            // SQL文：SELECT句
            string query = @"SELECT * 
							FROM m_sub_examination 
                            WHERE major_id = @major_id";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@major_id", examItem.MajorExamId);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            List<int> subExamIdList = new List<int>();
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                subExamIdList.Add((int)dataReader["sub_id"]);
            }

            command.Dispose();
            dataReader.Close();

            foreach (int subExamId in subExamIdList) {
                ExamItem examItemTemp = new ExamItem {
                    SubExamId = subExamId
                };
                DeleteSubExam(examItemTemp);
            }

            // SQL文：DELETE句
            query = @"DELETE FROM m_major_examination 
                    WHERE major_id = @major_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@major_id", examItem.MajorExamId);
            int recordNumber = command.ExecuteNonQuery(); // 削除されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }

        /// <summary>
        /// 指定した診療小項目を削除する
        /// </summary>
        /// <param name="examItem">削除された診療小項目</param>
        /// <returns>削除されたレコード数</returns>
        public int DeleteSubExam(ExamItem examItem) {
            // SQL文：SELECT句
            string query = @"SELECT * 
							FROM t_reservation_exam 
                            WHERE sub_id = @sub_id";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sub_id", examItem.SubExamId);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            List<int> reservationIdList = new List<int>();
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                reservationIdList.Add((int)dataReader["reservation_id"]);
            }

            command.Dispose();
            dataReader.Close();

            // SQL文：DELETE句
            query = @"DELETE FROM t_reservation_exam 
                    WHERE sub_id = @sub_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@sub_id", examItem.SubExamId);
            command.ExecuteNonQuery();

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            foreach (int reservationId in reservationIdList) {
                // SQL文：SELECT句
                query = @"SELECT * 
                        FROM t_reservation_exam 
                        WHERE reservation_id = @reservation_id";

                // コマンドの作成
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@reservation_id", reservationId);

                // データリーダーの作成
                dataReader = command.ExecuteReader();

                int count = 0;
                // データを１行ずつ抽出する
                while (dataReader.Read()) {
                    count++;
                }

                command.Dispose();
                dataReader.Close();

                if (count == 0) {
                    // SQL文：DELETE句
                    query = @"DELETE FROM m_reservation 
                            WHERE reservation_id = @reservation_id";

                    // トランザクションの作成
                    transaction = connection.BeginTransaction();

                    // コマンドの作成
                    command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@reservation_id", reservationId);
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    transaction.Dispose();
                    command.Dispose();
                }
            }

            // SQL文：DELETE句
            query = @"DELETE FROM m_sub_examination 
                    WHERE sub_id = @sub_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@sub_id", examItem.SubExamId);
            int recordNumber = command.ExecuteNonQuery(); // 削除されたレコード数

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }

        /// <summary>
        /// 診療大項目の名がすでに存在するかどうかを確認する
        /// </summary>
        /// <param name="examItem">診療大項目の名</param>
        /// <returns>true：存在する、false：存在しない</returns>
        public Boolean IsExistedMajorExamName(ExamItem examItem) {
            // SQL文：SELECT句
            string query = @"SELECT * 
							FROM m_major_examination 
                            WHERE major_name = @major_name OR major_name_en = @major_name_en";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@major_name", examItem.MajorExamNameJp);
            command.Parameters.AddWithValue("@major_name_en", examItem.MajorExamNameEn);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            int count = 0;
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                count++;
            }

            command.Dispose();
            dataReader.Close();

            if (count == 0)
                return false;
            return true;
        }

        /// <summary>
        /// 診療小項目の名がすでに存在するかどうかを確認する
        /// </summary>
        /// <param name="examItem">診療小項目の名</param>
        /// <returns>true：存在する、false：存在しない</returns>
        public Boolean IsExistedSubExamName(ExamItem examItem) {
            // SQL文：SELECT句
            string query = @"SELECT * 
							FROM m_sub_examination 
                            WHERE sub_name = @sub_name OR sub_name_en = @sub_name_en";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sub_name", examItem.SubExamNameJp);
            command.Parameters.AddWithValue("@sub_name_en", examItem.SubExamNameEn);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            int count = 0;
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                count++;
            }

            command.Dispose();
            dataReader.Close();

            if (count == 0)
                return false;
            return true;
        }
    }
}