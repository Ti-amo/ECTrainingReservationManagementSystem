using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagementSystem {
    public class Utility {
        public bool CheckFormIsOpen(string formName) {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms) {
                if (f.Name == formName) {
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
}
