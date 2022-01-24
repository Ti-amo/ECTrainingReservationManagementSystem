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
        private ResourceManager rm = new ResourceManager(typeof(ExamItemAddForm));
        private bool editStatus = false;
        public bool addStatus = false;

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

        public void ReloadForm()
        {
            LoadForm();

            TextboxMajorItemName_Ja.Text = "";
            TextboxMajorItemName_Eng.Text = "";
            TextboxSubItemName_Ja.Text = "";
            TextboxSubItemName_Eng.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lbLanguageStatus"></param>
        /// <param name="tbMajorItemName_EngStatus"></param>
        /// <param name="ddlMajorItemStatus"></param>
        /// <param name="tbMajorItemName_JaStatus"></param>
        private void SetVisibleStatusOfControls(bool lbLanguageStatus, bool tbMajorItemName_EngStatus, 
            bool ddlMajorItemStatus, bool tbMajorItemName_JaStatus)
        {
            LabelLanguage.Visible = lbLanguageStatus;
            TextboxMajorItemName_Eng.Visible = tbMajorItemName_EngStatus;
            DropDownListMajorItem_Add.Visible = ddlMajorItemStatus;
            TextboxMajorItemName_Ja.Visible = tbMajorItemName_JaStatus;
        }

        /// <summary>
        /// 診療大項目一覧をDropdownlistに入れる
        /// </summary>
        private void FillDataDropDownListMajorItem_Add()
        {
            List<ExamItem> listMajorExam_Add = examDAO.GetAllMajorExamList();
            if(listMajorExam_Add.Count == 0)
            {
                DropDownListMajorItem_Add.DataSource = null;
                SetVisibleStatusOfControls(true, true, false, true);
                ButtonEdit.Visible = false;
                // MessageBox.Show(rm.GetString("RegisterSuccessMsg"), rm.GetString("RegisterSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetVisibleStatusOfControls(false, false, true, false);
                ButtonEdit.Visible = true;

                List<Object> items = new List<Object>();
                foreach (var item in listMajorExam_Add)
                {
                    items.Add(new { Text = item.MajorExamName, Value = item.MajorExamId });
                }
                DropDownListMajorItem_Add.DisplayMember = "Text";
                DropDownListMajorItem_Add.ValueMember = "Value";
                DropDownListMajorItem_Add.DataSource = items;
            }
        }

        /// <summary>
        /// 新しい診療大項目を追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!editStatus)
            {
                ButtonEdit.BackgroundImage = Properties.Resources.close;
                SetVisibleStatusOfControls(true, true, false, true);
            }
            else
            {
                ButtonEdit.BackgroundImage = Properties.Resources.add;
                SetVisibleStatusOfControls(false, false, true, false);
                TextboxMajorItemName_Eng.Text = "";
                TextboxMajorItemName_Ja.Text = "";
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
                    MessageBox.Show(rm.GetString("NameFailureMsg"), rm.GetString("AddFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    examDAO.InsertSubExam(examItem);
                    DialogResult result = MessageBox.Show(rm.GetString("AddSuccessMsg"), rm.GetString("AddSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        addStatus = true;
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
                    MessageBox.Show(rm.GetString("NameFailureMsg"), rm.GetString("AddFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    examDAO.InsertMajorExam(examItem);
                    DialogResult result = MessageBox.Show(rm.GetString("AddSuccessMsg"), rm.GetString("AddSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        addStatus = true;
                        this.ReloadForm();
                    }
                }
            }
        }
    }
}
