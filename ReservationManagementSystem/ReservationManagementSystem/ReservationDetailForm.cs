using iTextSharp.text;
using iTextSharp.text.pdf;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace ReservationManagementSystem {
    public partial class ReservationDetailForm : Form {
        private ReservationEntity reservationEntity;
        private ReservationDAO reservationDAO;
        private ExamDAO examDAO;
        ResourceManager rm = new ResourceManager(typeof(ReservationDetailForm));

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
            SaveFileDialog sfd = new SaveFileDialog {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "【" + rm.GetString("ReservationTicket") + "・" + reservationEntity.ReservationId + "】" + reservationEntity.PatientName + "・" + reservationEntity.ReservationDate + ".pdf"
            };
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK) {
                if (File.Exists(sfd.FileName)) {
                    try {
                        File.Delete(sfd.FileName);
                    } catch (IOException) {
                        fileError = true;
                        MessageBox.Show(rm.GetString("FileExistsMsg"), rm.GetString("ExportFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!fileError) {
                    try {
                        string fontPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\MS Gothic.ttf";
                        BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                        Font fontTitle = new Font(baseFont, 25, iTextSharp.text.Font.NORMAL);
                        Paragraph pdfTitle = new Paragraph(rm.GetString("ReservationTicket"), fontTitle) {
                            Alignment = Element.ALIGN_CENTER,
                            SpacingAfter = 25
                        };

                        PdfPTable pdfTable = new PdfPTable(2);
                        pdfTable.DefaultCell.Padding = 5;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        Font fontTable = new Font(baseFont, 16, iTextSharp.text.Font.NORMAL);

                        pdfTable.AddCell(new Phrase(rm.GetString("ReservationId"), fontTable));
                        pdfTable.AddCell(new Phrase(reservationEntity.ReservationId.ToString(), fontTable));

                        pdfTable.AddCell(new Phrase(rm.GetString("PatientId"), fontTable));
                        pdfTable.AddCell(new Phrase(reservationEntity.PatientId, fontTable));

                        pdfTable.AddCell(new Phrase(rm.GetString("PatientName"), fontTable));
                        pdfTable.AddCell(new Phrase(reservationEntity.PatientName, fontTable));

                        pdfTable.AddCell(new Phrase(rm.GetString("ReservationDate"), fontTable));
                        pdfTable.AddCell(new Phrase(reservationEntity.ReservationDate, fontTable));

                        pdfTable.AddCell(new Phrase(rm.GetString("MajorExam"), fontTable));
                        pdfTable.AddCell(new Phrase(reservationEntity.Exam.MajorExamName, fontTable));

                        pdfTable.AddCell(new Phrase(rm.GetString("SubExam"), fontTable));
                        pdfTable.AddCell(new Phrase(reservationEntity.Exam.SubExamName, fontTable));

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create)) {
                            Document pdfDoc = new Document(PageSize.A6.Rotate(), 20f, 20f, 20f, 20f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTitle);
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show(rm.GetString("ExportSuccessMsg"), rm.GetString("ExportSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception) {
                        MessageBox.Show(rm.GetString("ExportFailureMsg"), rm.GetString("ExportFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ButtonCompleteReception_Click(object sender, EventArgs e) {
            reservationEntity.StatusId = 2;
            reservationEntity.StatusName = "受付完了";
            reservationDAO.ChangeStatus(reservationEntity);

            LabelStatus.Text = reservationEntity.StatusName;
            ButtonUpdate.Enabled = false;
            ButtonCompleteReception.Enabled = false;
            ButtonCompleteTreatment.Enabled = true;

            MessageBox.Show(rm.GetString("ReceptionMsg"), rm.GetString("ReceptionTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCompleteTreatment_Click(object sender, EventArgs e) {
            reservationEntity.StatusId = 3;
            reservationEntity.StatusName = "診療完了";
            reservationDAO.ChangeStatus(reservationEntity);

            LabelStatus.Text = reservationEntity.StatusName;
            ButtonCompleteTreatment.Enabled = false;

            MessageBox.Show(rm.GetString("TreatmentMsg"), rm.GetString("TreatmentTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(rm.GetString("DeleteConfirmMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                reservationDAO.Delete(reservationEntity);
                MessageBox.Show(rm.GetString("DeleteSuccessMsg"), rm.GetString("DeleteTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ButtonCompleteUpdate_Click(object sender, EventArgs e) {
            if (DateTimePickerReservationDate.Text.Equals(reservationEntity.ReservationDate) || DateTimePickerReservationDate.Value >= DateTime.Today) {
                reservationEntity.ReservationDate = DateTimePickerReservationDate.Text;
                reservationEntity.Exam.MajorExamId = int.Parse(ComboBoxMajorExam.SelectedValue.ToString());
                reservationEntity.Exam.MajorExamName = ComboBoxMajorExam.Text;
                reservationEntity.Exam.SubExamId = int.Parse(ComboBoxSubExam.SelectedValue.ToString());
                reservationEntity.Exam.SubExamName = ComboBoxSubExam.Text;

                reservationDAO.Update(reservationEntity);
                MessageBox.Show(rm.GetString("EditSuccessMsg"), rm.GetString("EditSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                CompleteUpdate();
            } else {
                MessageBox.Show(rm.GetString("ReservationDateFailureMsg"), rm.GetString("EditFailureTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
