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
        private ResourceManager rm = new ResourceManager(typeof(ExamItemDeleteForm));
        public bool deleteStatus = false;

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

        public void ReloadForm()
        {
            LoadForm();
        }

        /// <summary>
        /// 診療大項目一覧をDropdownlistに入れる
        /// </summary>
        private void FillDataDropDownListMajorItem_Delete()
        {
            List<ExamItem> listMajorExam_Delete = examDAO.GetAllMajorExamList();
            if (listMajorExam_Delete.Count == 0)
            {
                PanelNotification.Visible = true;

                DropDownListMajorItem_Delete.DataSource = null;
            }
            else
            {
                PanelNotification.Visible = false;

                List<Object> items = new List<Object>();
                foreach (var item in listMajorExam_Delete)
                {
                    items.Add(new { Text = item.MajorExamName, Value = item.MajorExamId });
                }
                DropDownListMajorItem_Delete.DisplayMember = "Text";
                DropDownListMajorItem_Delete.ValueMember = "Value";
                DropDownListMajorItem_Delete.DataSource = items;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="btnDeleteStatus"></param>
        /// <param name="lbSubItemStatus"></param>
        /// <param name="ddlSubItemStatus"></param>
        /// <param name="lbNotiStatus"></param>
        private void SetNotification(bool btnDeleteStatus, bool lbSubItemStatus, bool ddlSubItemStatus, bool lbNotiStatus)
        {
            ButtonDeleteSubExam.Visible = btnDeleteStatus;
            LabelSubExam.Visible = lbSubItemStatus;
            DropDownListSubItem_Delete.Visible = ddlSubItemStatus;
            LabelNotification.Visible = lbNotiStatus;
        }

        /// <summary>
        ///  診療小項目一覧をDropdownlistに入れる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropDownListMajorItem_Delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListMajorItem_Delete.DataSource != null)
            {
                List<ExamItem> subExamList = examDAO.GetSubExamList(int.Parse(DropDownListMajorItem_Delete.SelectedValue.ToString()));
                if (subExamList.Count == 0)
                {
                    DropDownListSubItem_Delete.DataSource = null;

                    SetNotification(false, false, false, true);
                }
                else
                {
                    List<Object> subItems = new List<Object>();
                    foreach (ExamItem subExam in subExamList)
                    {
                        subItems.Add(new { Value = subExam.SubExamId, Text = subExam.SubExamName });
                    }
                    DropDownListSubItem_Delete.ValueMember = "Value";
                    DropDownListSubItem_Delete.DisplayMember = "Text";
                    DropDownListSubItem_Delete.DataSource = subItems;

                    SetNotification(true, true, true, false);
                }
            }
            else
            {
                DropDownListSubItem_Delete.DataSource = null;
            }
        }

        /// <summary>
        /// 小項目を削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteSubExam_Click(object sender, EventArgs e)
        {
            if (DropDownListSubItem_Delete.Items.Count != 0)
            {
                ExamItem examItem = new ExamItem();
                examItem.SubExamId = (int)DropDownListSubItem_Delete.SelectedValue;
                DialogResult result = MessageBox.Show(rm.GetString("DeleteConfirmMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    examDAO.DeleteSubExam(examItem);
                    MessageBox.Show(rm.GetString("DeleteSuccessMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ReloadForm();
                    deleteStatus = true;
                }
            }
        }

        /// <summary>
        /// 大項目を削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteMajorExam_Click(object sender, EventArgs e)
        {
            if (DropDownListMajorItem_Delete.Items.Count != 0)
            {
                ExamItem examItem = new ExamItem();
                examItem.MajorExamId = (int)DropDownListMajorItem_Delete.SelectedValue;
                DialogResult result = MessageBox.Show(rm.GetString("DeleteConfirmMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    examDAO.DeleteMajorExam(examItem);
                    MessageBox.Show(rm.GetString("DeleteSuccessMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ReloadForm();
                    deleteStatus = true;
                }
            }
        }
    }
}
