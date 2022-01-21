using System;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ManageExamForm : Form
    {
        private ExamItemDeleteForm examItemDeleteForm = new ExamItemDeleteForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        private ExamItemAddForm examItemAddForm = new ExamItemAddForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        public ManageExamForm()
        {
            InitializeComponent();
        }

        private void ManageExamForm2_Load(object sender, EventArgs e)
        {
            this.PanelContainer.Controls.Add(examItemAddForm);
            examItemAddForm.Show();
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
                this.PanelContainer.Controls.Clear();
                this.PanelContainer.Controls.Add(examItemDeleteForm);
                examItemDeleteForm.Show();
                if (examItemAddForm.addStatus)
                {
                    examItemAddForm.addStatus = false;
                    examItemDeleteForm.ReloadForm();
                }
            }
            else
            {
                this.PanelContainer.Controls.Clear();
                this.PanelContainer.Controls.Add(examItemAddForm);
                examItemAddForm.Show();
                if (examItemDeleteForm.deleteStatus)
                {
                    examItemDeleteForm.deleteStatus = false;
                    examItemAddForm.ReloadForm();
                }
            }
        }
    }
}
