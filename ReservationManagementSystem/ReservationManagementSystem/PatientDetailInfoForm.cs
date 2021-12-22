using PagedList;
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
        private PatientDAO patientDAO = new PatientDAO();
        private bool editNameStatus = false;
        private bool editDoBStatus = false;
        public PatientDetailInfoForm()
        {
            InitializeComponent();
        }

        private void PatientDetailInfoForm_Load(object sender, EventArgs e)
        {
            patient = patientDAO.Find(PatientId);

            ReservationDAO reservationDAO = new ReservationDAO();
            reservations = reservationDAO.FindByPatient(PatientId);
            // draw line
            LabelLine.Text = string.Empty;
            LabelLine.BorderStyle = BorderStyle.Fixed3D;
            LabelLine.AutoSize = false;
            LabelLine.Height = 3;
            LabelLine.Width = DataGridViewReserveList.Width;
            // to remove the Focus from textbox id 
            this.ActiveControl = LabelTitleInfo;

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
            // hide textbox cursor
            TextboxId.Enter += (s, e) => { TextboxId.Parent.Focus(); };
            TextboxName.Enter += TextboxName_Enter;
            TextboxDateOfBirth.Enter += TextboxDateOfBirth_Enter;
            // show button reserve according to reservation's status
            ButtonReserve.Enabled = !HasReservation();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool HasReservation()
        {
            if ((reservations.Find(r => (r.StatusName.Equals("予約"))) != null) || (reservations.Find(r => (r.StatusName.Equals("受付完了"))) != null))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextboxName_Enter(object sender, EventArgs e)
        {
            if (!editNameStatus)
            {
                TextboxName.Parent.Focus();
            }
            else
            {
                TextboxName.Focus();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextboxDateOfBirth_Enter(object sender, EventArgs e)
        {
            if (!editDoBStatus)
            {
                TextboxDateOfBirth.Parent.Focus();
            }
            else
            {
                TextboxDateOfBirth.Focus();
            }
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
                int reservationId = (int)dgvReservetList.Rows[e.RowIndex].Cells["ReservationId"].Value;
                ReservationDetailForm reservationDetailForm = new ReservationDetailForm(reservationId);
                reservationDetailForm.Show();
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
            this.Hide();
            reserveRegisterForm.FormClosed += (s, args) => this.Close();
            reserveRegisterForm.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditName_Click(object sender, EventArgs e)
        {
            if (!editNameStatus)
            {
                editNameStatus = !editNameStatus;
                TextboxName.BackColor = System.Drawing.Color.White;
                TextboxName.ReadOnly = false;
                ButtonEditName.BackgroundImage = Properties.Resources.done;
            }
            else
            {
                string newName = TextboxName.Text;
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    editNameStatus = !editNameStatus;
                    patient.Name = newName;
                    patientDAO.Update(patient);
                    TextboxName.BackColor = System.Drawing.Color.WhiteSmoke;
                    TextboxName.ReadOnly = true;
                    ButtonEditName.BackgroundImage = Properties.Resources.edit;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("内容を入力してください！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.OK)
                    {
                        TextboxName.Focus();
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditDoB_Click(object sender, EventArgs e)
        {
            if (!editDoBStatus)
            {
                editDoBStatus = !editDoBStatus;
                TextboxDateOfBirth.BackColor = System.Drawing.Color.White;
                TextboxDateOfBirth.ReadOnly = false;
                ButtonEditDoB.BackgroundImage = Properties.Resources.done;
            }
            else
            {
                string newDoB = TextboxDateOfBirth.Text;
                if (!string.IsNullOrWhiteSpace(newDoB))
                {
                    editDoBStatus = !editDoBStatus;
                    patient.BirthDate = newDoB;
                    patientDAO.Update(patient);
                    TextboxDateOfBirth.BackColor = System.Drawing.Color.WhiteSmoke;
                    TextboxDateOfBirth.ReadOnly = true;
                    ButtonEditDoB.BackgroundImage = Properties.Resources.edit;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("内容を入力してください！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.OK)
                    {
                        TextboxDateOfBirth.Focus();
                    }
                }
            }
        }
    }
}
