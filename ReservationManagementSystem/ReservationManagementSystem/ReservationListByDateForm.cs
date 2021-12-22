using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;

namespace ReservationManagementSystem
{
    public partial class ReservationListByDateForm : Form
    {
        private List<ReservationEntity> reservations = new List<ReservationEntity>();　// 患者一覧
        private int pageNumber = 1;                                     　 // ページ番号
        private IPagedList<ReservationEntity> reservationList;                     // ページ一覧
        private ReservationDAO reservationDAO = new ReservationDAO();   
        public ReservationListByDateForm()
        {
            InitializeComponent();
        }
        private void ReservationListByDateForm_Load(object sender, EventArgs e)
        {
            reservations = reservationDAO.FindByDate(DateTime.Now.ToString("yyyy-MM-dd"));
            SetupControls();
        }
        /// <summary>
        /// ページ付けを実行する
        /// </summary>
        /// <param name="patients"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        private void PagingReservationList(List<ReservationEntity> reservations, int pageNumber = 1, int pageSize = 10)
        {
            reservationList = reservations.ToPagedList(pageNumber, pageSize);
            ButtonPrevious.Enabled = reservationList.HasPreviousPage;
            ButtonNext.Enabled = reservationList.HasNextPage;
            LabelPageNumber.Text = string.Format("{0}/{1}", pageNumber, reservationList.PageCount);
            // fill data to datagridview
            DataGridViewReservationList.DataSource = reservationList.ToList();
        }
        /// <summary>
        /// コントロールの設定
        /// </summary>
        private void SetupControls()
        {
            PagingReservationList(reservations);
            // set up headertext of dgv
            DataGridViewReservationList.Columns["ReservationId"].HeaderText = "予約ID";
            DataGridViewReservationList.Columns["PatientName"].HeaderText = "患者名";
            DataGridViewReservationList.Columns["ReservationDate"].HeaderText = "予約日付";
            DataGridViewReservationList.Columns["StatusName"].HeaderText = "状態";
            DataGridViewReservationList.Columns["PatientId"].Visible = false;
            DataGridViewReservationList.Columns["StatusId"].Visible = false;
            DataGridViewReservationList.Columns["Exam"].Visible = false;
            // add button detail
            DataGridViewButtonColumn buttonDetail = new DataGridViewButtonColumn();
            buttonDetail.Text = "詳細";
            buttonDetail.UseColumnTextForButtonValue = true;
            buttonDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            buttonDetail.Width = 100;
            DataGridViewReservationList.Columns.Add(buttonDetail);
            // handle event click button detail
            DataGridViewReservationList.CellContentClick += ButtonDetail_Click;
        }
        /// <summary>
        /// 予約はありません
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewReservationList_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dgvReservationList = (DataGridView)sender;
            string emptyResultText = "予約はありませんでした!";
            if (dgvReservationList.Rows.Count == 0)
            {
                using (Graphics grfx = e.Graphics)
                {
                    grfx.DrawString(emptyResultText, dgvReservationList.Font, Brushes.Black, new PointF((dgvReservationList.Width - dgvReservationList.Font.Size * emptyResultText.Length) / 2, dgvReservationList.Height / 2));
                }
            }
        }
        /// <summary>
        /// 患者の詳細な情報画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dgvReservationList = (DataGridView)sender;
            if (dgvReservationList.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex >= 0)
            {
                int reservationId = (int)dgvReservationList.Rows[e.RowIndex].Cells["ReservationId"].Value;
                ReservationDetailForm reservationDetailInfoForm = new ReservationDetailForm(reservationId);
                reservationDetailInfoForm.Show();
            }
        }
        /// <summary>
        /// 前のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (reservationList.HasPreviousPage)
            {
                PagingReservationList(reservations, --pageNumber);
            }
        }
        /// <summary>
        /// 次のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (reservationList.HasNextPage)
            {
                PagingReservationList(reservations, ++pageNumber);
            }
        }
        /// <summary>
        /// キーワードで患者を調べる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var resultReservationList = new List<ReservationEntity>();
            string date = DateTimePickerReservationDate.Value.ToString("yyyy-MM-dd");
            resultReservationList = reservationDAO.FindByDate(date);
            pageNumber = 1;
            PagingReservationList(resultReservationList);
        }
    }
}
