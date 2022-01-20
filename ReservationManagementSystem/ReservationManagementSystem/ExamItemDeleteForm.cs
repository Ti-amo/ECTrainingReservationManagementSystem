using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ExamItemDeleteForm : Form
    {
        private ExamDAO examDAO = new ExamDAO();
        private ResourceManager rm = new ResourceManager(typeof(ReservationRegisterForm));
        public ExamItemDeleteForm()
        {
            InitializeComponent();
        }

        private void ExamItemDeleteForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            FillDataDropDownListMajorItem_Delete();
        }

        private void ReloadForm()
        {
            this.Controls.Clear();
            InitializeComponent();
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillDataDropDownListMajorItem_Delete()
        {
            List<ExamItem> listMajorExam_Delete = examDAO.GetMajorExamList();
            List<Object> items = new List<Object>();
            foreach (var item in listMajorExam_Delete)
            {
                items.Add(new { Text = item.MajorExamName, Value = item.MajorExamId });
            }
            DropDownListMajorItem_Delete.DisplayMember = "Text";
            DropDownListMajorItem_Delete.ValueMember = "Value";
            DropDownListMajorItem_Delete.DataSource = items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropDownListMajorItem_Delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ExamItem> subExamList = examDAO.GetSubExamList(int.Parse(DropDownListMajorItem_Delete.SelectedValue.ToString()));
            List<Object> subItems = new List<Object>();
            foreach (ExamItem subExam in subExamList)
            {
                subItems.Add(new { Value = subExam.SubExamId, Text = subExam.SubExamName });
            }
            DropDownListSubItem_Delete.ValueMember = "Value";
            DropDownListSubItem_Delete.DisplayMember = "Text";
            DropDownListSubItem_Delete.DataSource = subItems;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            ExamDAO examDAO = new ExamDAO();
            ExamItem examItem = new ExamItem();
            examItem.SubExamId = (int)DropDownListSubItem_Delete.SelectedValue;
            DialogResult result = MessageBox.Show(rm.GetString("DeleteConfirmMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                examDAO.DeleteSubExam(examItem);
                MessageBox.Show(rm.GetString("DeleteSuccessMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                this.ReloadForm();
            }
        }
    }
}
