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
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;

namespace ReservationManagementSystem {
    public partial class PatientRegisterForm : Form {
        private readonly ExamDAO examDAO = new ExamDAO();
        ResourceManager rm = new ResourceManager(typeof(PatientRegisterForm));
        private List<ExamItem> listExamItem = new List<ExamItem>();
        private int countExam = 1;
        private int maxExam = 3;

        public PatientRegisterForm() {
            InitializeComponent();
            FillDataComboBoxMajorItem();
            buttonRemoveExam.Visible = false;
            tableLayoutPanelExam.Padding = new Padding(0, 5, 0, 5);
        }

        /// <summary>
        /// 診療項目を設定する
        /// </summary>
        private void FillDataComboBoxMajorItem() {
            List<ExamItem> listMajorExam = examDAO.GetMajorExamList();
            List<Object> items = new List<Object>();
            foreach (var item in listMajorExam) {
                items.Add(new { Text = item.MajorExamName, Value = item.MajorExamId });
            }
            ComboBoxMajorExam.DisplayMember = "Text";
            ComboBoxMajorExam.ValueMember = "Value";
            ComboBoxMajorExam.DataSource = items;
        }

        /// <summary>
        /// 診療項目が変わると、小項目を設定する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MajorExamChanged(object sender, EventArgs e) {
            ComboBoxSubExam.DataSource = null;
            List<ExamItem> listSubExam = examDAO.GetSubExamList(int.Parse(ComboBoxMajorExam.SelectedValue.ToString()));
            List<Object> items = new List<Object>();
            foreach (var item in listSubExam) {
                items.Add(new { Text = item.SubExamName, Value = item.SubExamId });
            }
            ComboBoxSubExam.DisplayMember = "Text";
            ComboBoxSubExam.ValueMember = "Value";
            ComboBoxSubExam.DataSource = items;
        }

        /// <summary>
        /// バリデート生年月日
        /// </summary>
        /// <returns></returns>
        private bool ValidateBirthDate() {
            DateTime birthDate = DateTime.Parse(DatetimePickerBirthDate.Text).Date;
            DateTime localDate = DateTime.Now.Date;

            if (birthDate <= localDate) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// バリデート予約日付
        /// </summary>
        /// <returns></returns>
        private bool ValidateReservationDate() {
            DateTime reservationDate = DateTime.Parse(DateTimePickerReservationDate.Text).Date;
            DateTime localDate = DateTime.Now.Date;

            if (reservationDate >= localDate) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 予約する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReserve_Click(object sender, EventArgs e) {
            PatientDAO patientDAO = new PatientDAO();
            ReservationDAO reservationDAO = new ReservationDAO();
            PatientEntity patientEntity = new PatientEntity();
            ReservationEntity reservationEntity = new ReservationEntity();

            patientEntity.Name = TextBoxName.Text;
            patientEntity.BirthDate = DatetimePickerBirthDate.Value.ToString("yyyy-MM-dd");

            if (String.IsNullOrWhiteSpace(TextBoxName.Text) || (TextBoxName.Text.Length > 48)) {
                MessageBox.Show(rm.GetString("NameFailureMsg"), rm.GetString("RegisterFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!ValidateBirthDate()) {
                MessageBox.Show(rm.GetString("BirthDateFailureMsg"), rm.GetString("RegisterFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!ValidateReservationDate()) {
                MessageBox.Show(rm.GetString("ReservationDateFailureMsg"), rm.GetString("RegisterFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                //患者登録
                patientDAO.Insert(patientEntity);

                //予約登録
                reservationEntity.PatientId = patientDAO.FindLatestPatient();
                reservationEntity.ReservationDate = DateTimePickerReservationDate.Value.ToString("yyyy-MM-dd");
                //listExamItem.Add(new ExamItem { SubExamId = int.Parse(ComboBoxSubExam.SelectedValue.ToString()) });
                //if (countExam > 1)
                //{
                //    for (int i = 2; i <= countExam; i++)
                //    {
                //        var comboBox = (ComboBox)tableLayoutPanel1.Controls["ComboBoxSubExamChild" + i.ToString()];
                //        listExamItem.Add(new ExamItem { SubExamId = int.Parse(comboBox.SelectedValue.ToString()) });
                //    }
                //}
                ExamItem examItem = new ExamItem
                {
                    SubExamId = int.Parse(ComboBoxSubExam.SelectedValue.ToString())
                };
                reservationEntity.Exam.Add(examItem);
                reservationDAO.Insert(reservationEntity);
                DialogResult result = MessageBox.Show(rm.GetString("RegisterSuccessMsg"), rm.GetString("RegisterSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    // 予約詳細画面に進む
                    ReservationDetailForm reservationDetailForm = new ReservationDetailForm(reservationDAO.FindLatestReservation());
                    reservationDetailForm.Show();
                }
            }
        }
        /// <summary>
        /// 診療項目を追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddExam_Click(object sender, EventArgs e)
        {
            countExam++;
            //追加ボタンと削除ボタンを表示するかどうかチェックする
            if (countExam > 1)
            {
                buttonRemoveExam.Visible = true;
                if (countExam >= maxExam)
                {
                    buttonAddExam.Visible = false;
                }
            }

            List<Object> items = new List<Object>();
            //診療大項目を作成する
            Label labelMajorExamChild = labelMajorExam.Clone();
            ComboBox ComboBoxMajorExamChild = new ComboBox
            {
                Name = "ComboBoxMajorExamChild" + countExam,
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            List<ExamItem> listMajorExam = examDAO.GetMajorExamList();
            foreach (var item in listMajorExam)
            {
                items.Add(new { Text = item.MajorExamName, Value = item.MajorExamId });
            }
            ComboBoxMajorExamChild.DisplayMember = "Text";
            ComboBoxMajorExamChild.ValueMember = "Value";
            ComboBoxMajorExamChild.DataSource = items;

            //診療小項目を作成する
            Label labelSubExamChild = labelSubExam.Clone();
            ComboBox ComboBoxSubExamChild = new ComboBox
            {
                Name = "ComboBoxSubExamChild" + countExam,
                Width = 350,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            List<ExamItem> listSubExam = examDAO.GetSubExamList(1);
            items = new List<Object>();
            foreach (var item in listSubExam)
            {
                items.Add(new { Text = item.SubExamName, Value = item.SubExamId });
            }
            ComboBoxSubExamChild.DisplayMember = "Text";
            ComboBoxSubExamChild.ValueMember = "Value";
            ComboBoxSubExamChild.DataSource = items;
            ComboBoxMajorExamChild.SelectedIndexChanged += (object sendera, EventArgs ea) =>
            {
                ComboBoxSubExamChild.DataSource = null;
                listSubExam = examDAO.GetSubExamList(int.Parse(ComboBoxMajorExamChild.SelectedValue.ToString()));
                items = new List<Object>();
                foreach (var item in listSubExam)
                {
                    items.Add(new { Text = item.SubExamName, Value = item.SubExamId });
                }
                ComboBoxSubExamChild.DisplayMember = "Text";
                ComboBoxSubExamChild.ValueMember = "Value";
                ComboBoxSubExamChild.DataSource = items;
            };

            //tableLayoutPanelExamに診療を追加する
            tableLayoutPanelExam.RowCount++;
            tableLayoutPanelExam.Controls.Add(labelMajorExamChild, 0, countExam * 2 - 2);
            tableLayoutPanelExam.Controls.Add(ComboBoxMajorExamChild, 1, countExam * 2 - 2);
            tableLayoutPanelExam.RowCount++;
            tableLayoutPanelExam.Controls.Add(labelSubExamChild, 0, countExam * 2 - 1);
            tableLayoutPanelExam.Controls.Add(ComboBoxSubExamChild, 1, countExam * 2 - 1);
        }
        /// <summary>
        /// 診療項目を削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveExam_Click(object sender, EventArgs e)
        {
            
            tableLayoutPanelExam.Controls.Remove(tableLayoutPanelExam.GetControlFromPosition(0, countExam * 2 - 1));
            tableLayoutPanelExam.Controls.Remove(tableLayoutPanelExam.GetControlFromPosition(1, countExam * 2 - 1));
            tableLayoutPanelExam.Controls.Remove(tableLayoutPanelExam.GetControlFromPosition(0, countExam * 2 - 2));
            tableLayoutPanelExam.Controls.Remove(tableLayoutPanelExam.GetControlFromPosition(1, countExam * 2 - 2));
            countExam--;
            if (countExam < 3)
            {
                buttonAddExam.Visible = true;
                if (countExam == 1)
                {
                    buttonRemoveExam.Visible = false;
                }
            }
        }
    }
}
