using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ReserveRegisterForm : Form
    {
        private ExamDAO examDAO = new ExamDAO();

        public ReserveRegisterForm()
        {
            InitializeComponent();
            FillDataComboBoxMajorItem();
        }

        private void FillDataComboBoxMajorItem()
        {
            List<ExamItem> listMajorExam = examDAO.GetMajorExamList();
            List<Object> items = new List<Object>();
            foreach (var item in listMajorExam)
            {
                items.Add(new { Text = item.MajorExamName, Value = item.MajorExamId });
            }
            ComboBoxMajorExam.DisplayMember = "Text";
            ComboBoxMajorExam.ValueMember = "Value";
            ComboBoxMajorExam.DataSource = items;
            //ComboBoxMajorExam.SelectedIndex = 0;
        }
        private void DateTimePickerReservationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxMajorExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSubExam.DataSource = null;
            List<ExamItem> listSubExam = examDAO.GetSubExamList(int.Parse(ComboBoxMajorExam.SelectedValue.ToString()));
            List<Object> items = new List<Object>();
            foreach (var item in listSubExam)
            {
                items.Add(new { Text = item.SubExamName, Value = item.SubExamId });
            }
            ComboBoxSubExam.DisplayMember = "Text";
            ComboBoxSubExam.ValueMember = "Value";
            ComboBoxSubExam.DataSource = items;
            //ComboBoxSubExam.SelectedIndex = 0;

        }

        private void ComboBoxSubExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            if (IsValidDate())
                MessageBox.Show("予約登録失敗しました。本日の後に予約日付を入力してください。");
            else
            {
                MessageBox.Show("予約登録完了しました。");
                ReservationDetailForm reservationDetailForm = new ReservationDetailForm(1);
                reservationDetailForm.Show();

            }

        }

        private bool IsValidDate()
        {
            DateTime date = DateTime.Parse(DateTimePickerReservationDate.Text);
            DateTime now = DateTime.Now;
            System.TimeSpan d = date.Subtract(now);
            double days = d.TotalDays;
            if (days < -1)
            {
                return true;
            }
            return false;
        }
    }
}
