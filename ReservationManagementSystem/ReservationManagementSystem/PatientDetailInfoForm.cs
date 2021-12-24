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

        /// <summary>
        /// テキストボックスにデータを入力する
        /// </summary>
        private void FillData() {
            TextboxId.Text = patient.PatientId;
            TextboxName.Text = patient.Name;
            DateTimePickerDoB.Text = patient.BirthDate;
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
            // hide textbox cursor
            TextboxId.Enter += (s, e) => { TextboxId.Parent.Focus(); };
            TextboxName.Enter += TextboxName_Enter;
            // show button reserve according to reservation's status
            ButtonReserve.Enabled = !HasReservation();
            // set border color for dtp
            DateTimePickerDoB.BorderColor = Color.Black;
        }

        private bool HasReservation() {
            if ((reservations.Find(r => (r.StatusName.Equals("予約"))) != null) || (reservations.Find(r => (r.StatusName.Equals("受付完了"))) != null)) {
                return true;
            }
            return false;
        }

        private void TextboxName_Enter(object sender, EventArgs e) {
            if (!editNameStatus) {
                TextboxName.Parent.Focus();
            } else {
                TextboxName.Focus();
            }
        }

        /// <summary>
        /// 予約詳細画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDetail_Click(object sender, DataGridViewCellEventArgs e) {
            var dgvReservetList = (DataGridView)sender;
            if (dgvReservetList.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex >= 0) {
                int reservationId = (int)dgvReservetList.Rows[e.RowIndex].Cells["ReservationId"].Value;
                ReservationDetailForm reservationDetailForm = new ReservationDetailForm(reservationId);
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
                TextboxName.BackColor = System.Drawing.Color.White;
                TextboxName.ReadOnly = false;
                ButtonEditName.BackgroundImage = Properties.Resources.done;
                ButtonCancelEditName.Visible = true;
            } else {
                string newName = TextboxName.Text;
                if (!string.IsNullOrWhiteSpace(newName) && (newName.Length <= 48)) {
                    editNameStatus = !editNameStatus;
                    TextboxName.BackColor = System.Drawing.Color.WhiteSmoke;
                    TextboxName.ReadOnly = true;
                    ButtonEditName.BackgroundImage = Properties.Resources.edit;
                    ButtonCancelEditName.Visible = false;
                    if (!newName.Equals(patient.Name)) {
                        patient.Name = newName;
                        patientDAO.Update(patient);
                        MessageBox.Show(rm.GetString("EditNameSuccessMsg"), rm.GetString("EditSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    DialogResult dialogResult = MessageBox.Show(rm.GetString("EditNameFailureMsg"), rm.GetString("EditFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.OK) {
                        TextboxName.Focus();
                    }
                }
            }
        }

        private void ButtonCancelEditName_Click(object sender, EventArgs e) {
            editNameStatus = !editNameStatus;
            TextboxName.Text = patient.Name;
            TextboxName.BackColor = System.Drawing.Color.WhiteSmoke;
            TextboxName.ReadOnly = true;
            ButtonEditName.BackgroundImage = Properties.Resources.edit;
            ButtonCancelEditName.Visible = false;
        }

        private void ButtonEditDoB_Click(object sender, EventArgs e) {
            if (!editDoBStatus) {
                editDoBStatus = !editDoBStatus;
                DateTimePickerDoB.Enabled = true;
                ButtonEditDoB.BackgroundImage = Properties.Resources.done;
                ButtonCancelEditDoB.Visible = true;
            } else {
                if (IsValidDateOfBirth()) {
                    string newDoB = DateTimePickerDoB.Value.ToString("yyyy-MM-dd");
                    editDoBStatus = !editDoBStatus;
                    DateTimePickerDoB.Enabled = false;
                    ButtonEditDoB.BackgroundImage = Properties.Resources.edit;
                    ButtonCancelEditDoB.Visible = false;
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
            DateTimePickerDoB.Text = patient.BirthDate;
            DateTimePickerDoB.Enabled = false;
            ButtonEditDoB.BackgroundImage = Properties.Resources.edit;
            ButtonCancelEditDoB.Visible = false;
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
            string emptyResultText = "診療予約がありません。";
            if (dgvReserveList.Rows.Count == 0) {
                using (Graphics grfx = e.Graphics) {
                    grfx.DrawString(emptyResultText, dgvReserveList.Font, Brushes.Black, new PointF((dgvReserveList.Width - dgvReserveList.Font.Size * emptyResultText.Length) / 2, dgvReserveList.Height / 2));
                }
            }
        }
    }
}
