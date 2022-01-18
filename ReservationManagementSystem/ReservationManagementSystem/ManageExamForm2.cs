using System;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ManageExamForm2 : Form
    {
        public ManageExamForm2()
        {
            InitializeComponent();
        }

        private void ManageExamForm2_Load(object sender, EventArgs e)
        {
            
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
        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
