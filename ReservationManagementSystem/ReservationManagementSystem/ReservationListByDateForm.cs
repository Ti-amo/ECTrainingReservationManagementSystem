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
        private List<PatientEntity> patients = new List<PatientEntity>();　// 患者一覧
        private int pageNumber = 1;                                     　 // ページ番号
        private IPagedList<PatientEntity> patientList;                     // ページ一覧
        private PatientDAO patientDAO = new PatientDAO();
        public ReservationListByDateForm()
        {
            InitializeComponent();
        }
        private void ReservationListByDateForm_Load(object sender, EventArgs e)
        {
            patients = patientDAO.FindAll();
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
            patientList = patients.ToPagedList(pageNumber, pageSize);
            ButtonPrevious.Enabled = patientList.HasPreviousPage;
            ButtonNext.Enabled = patientList.HasNextPage;
            LabelPageNumber.Text = string.Format("{0}/{1}", pageNumber, patientList.PageCount);
            // fill data to datagridview
            DataGridViewPatientList.DataSource = patientList.ToList();
        }
        /// <summary>
        /// コントロールの設定
        /// </summary>
        private void SetupControls()
        {
            PagingPatientList(patients);
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
            if (patientList.HasPreviousPage)
            {
                PagingPatientList(patients, --pageNumber);
            }
        }
        /// <summary>
        /// 次のページを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (patientList.HasNextPage)
            {
                PagingPatientList(patients, ++pageNumber);
            }
        }
        /// <summary>
        /// キーワードで患者を調べる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            //var resultPatientList = new List<PatientEntity>();
            //var keyword = TextboxSearch.Text;
            //if (!string.IsNullOrWhiteSpace(keyword))
            //{
            //    resultPatientList = patientDAO.FindByIdOrName(keyword);
            //}
            //pageNumber = 1;
            //PagingPatientList(resultPatientList);
        }
    }
}
