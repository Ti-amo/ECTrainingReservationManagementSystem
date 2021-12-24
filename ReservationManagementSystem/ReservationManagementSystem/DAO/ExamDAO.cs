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
    class ExamDAO {
        /// <summary>
        /// データベースとのコネクション
        /// </summary>
        private readonly SqlConnection connection;
        /// <summary>
        /// コマンド
        /// </summary>
        private SqlCommand command;
        /// <summary>
        /// データリーダー
        /// </summary>
        private SqlDataReader dataReader;

        public ExamDAO() {
            // データベース接続の作成
            connection = new SqlConnection {
                ConnectionString = ConfigurationManager.ConnectionStrings["reservationdb"].ConnectionString
            };
            connection.Open();
        }

        /// <summary>
        /// すべての診療大項目を抽出する
        /// </summary>
        /// <returns>診療大項目のリスト</returns>
        public List<ExamItem> GetMajorExamList() {
            // SQL文：SELECT句
            string query = @"SELECT * 
							FROM m_major_examination";

            // コマンドの作成
            command = new SqlCommand(query, connection);

            // データリーダーの作成
            dataReader = command.ExecuteReader();

            List<ExamItem> majorExamList = new List<ExamItem>();
            // データを１行ずつ抽出する
            while (dataReader.Read()) {
                ExamItem majorExamItem = new ExamItem {
                    MajorExamId = (int)dataReader["major_id"],
                    MajorExamName = (string)dataReader["major_name"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                    majorExamItem.MajorExamName = (string)dataReader["major_name"];
                } else {
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
        public List<ExamItem> GetSubExamList(int majorId) {
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
            while (dataReader.Read()) {
                ExamItem subExamItem = new ExamItem {
                    MajorExamId = (int)dataReader["major_id"],
                    SubExamId = (int)dataReader["sub_id"]
                };
                if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                    subExamItem.MajorExamName = (string)dataReader["major_name"];
                    subExamItem.SubExamName = (string)dataReader["sub_name"];
                } else {
                    subExamItem.MajorExamName = (string)dataReader["major_name_en"];
                    subExamItem.SubExamName = (string)dataReader["sub_name_en"];
                }

                subExamList.Add(subExamItem);
            }

            command.Dispose();
            dataReader.Close();

            return subExamList;
        }
    }
}
