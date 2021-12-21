﻿using PagedList;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class PatientDetailInfoForm : Form
    {
        public string PatientId { get; set; }                                          // 患者ID
        private PatientEntity patient = new PatientEntity();                           // 患者
        private int pageNumber = 1;                                                    // ページ番号
        private IPagedList<ReservationEntity> reservationPagedList;                    // ページ一覧     
        private List<ReservationEntity> reservations = new List<ReservationEntity>();　// 予約一覧
        public PatientDetailInfoForm()
        {
            InitializeComponent();
        }

        private void PatientDetailInfoForm_Load(object sender, EventArgs e)
        {
            PatientDAO patientDAO = new PatientDAO();
            patient = patientDAO.Find(PatientId);

            ReservationDAO reservationDAO = new ReservationDAO();
            reservations = reservationDAO.FindByPatient(PatientId);
            // draw line
            LabelLine.Text = string.Empty;
            LabelLine.BorderStyle = BorderStyle.Fixed3D;
            LabelLine.AutoSize = false;
            LabelLine.Height = 3;
            LabelLine.Width = DataGridViewReserveList.Width;

            FillData();

            PagingReservationtList();

            SetupControls();
        }
        /// <summary>
        /// テキストボックスにデータを入力する
        /// </summary>
        private void FillData()
        {
            TextboxId.Text = patient.PatientId;
            TextboxName.Text = patient.Name;
            TextboxDateOfBirth.Text = patient.BirthDate;
        }
        /// <summary>
        /// ページ付けを実行する
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        private void PagingReservationtList(int pageNumber = 1, int pageSize = 10)
        {
            reservationPagedList = reservations.ToPagedList(pageNumber, pageSize);
            ButtonPrevious.Enabled = reservationPagedList.HasPreviousPage;
            ButtonNext.Enabled = reservationPagedList.HasNextPage;
            LabelPageNumber.Text = string.Format("{0}/{1}", pageNumber, reservationPagedList.PageCount);
            // fill data to datagridview
            DataGridViewReserveList.DataSource = reservationPagedList.ToList();
        }
        /// <summary>
        /// コントロールを設定する
        /// </summary>
        private void SetupControls()
        {
            // set up headertext of columns in dgv
            DataGridViewReserveList.Columns["ReservationId"].HeaderText = "予約ID";
            DataGridViewReserveList.Columns["ReservationDate"].HeaderText = "予約日付";
            DataGridViewReserveList.Columns["StatusName"].HeaderText = "状態";

            DataGridViewReserveList.Columns["PatientId"].Visible = false;
            DataGridViewReserveList.Columns["PatientName"].Visible = false;
            DataGridViewReserveList.Columns["StatusId"].Visible = false;
            DataGridViewReserveList.Columns["Exam"].Visible = false;
            // add button detail to dgv
            DataGridViewButtonColumn buttonDetail = new DataGridViewButtonColumn();
            buttonDetail.Text = "詳細";
            buttonDetail.UseColumnTextForButtonValue = true;
            buttonDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            buttonDetail.Width = 100;
            DataGridViewReserveList.Columns.Add(buttonDetail);
            // handle event click button detail
            DataGridViewReserveList.CellContentClick += ButtonDetail_Click;
        }
        /// <summary>
        /// 予約詳細画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dgvReservetList = (DataGridView)sender;
            if (dgvReservetList.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex >= 0)
            {
                
            }
        }
        /// <summary>
        /// 前のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (reservationPagedList.HasPreviousPage)
            {
                PagingReservationtList(--pageNumber);
            }
        }
        /// <summary>
        /// 次のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (reservationPagedList.HasNextPage)
            {
                PagingReservationtList(--pageNumber);
            }
        }
        /// <summary>
        /// 予約登録画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            ReserveRegisterForm reserveRegisterForm = new ReserveRegisterForm();
            reserveRegisterForm.PatientId = this.PatientId;
            reserveRegisterForm.Show();
        }
    }
}
