using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ExamItemAddForm : Form
    {
        private ExamDAO examDAO = new ExamDAO();
        private ResourceManager rm = new ResourceManager(typeof(ReservationRegisterForm));
        private bool editStatus = false;

        public ExamItemAddForm()
        {
            InitializeComponent();
        }

        private void ExamItemAddForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            FillDataDropDownListMajorItem_Add();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!editStatus)
            {
                ButtonEdit.BackgroundImage = Properties.Resources.close;
                LabelLanguage.Visible = true;
                TextboxMajorItemName_Eng.Visible = true;
                DropDownListMajorItem_Add.Visible = false;
                TextboxMajorItemName_Ja.Visible = true;
            }
            else
            {
                ButtonEdit.BackgroundImage = Properties.Resources.add;
                LabelLanguage.Visible = false;
                TextboxMajorItemName_Eng.Text = "";
                TextboxMajorItemName_Eng.Visible = false;
                DropDownListMajorItem_Add.Visible = true;
                TextboxMajorItemName_Ja.Text = "";
                TextboxMajorItemName_Ja.Visible = false;
            }
            editStatus = !editStatus;
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
                if (String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || (TextboxSubItemName_Ja.Text.Length > 25) || (TextboxSubItemName_Ja.Text.Length > 40) || examDAO.IsExistedSubExamName(examItem))
                {
                    MessageBox.Show(rm.GetString("NameFailureMsg"), rm.GetString("RegisterFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    examDAO.InsertSubExam(examItem);
                    DialogResult result = MessageBox.Show(rm.GetString("RegisterSuccessMsg"), rm.GetString("RegisterSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        this.ReloadForm();
                    }
                }
            }
            else
            {
                examItem.MajorExamNameEn = TextboxMajorItemName_Eng.Text;
                examItem.MajorExamNameJp = TextboxMajorItemName_Ja.Text;
                examItem.SubExamNameEn = TextboxSubItemName_Eng.Text;
                examItem.SubExamNameJp = TextboxSubItemName_Ja.Text;
                if (String.IsNullOrWhiteSpace(TextboxMajorItemName_Ja.Text) || String.IsNullOrWhiteSpace(TextboxMajorItemName_Eng.Text) || String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || String.IsNullOrWhiteSpace(TextboxSubItemName_Eng.Text) || (TextboxMajorItemName_Ja.Text.Length > 5) || (TextboxMajorItemName_Eng.Text.Length > 15) || (TextboxSubItemName_Ja.Text.Length > 25) || (TextboxSubItemName_Ja.Text.Length > 40) || examDAO.IsExistedMajorExamName(examItem) || examDAO.IsExistedSubExamName(examItem))
                {
                    MessageBox.Show(rm.GetString("NameFailureMsg"), rm.GetString("RegisterFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    examDAO.InsertMajorExam(examItem);
                    DialogResult result = MessageBox.Show(rm.GetString("RegisterSuccessMsg"), rm.GetString("RegisterSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        this.ReloadForm();
                    }
                }
            }
        }
    }
}
