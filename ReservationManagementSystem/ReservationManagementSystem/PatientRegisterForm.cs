using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;

namespace ReservationManagementSystem
{
    public partial class PatientRegisterForm : Form
    {
        private readonly ExamDAO examDAO = new ExamDAO();

        public PatientRegisterForm()
        {
            InitializeComponent();
            FillDataComboBoxMajorItem();
        }
        /// <summary>
        /// 診療項目を設定する
        /// </summary>
        private void FillDataComboBoxMajorItem()
        {
            List<ExamItem> listMajorExam = examDAO.GetMajorExamList();
            List<Object> items = new List<Object>();
            foreach (var item in listMajorExam)
            {
                items.Add(new {Text = item.MajorExamName, Value = item.MajorExamId });
            }
            ComboBoxMajorExam.DisplayMember = "Text";
            ComboBoxMajorExam.ValueMember = "Value";
            ComboBoxMajorExam.DataSource = items;
        }
        /// <summary>
        /// 診療項目が変わると、小項目を設定する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MajorExamChanged(object sender, EventArgs e)
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
        }
        /// <summary>
        /// バリデート生年月日
        /// </summary>
        /// <returns></returns>
        private bool ValidateBirthDate()
        {
            DateTime birthDate = DateTime.Parse(DatetimePickerBirthDate.Text).Date;
            DateTime localDate = DateTime.Now.Date;

            if (birthDate < localDate)
            {
                return true;
            }
            return false;
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
        /// <summary>
        /// 予約する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            PatientDAO patientDAO = new PatientDAO();   
            ReservationDAO reservationDAO = new ReservationDAO();   
            PatientEntity patientEntity = new PatientEntity();
            ReservationEntity reservationEntity = new ReservationEntity();

            patientEntity.Name = TextBoxName.Text;
            patientEntity.BirthDate = DatetimePickerBirthDate.Value.ToString("yyyy-MM-dd");
            
            if (String.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                MessageBox.Show("患者名を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidateBirthDate()) {
                MessageBox.Show("生年月日は本日より後でいけません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!ValidateReservationDate()) {
                MessageBox.Show("本日の後に予約日付を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //患者登録
                patientDAO.Insert(patientEntity);

                //予約登録
                reservationEntity.PatientId = patientDAO.FindLatestPatient();
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
    }
}
