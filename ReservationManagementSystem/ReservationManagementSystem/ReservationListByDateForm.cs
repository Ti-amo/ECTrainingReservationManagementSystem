using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;

namespace ReservationManagementSystem {
    public partial class ReservationListByDateForm : Form {
        private readonly Utility utility = new Utility();
        private List<ReservationEntity> reservations = new List<ReservationEntity>();　// 患者一覧
        private int pageNumber = 1;                                     　 // ページ番号
        private int pageSize = 8;
        private IPagedList<ReservationEntity> reservationList;                     // ページ一覧
        private ReservationDAO reservationDAO = new ReservationDAO();
        ResourceManager rm = new ResourceManager(typeof(ReservationListByDateForm));

        public ReservationListByDateForm() {
            InitializeComponent();
        }

        private void ReservationListByDateForm_Load(object sender, EventArgs e) {
            reservations = reservationDAO.FindByDate(DateTime.Now.ToString("yyyy-MM-dd"));
            SetupControls();
        }

        public void ReloadForm() {
            this.Controls.Clear();
            InitializeComponent();

            reservations = reservationDAO.FindByDate(DateTime.Now.ToString("yyyy-MM-dd"));
            SetupControls();
        }

        /// <summary>
        /// ページ付けを実行する
        /// </summary>
        /// <param name="patients"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        private void PagingReservationList(List<ReservationEntity> reservations, int pageNumber = 1) {
            reservationList = reservations.ToPagedList(pageNumber, pageSize);
            ButtonPrevious.Enabled = reservationList.HasPreviousPage;
            ButtonNext.Enabled = reservationList.HasNextPage;
            TextboxPageNumber.Text = pageNumber + "";
            TextboxPageNumber.SelectionStart = TextboxPageNumber.TextLength;
            LabelTotalPages.Text = string.Format("/{0}", reservationList.PageCount);
            // fill data to datagridview
            DataGridViewReservationList.DataSource = reservationList.ToList();
            DataGridViewReservationList.Columns["ReservationDate"].DisplayIndex = 0;
            DataGridViewReservationList.Columns["ReservationId"].DisplayIndex = 1;
            DataGridViewReservationList.Columns["PatientName"].DisplayIndex = 2;
            DataGridViewReservationList.Columns["StatusName"].DisplayIndex = 3;
            utility.SetColorByStatus(DataGridViewReservationList.Columns["StatusId"].Index, DataGridViewReservationList);
            DataGridViewReservationList.ClearSelection();
        }

        /// <summary>
        /// コントロールの設定
        /// </summary>
        private void SetupControls() {
            PagingReservationList(reservations);
            // set up headertext of dgv
            DataGridViewReservationList.Columns["ReservationId"].HeaderText = rm.GetString("ReservationId");
            DataGridViewReservationList.Columns["PatientName"].HeaderText = rm.GetString("PatientName");
            DataGridViewReservationList.Columns["ReservationDate"].HeaderText = rm.GetString("ReservationDate");
            DataGridViewReservationList.Columns["StatusName"].HeaderText = rm.GetString("Status");

            DataGridViewReservationList.Columns["PatientId"].Visible = false;
            DataGridViewReservationList.Columns["StatusId"].Visible = false;
            
            // add button detail
            DataGridViewButtonColumn buttonDetail = new DataGridViewButtonColumn {
                Text = rm.GetString("Detail"),
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            DataGridViewReservationList.Columns.Add(buttonDetail);
            // handle event click button detail
            DataGridViewReservationList.CellContentClick += ButtonDetail_Click;
        }

        /// <summary>
        /// 予約はありません
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewReservationList_Paint(object sender, PaintEventArgs e) {
            DataGridView dgvReservationList = (DataGridView)sender;
            string emptyResultText = rm.GetString("EmptyReservationMsg");
            if (dgvReservationList.Rows.Count == 0) {
                using (Graphics grfx = e.Graphics) {
                    grfx.DrawString(emptyResultText, dgvReservationList.Font, Brushes.Black, new PointF((dgvReservationList.Width - dgvReservationList.Font.Size * emptyResultText.Length) / 2, dgvReservationList.Height / 2));
                }
            }
        }

        /// <summary>
        /// 患者の詳細な情報画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDetail_Click(object sender, DataGridViewCellEventArgs e) {
            var dgvReservationList = (DataGridView)sender;
            if (dgvReservationList.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex >= 0) {
                int reservationId = (int)dgvReservationList.Rows[e.RowIndex].Cells["ReservationId"].Value;
                ReservationDetailForm reservationDetailInfoForm = new ReservationDetailForm(this, reservationId);
                reservationDetailInfoForm.Show();
            }
        }

        /// <summary>
        /// 前のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrevious_Click(object sender, EventArgs e) {
            if (reservationList.HasPreviousPage) {
                if (!string.IsNullOrWhiteSpace(TextboxPageNumber.Text) && int.TryParse(TextboxPageNumber.Text, out int enteredPageNumber))
                {
                    if (enteredPageNumber == 1)
                    {
                        pageNumber = enteredPageNumber + 1;
                    }
                    else if (enteredPageNumber > 1 && enteredPageNumber <= reservationList.PageCount)
                    {
                        pageNumber = enteredPageNumber;
                    }
                }
                PagingReservationList(reservations, --pageNumber);
            }
        }

        /// <summary>
        /// 次のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e) {
            if (reservationList.HasNextPage)
            {
                if (!string.IsNullOrWhiteSpace(TextboxPageNumber.Text) && int.TryParse(TextboxPageNumber.Text, out int enteredPageNumber))
                {
                    if (enteredPageNumber == reservationList.PageCount)
                    {
                        pageNumber = enteredPageNumber - 1;
                    }
                    else if (enteredPageNumber > 0 && enteredPageNumber < reservationList.PageCount)
                    {
                        pageNumber = enteredPageNumber;
                    }
                }
                PagingReservationList(reservations, ++pageNumber);
            }
        }
        /// <summary>
        /// Set data when date changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePickerReservationDate_ValueChanged(object sender, EventArgs e) {
            string date = DateTimePickerReservationDate.Value.ToString("yyyy-MM-dd");
            reservations = reservationDAO.FindByDate(date);
            pageNumber = 1;
            PagingReservationList(reservations);
        }
        /// <summary>
        /// handle event press enter page number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextboxPageNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(TextboxPageNumber.Text)
                    && int.TryParse(TextboxPageNumber.Text, out int enteredPageNumber)
                    && enteredPageNumber > 0 && enteredPageNumber <= reservationList.PageCount)
                {
                    pageNumber = enteredPageNumber;
                    PagingReservationList(reservations, pageNumber);
                }
                else
                {
                    TextboxPageNumber.Text = pageNumber + "";
                    TextboxPageNumber.SelectionStart = TextboxPageNumber.TextLength;
                }
            }
        }
    }
}
