﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class MenuForm : Form
    {
        private readonly Utility util = new Utility(); 

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(-8, 0);
            this.BackgroundImage = Properties.Resources.background;
            this.Size = new Size(360, Screen.PrimaryScreen.Bounds.Height+10);
        }
        /// <summary>
        /// フォームがつかっているかどうかをチェックする
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        
        /// <summary>
        /// 患者リストフォームを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPatientList_Click(object sender, EventArgs e)
        { 
            if (!util.CheckFormIsOpen("PatientList"))
            {
                PatientListForm patientListForm = new PatientListForm();
                patientListForm.Show();
            }
        }
        /// <summary>
        /// 患者登録を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPatientRegister_Click(object sender, EventArgs e)
        {
            if (!util.CheckFormIsOpen("PatientRegister"))
            {
                PatientRegisterForm patientRegisterForm = new PatientRegisterForm();
                patientRegisterForm.Show();
            }
        }
        /// <summary>
        /// 予約日付ごとに患者一覧を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReservationList_Click(object sender, EventArgs e)
        {
            if (!util.CheckFormIsOpen("ReservationListByDate"))
            {
                ReservationListByDateForm reservationListByDateForm = new ReservationListByDateForm();
                reservationListByDateForm.Show();
            }
        }
    }
}
