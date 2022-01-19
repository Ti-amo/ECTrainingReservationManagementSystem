using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ManageExamForm2 : Form
    {
        private ExamDAO examDAO = new ExamDAO();
        ResourceManager rm = new ResourceManager(typeof(ReservationRegisterForm));

        public ManageExamForm2()
        {
            InitializeComponent();
            FillDataDropDownListMajorItem_Add();
            FillDataDropDownListMajorItem_Delete();


        }

        private void ManageExamForm2_Load(object sender, EventArgs e)
        {
            
        }

        private void FillDataDropDownListMajorItem_Add()
        {
            List<ExamItem> listMajorExam_Add = examDAO.GetMajorExamList();
             List<Object> items = new List<Object>();
             foreach (var item in listMajorExam_Add)
             {
                 items.Add(new { Text = item.MajorExamName, Value = item.MajorExamId });
             }
             DropDownListMajorItem_Add.DisplayMember = "Text";
             DropDownListMajorItem_Add.ValueMember = "Value";
             DropDownListMajorItem_Add.DataSource = items;
            
        }
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

        private void DropDownListMajorItem_Delete_SelectedIndexChanged_1(object sender, EventArgs e)
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
        private void ToggleButtonStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleButtonStatus.Checked)
            {
                PanelDelete.Visible = true;
            }
            else
            {
                PanelDelete.Visible = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            LabelLanguage.Visible = true;
            TextboxMajorItemName_Eng.Visible = true;
            DropDownListMajorItem_Add.Visible = false;
            TextboxMajorItemName_Ja.Visible = true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            
            ExamDAO examDAO = new ExamDAO();
            ExamItem examItem = new ExamItem();
            var id = DropDownListMajorItem_Add.SelectedValue;
            
                if (DropDownListMajorItem_Add.Visible)
            {  
                
                examItem.MajorExamId = (int)id;
                examItem.SubExamNameEn = TextboxSubItemName_Eng.Text;
                examItem.SubExamNameJp = TextboxSubItemName_Ja.Text;
                if (String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || (TextboxSubItemName_Ja.Text.Length > 25) || (TextboxSubItemName_Ja.Text.Length > 40))
                {
                    MessageBox.Show(rm.GetString("NameFailureMsg"), rm.GetString("RegisterFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    { }
                }
                else
                {
                    examDAO.InsertSubExam(examItem);
                    DialogResult result = MessageBox.Show(rm.GetString("RegisterSuccessMsg"), rm.GetString("RegisterSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
                else
            {
                examItem.MajorExamNameEn = TextboxMajorItemName_Eng.Text;
                examItem.MajorExamNameJp = TextboxMajorItemName_Ja.Text;
                examItem.SubExamNameEn = TextboxSubItemName_Eng.Text;
                examItem.SubExamNameJp = TextboxSubItemName_Ja.Text;
                if (String.IsNullOrWhiteSpace(TextboxMajorItemName_Ja.Text) || String.IsNullOrWhiteSpace(TextboxMajorItemName_Eng.Text) || String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || (TextboxMajorItemName_Ja.Text.Length > 5) || (TextboxMajorItemName_Eng.Text.Length > 15) || (TextboxSubItemName_Ja.Text.Length > 25) || (TextboxSubItemName_Ja.Text.Length > 40))
                {
                    MessageBox.Show(rm.GetString("NameFailureMsg"), rm.GetString("RegisterFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    { }
                }
                else
                {
                    examDAO.InsertMajorExam(examItem);
                    DialogResult result = MessageBox.Show(rm.GetString("RegisterSuccessMsg"), rm.GetString("RegisterSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            } 
                
        }

        private void ButtonDelete_Click_1(object sender, EventArgs e)
        {
            ExamDAO examDAO = new ExamDAO();
            ExamItem examItem = new ExamItem();
            examItem.SubExamId = (int)DropDownListSubItem_Delete.SelectedValue;
            DialogResult result = MessageBox.Show(rm.GetString("DeleteConfirmMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                examDAO.DeleteSubExam(examItem);
               // DialogResult result = MessageBox.Show(rm.GetString("RegisterSuccessMsg"), rm.GetString("RegisterSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
               /* if (result == DialogResult.OK)
                {
                    this.Close();
                }*/
               // reservationDAO.Delete(reservationEntity);
                MessageBox.Show(rm.GetString("DeleteSuccessMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
            
        }
    }
}
