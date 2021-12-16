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
        private ExamDAO examDAO = new ExamDAO();

        public PatientRegisterForm()
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
                items.Add(new {Text = item.MajorExamName, Value = item.MajorExamId });
            }
            ComboBoxMajorExam.DisplayMember = "Text";
            ComboBoxMajorExam.ValueMember = "Value";
            ComboBoxMajorExam.DataSource = items;
            ComboBoxMajorExam.SelectedIndex = 0;
        }

        private void MajorExamChanged(object sender, EventArgs e)
        {
            ComboBoxSubExam.Items.Clear();
            List<ExamItem> listSubExam = examDAO.GetSubExamList(1);
            List<Object> items = new List<Object>();
            foreach (var item in listSubExam)
            {
                items.Add(new { Text = item.SubExamName, Value = item.SubExamId });
            }
            ComboBoxSubExam.DisplayMember = "Text";
            ComboBoxSubExam.ValueMember = "Value";
            ComboBoxSubExam.DataSource = items;
            ComboBoxSubExam.SelectedIndex = 0;
            MessageBox.Show(ComboBoxMajorExam.SelectedValue.ToString());
        }
    }
}
