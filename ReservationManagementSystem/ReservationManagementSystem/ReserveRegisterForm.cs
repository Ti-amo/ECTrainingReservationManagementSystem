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
        public string PatientId { get; set; }

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
            PatientDAO patientDAO = new PatientDAO();
            ReservationDAO reservationDAO = new ReservationDAO();
            PatientEntity patientEntity = new PatientEntity();
            ReservationEntity reservationEntity = new ReservationEntity();

            if (!ValidateReservationDate())
            {
                MessageBox.Show("本日の後に予約日付を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //予約登録
                reservationEntity.PatientId = this.PatientId;
                reservationEntity.ReservationDate = DateTimePickerReservationDate.Value.ToString("yyyy-MM-dd");
                ExamItem examItem = new ExamItem
                {
                    SubExamId = int.Parse(ComboBoxSubExam.SelectedValue.ToString())
                };
                reservationEntity.Exam = examItem;
                reservationDAO.Insert(reservationEntity);
                string message = "予約登録が成功しました。";
                string title = "成功";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    //予約詳細画面に進め
                    ReservationDetailForm reservationDetailForm = new ReservationDetailForm(reservationDAO.FindLatestReservation());
                    reservationDetailForm.Show();
                }
            }

        }

        /// <summary>
        /// バリデート予約日付
        /// </summary>
        /// <returns></returns>
        private bool ValidateReservationDate()
        {
            DateTime reservationDate = DateTime.Parse(DateTimePickerReservationDate.Text).Date;
            DateTime localDate = DateTime.Now.Date;

            if (reservationDate >= localDate)
            {
                return true;
            }
            return false;
        }
    }
}
