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
            //ComboBoxMajorExam.SelectedIndex = 0;
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
            //ComboBoxSubExam.SelectedIndex = 0;
        }
        /// <summary>
        /// 予約する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            PatientEntity patientEntity = new PatientEntity();
            ReservationEntity reservationEntity = new ReservationEntity();  

            patientEntity.Name = TextBoxName.Text;
            patientEntity.BirthDate = DatetimePickerBirthDate.Value.ToString("yyyy-MM-dd");
            reservationEntity.ReservationDate = DateTimePickerReservationDate.Value.ToString("yyyy-MM-dd");

            MessageBox.Show(patientEntity.Name + patientEntity.BirthDate + reservationEntity.ReservationDate);
        }
    }
}
