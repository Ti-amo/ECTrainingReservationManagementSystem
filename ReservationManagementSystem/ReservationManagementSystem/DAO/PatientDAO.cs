using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagementSystem.DAO {
    class PatientDAO {
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

        public PatientDAO() {
            // データベース接続の作成
            connection = new SqlConnection {
                ConnectionString = ConfigurationManager.ConnectionStrings["reservationdb"].ConnectionString
            };
            connection.Open();
        }

        /// <summary>
        /// すべての患者を抽出する
        /// </summary>
        /// <returns>すべての患者</returns>
        public List<PatientEntity> FindAll() {
            // すべての患者のリスト
            List<PatientEntity> patientList = new List<PatientEntity>();

            // SQL文：SELECT句
            string query = @"SELECT * 
                            FROM m_patient";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            // データリーダーの作成
            dataReader = command.ExecuteReader();

            ReservationDAO reservationDAO = new ReservationDAO();

            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                // １患者ずつ抽出する
                PatientEntity patientEntity = new PatientEntity {
                    PatientId = (string)dataReader["combined_id"],
                    Name = (string)dataReader["name"],
                    BirthDate = Convert.ToDateTime(dataReader["birth_date"]).ToString("yyyy-MM-dd")
                };
                patientEntity.ReservationList = reservationDAO.FindByPatient(patientEntity.PatientId);

                // 患者をリストに格納する
                patientList.Add(patientEntity);
            }

            command.Dispose();
            dataReader.Close();

            return patientList;
        }

        /// <summary>
        /// 患者IDまたは患者名によるすべての患者を抽出する
        /// </summary>
        /// <param name="idOrName">患者IDまたは患者名</param>
        /// <returns>すべての患者</returns>
        public List<PatientEntity> FindByIdOrName(string patientIdOrName) {
            // すべての患者のリスト
            List<PatientEntity> patientList = new List<PatientEntity>();

            // SQL文：SELECT句
            string query = @"SELECT * 
                            FROM m_patient 
                            WHERE (combined_id LIKE @id OR name LIKE @name)";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", "%" + patientIdOrName + "%");
            command.Parameters.AddWithValue("@name", "%" + patientIdOrName + "%");

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            ReservationDAO reservationDAO = new ReservationDAO();

            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                // １患者ずつ抽出する
                PatientEntity patientEntity = new PatientEntity {
                    PatientId = (string)dataReader["combined_id"],
                    Name = (string)dataReader["name"],
                    BirthDate = Convert.ToDateTime(dataReader["birth_date"]).ToString("yyyy-MM-dd")
                };
                patientEntity.ReservationList = reservationDAO.FindByPatient(patientEntity.PatientId);

                // 患者をリストに格納する
                patientList.Add(patientEntity);
            }

            command.Dispose();
            dataReader.Close();

            return patientList;
        }

        /// <summary>
        /// 指定した患者を抽出する
        /// </summary>
        /// <param name="patientId">患者ID</param>
        /// <returns>指定した患者</returns>
        public PatientEntity Find(string patientId) {
            // SQL文：SELECT句
            string query = @"SELECT * 
                            FROM m_patient 
                            WHERE combined_id = @id";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", patientId);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            ReservationDAO reservationDAO = new ReservationDAO();

            PatientEntity patientEntity = null;
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                // １患者ずつ抽出する
                patientEntity = new PatientEntity {
                    PatientId = (string)dataReader["combined_id"],
                    Name = (string)dataReader["name"],
                    BirthDate = Convert.ToDateTime(dataReader["birth_date"]).ToString("yyyy-MM-dd")
                };
                patientEntity.ReservationList = reservationDAO.FindByPatient(patientEntity.PatientId);
            }

            command.Dispose();
            dataReader.Close();

            return patientEntity;
        }
        /// <summary>
        /// 最新の患者IDを見つける
        /// </summary>
        /// <returns></returns>
        public string FindLatestPatient()
        {
            // SQL文：SELECT句
            string query = @"SELECT TOP 1 *
                             FROM m_patient
                             ORDER BY created DESC";

            // コマンドの作成
            command = new SqlCommand(query, connection);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            string patientId = null;
            // データを１行ずつ抽出する
            while (dataReader.Read())
            {
                patientId = (string)dataReader["combined_id"];
            }

            command.Dispose();
            dataReader.Close();

            return patientId;
        }

        /// <summary>
        /// 指定した患者を挿入する
        /// </summary>
        /// <param name="patientEntity">挿入された患者</param>
        /// <returns>挿入されたレコード数</returns>
        public int Insert(PatientEntity patientEntity) {
            // SQL文：INSERT句
            string query = @"INSERT INTO m_patient (name, birth_date)
							VALUES (@name, CAST(@birth_date AS Date))";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@name", patientEntity.Name);
            command.Parameters.AddWithValue("@birth_date", patientEntity.BirthDate);

            int recordNumber = command.ExecuteNonQuery(); // 挿入されたレコード数
            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }

        /// <summary>
        /// 指定した患者を更新する
        /// </summary>
        /// <param name="patientEntity">更新された患者</param>
        /// <returns>更新されたレコード数</returns>
        public int Update(PatientEntity patientEntity) {
            // SQL文：UPDATE句
            string query = @"UPDATE m_patient 
							SET name = @name, birth_date = CAST(@birth_date AS Date) 
							WHERE combined_id = @id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@id", patientEntity.PatientId);
            command.Parameters.AddWithValue("@name", patientEntity.Name);
            command.Parameters.AddWithValue("@birth_date", patientEntity.BirthDate);

            int recordNumber = command.ExecuteNonQuery(); // 更新されたレコード数
            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }

        /// <summary>
        /// 指定した患者を削除する
        /// </summary>
        /// <param name="patientEntity">削除された患者</param>
        /// <returns>削除されたレコード数</returns>
        public int Delete(PatientEntity patientEntity) {
            // 「EC」と「0」を削除して、intに変換する
            int patientId = int.Parse(patientEntity.PatientId.Remove(0, 2));

            // SQL文：DELETE句
            string query = @"DELETE FROM m_reservation 
							WHERE patient_id = @patient_id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@patient_id", patientId);
            command.ExecuteNonQuery();

            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            // SQL文：DELETE句
            query = @"DELETE FROM m_patient 
                    WHERE combined_id = @id";

            // トランザクションの作成
            transaction = connection.BeginTransaction();

            // コマンドの作成
            command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@id", patientEntity.PatientId);

            int recordNumber = command.ExecuteNonQuery(); // 削除されたレコード数
            transaction.Commit();
            transaction.Dispose();
            command.Dispose();

            return recordNumber;
        }
    }
}
