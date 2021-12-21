using PagedList;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class PatientListForm : Form
    {
        private List<PatientEntity> patients = new List<PatientEntity>();　   // DBから取り出した患者一覧
        private List<PatientEntity> patientList = new List<PatientEntity>();　// ページネーションの患者リスト
        private int pageNumber = 1;                                     　    // ページ番号
        private IPagedList<PatientEntity> patientPagedList;                   // ページ一覧
        private PatientDAO patientDAO = new PatientDAO();                     // 患者DAOインストール
        private Button buttonClear = new Button();                            // ボタンクリア
        public PatientListForm()
        {
            InitializeComponent();
        }

        private void PatientListForm_Load(object sender, EventArgs e)
        {
            patients = patientDAO.FindAll();
            patientList = patients;
            SetupControls();
        }
        /// <summary>
        /// ページ付けを実行する
        /// </summary>
        /// <param name="patients"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        private void PagingPatientList(List<PatientEntity> patients, int pageNumber = 1, int pageSize = 10)
        {
            patientPagedList = patients.ToPagedList(pageNumber, pageSize);
            ButtonPrevious.Enabled = patientPagedList.HasPreviousPage;
            ButtonNext.Enabled = patientPagedList.HasNextPage;
            LabelPageNumber.Text = string.Format("{0}/{1}", pageNumber, patientPagedList.PageCount);
            // fill data to datagridview
            DataGridViewPatientList.DataSource = patientPagedList.ToList();
        }
        /// <summary>
        /// コントロールの設定
        /// </summary>
        private void SetupControls()
        {
            PagingPatientList(patientList);
            // set up headertext of dgv
            DataGridViewPatientList.Columns["PatientId"].HeaderText = "患者ID";
            DataGridViewPatientList.Columns["Name"].HeaderText = "氏名";
            DataGridViewPatientList.Columns["BirthDate"].HeaderText = "生年月日";
            // add button detail
            DataGridViewButtonColumn buttonDetail = new DataGridViewButtonColumn();
            buttonDetail.Text = "詳細";
            buttonDetail.UseColumnTextForButtonValue = true;
            buttonDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            buttonDetail.Width = 100;
            DataGridViewPatientList.Columns.Add(buttonDetail);
            // handle event click button detail
            DataGridViewPatientList.CellContentClick += ButtonDetail_Click;
            // add button clear to textbox search
            buttonClear.Size = new System.Drawing.Size(10, 10);
            buttonClear.Location = new System.Drawing.Point(TextboxSearch.ClientSize.Width - buttonClear.Width - 5, (TextboxSearch.ClientSize.Height - buttonClear.Height)/2);
            buttonClear.Cursor = Cursors.Default;
            buttonClear.BackgroundImage = Properties.Resources.close;
            buttonClear.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.FlatAppearance.BorderSize = 0;
            TextboxSearch.Controls.Add(buttonClear);
            SendMessage(TextboxSearch.Handle, 0xd3, (IntPtr)2, (IntPtr)(buttonClear.Width << 16));
            buttonClear.Visible = false;
            // handle event text changed in textbox search
            TextboxSearch.TextChanged += TextboxSearch_TextChanged;
            // handle event click button clear
            buttonClear.Click += ButtonClear_Click;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        /// <summary>
        /// ボタンクリアのVisibleプロパティを設定する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextboxSearch.Text))
            {
                buttonClear.Visible = true;
            }
            else
            {
                buttonClear.Visible = false;
            }
        }
        /// <summary>
        /// テキストボックスのキーワードをクリアする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextboxSearch.Text = "";
            pageNumber = 1;
            patientList = patients;
            PagingPatientList(patientList);
        }
        /// <summary>
        /// 患者の詳細な情報画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dgvPatientList = (DataGridView)sender;
            if (dgvPatientList.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex >= 0)
            {
                string patientId = (string)dgvPatientList.Rows[e.RowIndex].Cells["PatientId"].Value;
                PatientDetailInfoForm patientDetailInfoForm = new PatientDetailInfoForm();
                patientDetailInfoForm.PatientId = patientId;
                patientDetailInfoForm.Show();
            }
        }
        /// <summary>
        /// 前のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (patientPagedList.HasPreviousPage)
            {
                PagingPatientList(patientList, --pageNumber);
            }
        }
        /// <summary>
        /// 次のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (patientPagedList.HasNextPage)
            {
                PagingPatientList(patientList, ++pageNumber);
            }
        }
        /// <summary>
        /// キーワードで患者を調べる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var keyword = TextboxSearch.Text;
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                patientList = patientDAO.FindByIdOrName(keyword);
                pageNumber = 1;
                PagingPatientList(patientList);
            }
        }
    }
}
