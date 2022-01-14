using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ReservationManagementSystem {
    public class Utility
    {
        public bool CheckFormIsOpen(string formName)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)
                {
                    IsOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            return IsOpen;
        }
        /// <summary>
        /// Set color with Reservation StatusId
        /// </summary>
        /// <param name="cellIndex"></param>
        /// <param name="dataGridView"></param>
        public void SetColorByStatus(int cellIndex, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[cellIndex].Value.ToString().Contains("1"))
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#95ef5d");
                }
                else if (row.Cells[cellIndex].Value.ToString().Contains("2"))
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f1f772");
                }
                else
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#d5a6bd");
                }
            }
        }
    }
    public class StatusItem
    {
        /// <summary>
        /// StatusId
        /// </summary>
        public int StatusId {get; set; }
        /// <summary>
        /// Status Name
        /// </summary>
        public string StatusName {get; set; }
        /// <summary>
        /// Status Name Eng
        /// </summary>
        public string StatusNameEn {get; set; }
        public List<StatusItem> StatusList()
        {
            SqlConnection connection = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["reservationdb"].ConnectionString
            };
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            List<StatusItem> statusList = new List<StatusItem>();

            // SQL文：SELECT句
            string query = @"SELECT * 
                        FROM m_status";

            // コマンドの作成
            command = new SqlCommand(query, connection);
            // データリーダーの作成
            dataReader = command.ExecuteReader();

            // データを１行ずつ抽出する
            while (dataReader.Read())
            {
                // １患者ずつ抽出する
                StatusItem statusItem = new StatusItem
                {
                    StatusId = (int)dataReader["status_id"],
                    StatusName = (string)dataReader["status_name"],
                    StatusNameEn = (string)dataReader["status_name_en"],
                };
                statusList.Add(statusItem);
            }

            command.Dispose();
            dataReader.Close();

            return statusList;
        }
    }
}
