﻿using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ManageExamForm : Form
    {
        public ManageExamForm()
        {
            InitializeComponent();
        }

        private void ManageExamForm_Load(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, System.EventArgs e)
        {
            LabelLanguage.Visible = true;
            TextboxMajorItemName_Eng.Visible = true;
            DropDownListMajorItem_Add.Visible = false;
            TextboxMajorItemName_Ja.Visible = true;
        }
    }
}