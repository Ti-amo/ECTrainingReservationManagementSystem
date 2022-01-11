using PagedList;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace ReservationManagementSystem {
    public partial class PatientDetailInfoForm : Form {
        public string PatientId { get; set; }                                          // 患者ID
        private PatientEntity patient = new PatientEntity();                           // 患者
        private int pageNumber = 1;                                                    // ページ番号
        private IPagedList<ReservationEntity> reservationPagedList;                    // ページ一覧     
        private List<ReservationEntity> reservations = new List<ReservationEntity>();　// 予約一覧
        private PatientDAO patientDAO = new PatientDAO();
        private bool editNameStatus = false;
        private bool editDoBStatus = false;
        private ResourceManager rm = new ResourceManager(typeof(PatientDetailInfoForm));

        public PatientDetailInfoForm() {
            InitializeComponent();
        }

        private void PatientDetailInfoForm_Load(object sender, EventArgs e) {
            LoadForm();
        }

        private void LoadForm() {
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

            PagingReservationtList(reservations);

            SetupControls();
        }

        public void ReloadForm() {
            this.Controls.Clear();
            InitializeComponent();

            LoadForm();
        }

        /// <summary>
        /// テキストボックスにデータを入力する
        /// </summary>
        private void FillData() {
            LabelId.Text = patient.PatientId;
            LabelName.Text = patient.Name;
            LabelDoB.Text = patient.BirthDate;
        }

        /// <summary>
        /// ページ付けを実行する
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        private void PagingReservationtList(List<ReservationEntity> reservations, int pageNumber = 1, int pageSize = 2) {
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
        private void SetupControls() {
            // set up headertext of columns in dgv
            DataGridViewReserveList.Columns["ReservationId"].HeaderText = rm.GetString("ReservationId");
            DataGridViewReserveList.Columns["ReservationDate"].HeaderText = rm.GetString("ReservationDate");
            DataGridViewReserveList.Columns["StatusName"].HeaderText = rm.GetString("Status");

            DataGridViewReserveList.Columns["PatientId"].Visible = false;
            DataGridViewReserveList.Columns["PatientName"].Visible = false;
            DataGridViewReserveList.Columns["StatusId"].Visible = false;
            DataGridViewReserveList.Columns["Exam"].Visible = false;

            // add button detail to dgv
            DataGridViewButtonColumn buttonDetail = new DataGridViewButtonColumn {
                Text = rm.GetString("Detail"),
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            DataGridViewReserveList.Columns.Add(buttonDetail);

            // handle event click button detail
            DataGridViewReserveList.CellContentClick += ButtonDetail_Click;

            // show button reserve according to reservation's status
            ButtonReserve.Enabled = !HasReservation();
        }

        private bool HasReservation() {
            if ((reservations.Find(r => (r.StatusId == 1)) != null) || (reservations.Find(r => (r.StatusId == 2)) != null)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 予約詳細画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDetail_Click(object sender, DataGridViewCellEventArgs e) {
            var dgvReservetList = (DataGridView)sender;
            if (dgvReservetList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                int reservationId = (int)dgvReservetList.Rows[e.RowIndex].Cells["ReservationId"].Value;
                ReservationDetailForm reservationDetailForm = new ReservationDetailForm(this, reservationId);
                reservationDetailForm.ShowDialog();
            }
        }

        /// <summary>
        /// 前のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrevious_Click(object sender, EventArgs e) {
            if (reservationPagedList.HasPreviousPage) {
                PagingReservationtList(reservations, --pageNumber);
            }
        }

        /// <summary>
        /// 次のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e) {
            if (reservationPagedList.HasNextPage) {
                PagingReservationtList(reservations, ++pageNumber);
            }
        }

        /// <summary>
        /// 予約登録画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReserve_Click(object sender, EventArgs e) {
            ReservationRegisterForm reserveRegisterForm = new ReservationRegisterForm {
                PatientId = this.PatientId
            };
            this.Hide();
            reserveRegisterForm.FormClosed += (s, args) => this.Close();
            reserveRegisterForm.ShowDialog();
        }

        private void ButtonEditName_Click(object sender, EventArgs e) {
            if (!editNameStatus) {
                editNameStatus = !editNameStatus;
                ButtonEditName.BackgroundImage = Properties.Resources.done;
                ButtonCancelEditName.Visible = true;

                LabelName.Visible = false;
                TextBoxName.Visible = true;
                TextBoxName.Text = patient.Name;
            } else {
                string newName = TextBoxName.Text;
                if (!string.IsNullOrWhiteSpace(newName) && (newName.Length <= 48)) {
                    editNameStatus = !editNameStatus;

                    ButtonEditName.BackgroundImage = Properties.Resources.edit;
                    ButtonCancelEditName.Visible = false;

                    TextBoxName.Visible = false;
                    LabelName.Visible = true;
                    LabelName.Text = newName;

                    if (!newName.Equals(patient.Name)) {
                        patient.Name = newName;
                        patientDAO.Update(patient);
                        MessageBox.Show(rm.GetString("EditNameSuccessMsg"), rm.GetString("EditSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    DialogResult dialogResult = MessageBox.Show(rm.GetString("EditNameFailureMsg"), rm.GetString("EditFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.OK) {
                        TextBoxName.Focus();
                    }
                }
            }
        }

        private void ButtonCancelEditName_Click(object sender, EventArgs e) {
            editNameStatus = !editNameStatus;
            ButtonEditName.BackgroundImage = Properties.Resources.edit;
            ButtonCancelEditName.Visible = false;

            TextBoxName.Visible = false;
            LabelName.Visible = true;
        }

        private void ButtonEditDoB_Click(object sender, EventArgs e) {
            if (!editDoBStatus) {
                editDoBStatus = !editDoBStatus;
                ButtonEditDoB.BackgroundImage = Properties.Resources.done;
                ButtonCancelEditDoB.Visible = true;

                LabelDoB.Visible = false;
                DateTimePickerDoB.Visible = true;
                DateTimePickerDoB.Text = patient.BirthDate;
            } else {
                if (IsValidDateOfBirth()) {
                    string newDoB = DateTimePickerDoB.Value.ToString("yyyy-MM-dd");
                    editDoBStatus = !editDoBStatus;

                    ButtonEditDoB.BackgroundImage = Properties.Resources.edit;
                    ButtonCancelEditDoB.Visible = false;

                    DateTimePickerDoB.Visible = false;
                    LabelDoB.Visible = true;
                    LabelDoB.Text = newDoB;

                    if (!newDoB.Equals(patient.BirthDate)) {
                        patient.BirthDate = newDoB;
                        patientDAO.Update(patient);
                        MessageBox.Show(rm.GetString("EditBirthDateSuccessMsg"), rm.GetString("EditSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show(rm.GetString("EditBirthDateFailureMsg"), rm.GetString("EditFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCancelEditDoB_Click(object sender, EventArgs e) {
            editDoBStatus = !editDoBStatus;

            ButtonEditDoB.BackgroundImage = Properties.Resources.edit;
            ButtonCancelEditDoB.Visible = false;

            DateTimePickerDoB.Visible = false;
            LabelDoB.Visible = true;
        }

        /// <summary>
        /// 患者生年月日をチェックする
        /// </summary>
        /// <returns></returns>
        private bool IsValidDateOfBirth() {
            DateTime patientDoB = DateTime.Parse(DateTimePickerDoB.Text).Date;
            DateTime localDate = DateTime.Now.Date;
            if (patientDoB <= localDate) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewReserveList_Paint(object sender, PaintEventArgs e) {
            DataGridView dgvReserveList = (DataGridView)sender;
            string emptyResultText = rm.GetString("EmptyReservationMsg");
            if (dgvReserveList.Rows.Count == 0) {
                using (Graphics grfx = e.Graphics) {
                    grfx.DrawString(emptyResultText, dgvReserveList.Font, Brushes.Black, new PointF((dgvReserveList.Width - dgvReserveList.Font.Size * emptyResultText.Length) / 2, dgvReserveList.Height / 2));
                }
            }
        }
    }
}
