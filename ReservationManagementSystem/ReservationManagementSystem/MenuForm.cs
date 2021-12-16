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
            this.BackgroundImage = Properties.Resources.background;
            this.Resize += MenuForm_Resize;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// フォームサイズに応じてコントロールの位置を変更する
        /// </summary>
        /// <param name="formHeight"></param>
        /// <param name="formWidth"></param>
        private void SetLocationOfContainer(int formHeight, int formWidth)
        {
            ContainerMenu.Location = new Point((formWidth - ContainerMenu.Width) / 2,
                (formHeight - ContainerMenu.Height) / 2);
        }
        /// <summary>
        /// フォームのサイズを変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuForm_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            SetLocationOfContainer(control.Size.Height, control.Size.Width);
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
