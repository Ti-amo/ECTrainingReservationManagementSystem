using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagementSystem {
    public partial class ReservationDetailForm : Form {
        private ReservationEntity reservationEntity;
        private ReservationDAO reservationDAO;
        private ExamDAO examDAO;

        public ReservationDetailForm(int reservationId) {
            InitializeComponent();

            reservationDAO = new ReservationDAO();
            examDAO = new ExamDAO();
            reservationEntity = reservationDAO.FindById(reservationId);

            InitializeControl();
        }

        private void InitializeControl() {
            LabelReservationID.Text = reservationEntity.ReservationId.ToString();
            LabelPatient.Text = reservationEntity.PatientName + " - " + reservationEntity.PatientId;
            LabelReservationDate.Text = reservationEntity.ReservationDate;
            LabelStatus.Text = reservationEntity.StatusName;
            LabelMajorExam.Text = reservationEntity.Exam.MajorExamName;
            LabelSubExam.Text = reservationEntity.Exam.SubExamName;

            if (reservationEntity.StatusName.Equals("予約")) {
                ButtonUpdate.Enabled = true;
                ButtonCompleteReception.Enabled = true;
            } else if (reservationEntity.StatusName.Equals("受付完了")) {
                ButtonCompleteTreatment.Enabled = true;
            }
            ButtonExport.Enabled = true;
            ButtonDelete.Enabled = true;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e) {
            BindUpdateData();
            ButtonUpdate.Enabled = false;
            ButtonExport.Enabled = false;
            ButtonCompleteReception.Enabled = false;
            ButtonCompleteTreatment.Enabled = false;
            ButtonDelete.Enabled = false;

            ButtonCompleteUpdate.Visible = true;
            ButtonCancelUpdate.Visible = true;
        }

        private void ButtonExport_Click(object sender, EventArgs e) {

        }

        private void ButtonCompleteReception_Click(object sender, EventArgs e) {
            reservationEntity.StatusId = 2;
            reservationEntity.StatusName = "受付完了";
            reservationDAO.ChangeStatus(reservationEntity);

            LabelStatus.Text = reservationEntity.StatusName;
            ButtonUpdate.Enabled = false;
            ButtonCompleteReception.Enabled = false;
            ButtonCompleteTreatment.Enabled = true;

            MessageBox.Show("受付を完了しました。", "受付完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCompleteTreatment_Click(object sender, EventArgs e) {
            reservationEntity.StatusId = 3;
            reservationEntity.StatusName = "診療完了";
            reservationDAO.ChangeStatus(reservationEntity);

            LabelStatus.Text = reservationEntity.StatusName;
            ButtonCompleteTreatment.Enabled = false;

            MessageBox.Show("診療を完了しました。", "診療完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("この予約を削除してもよろしいですか？", "予約削除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                reservationDAO.Delete(reservationEntity);
                MessageBox.Show("予約を削除しました。", "予約削除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ButtonCompleteUpdate_Click(object sender, EventArgs e) {
            if (DateTimePickerReservationDate.Value >= DateTime.Today) {
                reservationEntity.ReservationDate = DateTimePickerReservationDate.Text;
                reservationEntity.Exam.MajorExamId = int.Parse(ComboBoxMajorExam.SelectedValue.ToString());
                reservationEntity.Exam.MajorExamName = ComboBoxMajorExam.Text;
                reservationEntity.Exam.SubExamId = int.Parse(ComboBoxSubExam.SelectedValue.ToString());
                reservationEntity.Exam.SubExamName = ComboBoxSubExam.Text;

                reservationDAO.Update(reservationEntity);
                MessageBox.Show("予約を編集しました。", "予約編集", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("本日の後に予約日付を入力してください。", "編集失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CompleteUpdate();
        }

        private void ButtonCancelUpdate_Click(object sender, EventArgs e) {
            CompleteUpdate();
        }

        private void BindUpdateData() {
            LabelReservationDate.Visible = false;
            DateTimePickerReservationDate.Visible = true;
            DateTimePickerReservationDate.Text = reservationEntity.ReservationDate;

            LabelMajorExam.Visible = false;
            ComboBoxMajorExam.Visible = true;
            List<ExamItem> majorExamList = examDAO.GetMajorExamList();
            List<Object> majorItems = new List<Object>();
            foreach (ExamItem majorExam in majorExamList) {
                majorItems.Add(new { Value = majorExam.MajorExamId, Text = majorExam.MajorExamName });
            }
            ComboBoxMajorExam.ValueMember = "Value";
            ComboBoxMajorExam.DisplayMember = "Text";
            ComboBoxMajorExam.DataSource = majorItems;
            ComboBoxMajorExam.SelectedIndex = reservationEntity.Exam.MajorExamId - 1;

            LabelSubExam.Visible = false;
            ComboBoxSubExam.Visible = true;
            List<ExamItem> subExamList = examDAO.GetSubExamList(reservationEntity.Exam.MajorExamId);
            List<Object> subItems = new List<Object>();
            int index = 0;
            for (int i = 0; i < subExamList.Count; i++) {
                subItems.Add(new { Value = subExamList[i].SubExamId, Text = subExamList[i].SubExamName });
                if (subExamList[i].SubExamId == reservationEntity.Exam.SubExamId)
                    index = i;
            }
            ComboBoxSubExam.ValueMember = "Value";
            ComboBoxSubExam.DisplayMember = "Text";
            ComboBoxSubExam.DataSource = subItems;
            ComboBoxSubExam.SelectedIndex = index;
        }

        private void CompleteUpdate() {
            ButtonCompleteUpdate.Visible = false;
            ButtonCancelUpdate.Visible = false;

            LabelReservationDate.Visible = true;
            DateTimePickerReservationDate.Visible = false;

            LabelMajorExam.Visible = true;
            ComboBoxMajorExam.Visible = false;

            LabelSubExam.Visible = true;
            ComboBoxSubExam.Visible = false;

            InitializeControl();
        }

        private void ComboBoxMajorExam_SelectedIndexChanged(object sender, EventArgs e) {
            List<ExamItem> subExamList = examDAO.GetSubExamList(int.Parse(ComboBoxMajorExam.SelectedValue.ToString()));
            List<Object> subItems = new List<Object>();
            foreach (ExamItem subExam in subExamList) {
                subItems.Add(new { Value = subExam.SubExamId, Text = subExam.SubExamName });
            }
            ComboBoxSubExam.ValueMember = "Value";
            ComboBoxSubExam.DisplayMember = "Text";
            ComboBoxSubExam.DataSource = subItems;
        }
    }
}
