using System;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace ReservationManagementSystem {
    public partial class MenuForm : Form {
        private readonly Utility util = new Utility();

        public MenuForm() {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e) {
            this.Location = new Point(-8, 0);
            this.BackgroundImage = Properties.Resources.background;
            this.Size = new Size(360, Screen.PrimaryScreen.Bounds.Height + 10);
        }

        /// <summary>
        /// 患者リストを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPatientList_Click(object sender, EventArgs e) {
            if (!util.CheckFormIsOpen("PatientListForm")) {
                PatientListForm patientListForm = new PatientListForm();
                patientListForm.Show();
            }
        }

        /// <summary>
        /// 患者登録を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPatientRegister_Click(object sender, EventArgs e) {
            if (!util.CheckFormIsOpen("PatientRegisterForm")) {
                PatientRegisterForm patientRegisterForm = new PatientRegisterForm();
                patientRegisterForm.Show();
            }
        }

        /// <summary>
        /// 予約日付ごとに患者一覧を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReservationList_Click(object sender, EventArgs e) {
            if (!util.CheckFormIsOpen("ReservationListByDateForm")) {
                ReservationListByDateForm reservationListByDateForm = new ReservationListByDateForm();
                reservationListByDateForm.Show();
            }
        }

        /// <summary>
        /// アプリの言語を変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLanguage_Click(object sender, EventArgs e) {
            if (Thread.CurrentThread.CurrentCulture.Name.Equals("ja-JP")) {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            } else {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ja-JP");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja-JP");
            }
            for (int i = Application.OpenForms.Count - 1; i > 0; i = Application.OpenForms.Count - 1) {
                if (!Application.OpenForms[i].Name.Equals("MenuForm"))
                    Application.OpenForms[i].Close();
            }

            this.Controls.Clear();
            InitializeComponent();

            this.Location = new Point(-8, 0);
            this.BackgroundImage = Properties.Resources.background;
            this.Size = new Size(360, Screen.PrimaryScreen.Bounds.Height + 10);

            ResourceManager rm = new ResourceManager(typeof(MenuForm));
            MessageBox.Show(rm.GetString("ChangeLanguageMsg"), rm.GetString("ChangeLanguageTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExam_Click(object sender, EventArgs e)
        {
            ManageExamForm manageExamForm = new ManageExamForm();
            manageExamForm.Show();
        }
    }
}
