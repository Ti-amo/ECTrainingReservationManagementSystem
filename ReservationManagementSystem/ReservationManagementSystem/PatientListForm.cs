using PagedList;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
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
        private bool flag = false;                                            // ユーザーが検索したかどうかを確認する
        ResourceManager rm = new ResourceManager(typeof(PatientListForm));

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
        private void PagingPatientList(List<PatientEntity> patients, int pageNumber = 1, int pageSize = 8)
        {
            patientPagedList = patients.ToPagedList(pageNumber, pageSize);
            ButtonPrevious.Enabled = patientPagedList.HasPreviousPage;
            ButtonNext.Enabled = patientPagedList.HasNextPage;
            TextboxPageNumber.Text = pageNumber + "";
            TextboxPageNumber.SelectionStart = TextboxPageNumber.TextLength;
            LabelTotalPages.Text = string.Format("/{0}", patientPagedList.PageCount);
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
            DataGridViewPatientList.Columns["PatientId"].HeaderText = rm.GetString("PatientId");
            DataGridViewPatientList.Columns["Name"].HeaderText = rm.GetString("Name");
            DataGridViewPatientList.Columns["BirthDate"].HeaderText = rm.GetString("BirthDate");
            // add button detail
            DataGridViewButtonColumn buttonDetail = new DataGridViewButtonColumn
            {
                Text = rm.GetString("Detail"),
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            DataGridViewPatientList.Columns.Add(buttonDetail);
            // handle event click button detail
            DataGridViewPatientList.CellContentClick += ButtonDetail_Click;
            // add button clear to textbox search
            buttonClear.Size = new System.Drawing.Size(10, 10);
            buttonClear.Location = new System.Drawing.Point(TextboxSearch.ClientSize.Width - buttonClear.Width - 5, (TextboxSearch.ClientSize.Height - buttonClear.Height) / 2);
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

            this.KeyPreview = true;
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
                if (flag)
                {
                    patientList = patients;
                    pageNumber = 1;
                    flag = false;
                    PagingPatientList(patientList);
                }
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
                PatientDetailInfoForm patientDetailInfoForm = new PatientDetailInfoForm
                {
                    PatientId = patientId
                };
                this.Hide();
                patientDetailInfoForm.FormClosed += (s, args) => this.Close();
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
                if (!string.IsNullOrWhiteSpace(TextboxPageNumber.Text) && int.TryParse(TextboxPageNumber.Text, out int enteredPageNumber))
                {
                    if (enteredPageNumber == 1)
                    {
                        pageNumber = enteredPageNumber + 1;
                    }
                    else if (enteredPageNumber > 1 && enteredPageNumber <= patientPagedList.PageCount)
                    {
                        pageNumber = enteredPageNumber;
                    }
                }
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
                if (!string.IsNullOrWhiteSpace(TextboxPageNumber.Text) && int.TryParse(TextboxPageNumber.Text, out int enteredPageNumber))
                {
                    if (enteredPageNumber == patientPagedList.PageCount)
                    {
                        pageNumber = enteredPageNumber - 1;
                    }
                    else if (enteredPageNumber > 0 && enteredPageNumber < patientPagedList.PageCount)
                    {
                        pageNumber = enteredPageNumber;
                    }
                }
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
                flag = true;
                pageNumber = 1;
                PagingPatientList(patientList);
            }
        }

        /// <summary>
        /// 患者を見つけない場合、メッセージを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewPatientList_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dgvPatientList = (DataGridView)sender;
            string emptyResultText = rm.GetString("EmptyPatientMsg");
            if (dgvPatientList.Rows.Count == 0)
            {
                using (Graphics grfx = e.Graphics)
                {
                    grfx.DrawString(emptyResultText, dgvPatientList.Font, Brushes.Black, new PointF((dgvPatientList.Width - dgvPatientList.Font.Size * emptyResultText.Length) / 2, dgvPatientList.Height / 2));
                }
            }
        }

        /// <summary>
        /// handle event press enter and esc key from keyboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var keyword = TextboxSearch.Text;
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    patientList = patientDAO.FindByIdOrName(keyword);
                    pageNumber = 1;
                    flag = true;
                    PagingPatientList(patientList);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                TextboxSearch.Text = "";
                pageNumber = 1;
                patientList = patients;
                PagingPatientList(patientList);
            }
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
                    && enteredPageNumber > 0 && enteredPageNumber <= patientPagedList.PageCount)
                {
                    pageNumber = enteredPageNumber;
                    PagingPatientList(patientList, pageNumber);
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
