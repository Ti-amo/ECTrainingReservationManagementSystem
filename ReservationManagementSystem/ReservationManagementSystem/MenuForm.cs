using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background;
        }
        /// <summary>
        /// 患者リストフォームを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPatientList_Click(object sender, EventArgs e)
        {
            PatientListForm patientListForm = new PatientListForm();
            patientListForm.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPatientRegister_Click(object sender, EventArgs e)
        {
            PatientRegisterForm patientRegisterForm = new PatientRegisterForm();
            patientRegisterForm.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReservationList_Click(object sender, EventArgs e)
        {

        }
    }
}
