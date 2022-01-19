using iTextSharp.text;
using iTextSharp.text.pdf;
using ReservationManagementSystem.DAO;
using ReservationManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace ReservationManagementSystem {
    public partial class ReservationDetailForm : Form {
        private int reservationId;
        private ReservationEntity reservationEntity;
        private ReservationDAO reservationDAO;
        private ExamDAO examDAO;
        ResourceManager rm = new ResourceManager(typeof(ReservationDetailForm));
        PatientDetailInfoForm patientDetailInfoForm = null;
        ReservationListByDateForm reservationListByDateForm = null;
        private int examCount;
        private const int MaxExam = 3;
        private List<ComboBox> subExamComboBoxList;

        public ReservationDetailForm(int reservationId) {
            InitializeComponent();

            reservationDAO = new ReservationDAO();
            examDAO = new ExamDAO();
            reservationEntity = reservationDAO.FindById(reservationId);
            this.reservationId = reservationId;
            this.examCount = reservationEntity.Exam.Count;

            InitializeControl();
            SetButtonColor();
        }

        public ReservationDetailForm(PatientDetailInfoForm patientDetailInfoForm, int reservationId) : this(reservationId) {
            this.patientDetailInfoForm = patientDetailInfoForm;
        }

        public ReservationDetailForm(ReservationListByDateForm reservationListByDateForm, int reservationId) : this(reservationId) {
            this.reservationListByDateForm = reservationListByDateForm;
        }

        private void InitializeControl() {
            LabelReservationID.Text = reservationEntity.ReservationId.ToString();
            LabelPatient.Text = reservationEntity.PatientName + " - " + reservationEntity.PatientId;
            LabelReservationDate.Text = reservationEntity.ReservationDate;
            LabelStatus.Text = reservationEntity.StatusName;

            if (reservationEntity.StatusId == 1) {
                LabelStatus.BackColor = ColorTranslator.FromHtml("#95ef5d");
                ButtonUpdate.Enabled = true;
                ButtonCompleteReception.Enabled = true;
            } else if (reservationEntity.StatusId == 2) {
                LabelStatus.BackColor = ColorTranslator.FromHtml("#f1f772");
                ButtonCompleteTreatment.Enabled = true;
            } else {
                LabelStatus.BackColor = ColorTranslator.FromHtml("#d5a6bd");
            }
            ButtonExport.Enabled = true;
            ButtonDelete.Enabled = true;

            CreateTableLayoutPanelView();
        }

        private void CreateTableLayoutPanelView() {
            TableLayoutPanelView.Controls.Clear();

            for (int i = 0; i < reservationEntity.Exam.Count; i++) {
                TableLayoutPanelView.RowCount += 2;

                Label labelMajorTitle = new Label {
                    Text = rm.GetString("MajorExam") + (i + 1) + "：",
                    Size = new Size(120, 15),
                    TextAlign = ContentAlignment.MiddleRight,
                    Margin = new Padding(5, 7, 5, 7)
                };
                TableLayoutPanelView.Controls.Add(labelMajorTitle, 0, 2 * i);

                Label labelMajorExam = new Label {
                    Text = reservationEntity.Exam[i].MajorExamName,
                    Size = new Size(200, 15),
                    Margin = new Padding(5, 7, 5, 7)
                };
                TableLayoutPanelView.Controls.Add(labelMajorExam, 1, 2 * i);

                Label labelSubTitle = new Label {
                    Text = rm.GetString("SubExam") + (i + 1) + "：",
                    Size = new Size(120, 15),
                    TextAlign = ContentAlignment.MiddleRight,
                    Margin = new Padding(5, 7, 5, 7)
                };
                TableLayoutPanelView.Controls.Add(labelSubTitle, 0, 2 * i + 1);

                Label labelSubExam = new Label {
                    Text = reservationEntity.Exam[i].SubExamName,
                    Size = new Size(340, 15),
                    Margin = new Padding(5, 7, 5, 7)
                };
                TableLayoutPanelView.Controls.Add(labelSubExam, 1, 2 * i + 1);
            }
        }

        private void CreateTableLayoutPanelUpdate() {
            TableLayoutPanelUpdate.Controls.Clear();
            subExamComboBoxList = new List<ComboBox>();

            for (int i = 0; i < reservationEntity.Exam.Count; i++) {
                TableLayoutPanelUpdate.RowCount += 2;

                Label labelMajorTitle = new Label {
                    Text = rm.GetString("MajorExam") + (i + 1) + "：",
                    Size = new Size(120, 15),
                    TextAlign = ContentAlignment.MiddleRight,
                    Margin = new Padding(5)
                };
                TableLayoutPanelUpdate.Controls.Add(labelMajorTitle, 0, 2 * i);

                ComboBox comboBoxMajorExam = new ComboBox {
                    Size = new Size(200, 25),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                TableLayoutPanelUpdate.Controls.Add(comboBoxMajorExam, 1, 2 * i);
                List<ExamItem> majorExamList = examDAO.GetMajorExamList();
                List<Object> majorItems = new List<Object>();
                foreach (ExamItem majorExam in majorExamList) {
                    majorItems.Add(new { Value = majorExam.MajorExamId, Text = majorExam.MajorExamName });
                }
                comboBoxMajorExam.ValueMember = "Value";
                comboBoxMajorExam.DisplayMember = "Text";
                comboBoxMajorExam.DataSource = majorItems;
                comboBoxMajorExam.SelectedValue = reservationEntity.Exam[i].MajorExamId;

                Label labelSubTitle = new Label {
                    Text = rm.GetString("SubExam") + (i + 1) + "：",
                    Size = new Size(120, 15),
                    TextAlign = ContentAlignment.MiddleRight,
                    Margin = new Padding(5)
                };
                TableLayoutPanelUpdate.Controls.Add(labelSubTitle, 0, 2 * i + 1);

                ComboBox comboBoxSubExam = new ComboBox {
                    Size = new Size(340, 25),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                TableLayoutPanelUpdate.Controls.Add(comboBoxSubExam, 1, 2 * i + 1);
                List<ExamItem> subExamList = examDAO.GetSubExamList(reservationEntity.Exam[i].MajorExamId);
                List<Object> subItems = new List<Object>();
                int index = 0;
                for (int j = 0; j < subExamList.Count; j++) {
                    subItems.Add(new { Value = subExamList[j].SubExamId, Text = subExamList[j].SubExamName });
                    if (subExamList[j].SubExamId == reservationEntity.Exam[i].SubExamId)
                        index = j;
                }
                comboBoxSubExam.ValueMember = "Value";
                comboBoxSubExam.DisplayMember = "Text";
                comboBoxSubExam.DataSource = subItems;
                comboBoxSubExam.SelectedValue = reservationEntity.Exam[i].SubExamId;
                subExamComboBoxList.Add(comboBoxSubExam);

                comboBoxMajorExam.SelectedIndexChanged += (object sender, EventArgs e) => {
                    subExamList = examDAO.GetSubExamList(int.Parse(comboBoxMajorExam.SelectedValue.ToString()));
                    subItems = new List<Object>();
                    foreach (ExamItem subExam in subExamList) {
                        subItems.Add(new { Value = subExam.SubExamId, Text = subExam.SubExamName });
                    }
                    comboBoxSubExam.ValueMember = "Value";
                    comboBoxSubExam.DisplayMember = "Text";
                    comboBoxSubExam.DataSource = subItems;
                };
            }
        }

        private void SetButtonColor() {
            ButtonCompleteReception.BackColor = ColorTranslator.FromHtml("#f1f772");
            ButtonCompleteTreatment.BackColor = ColorTranslator.FromHtml("#d5a6bd");
            ButtonUpdate.BackColor = ColorTranslator.FromHtml("#0074d9");
            ButtonExport.BackColor = ColorTranslator.FromHtml("#adb5bd");
            ButtonDelete.BackColor = ColorTranslator.FromHtml("#ff4136");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e) {
            BindUpdateData();
            CheckButtonAddRemoveExam();

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
                            SpacingAfter = 30
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

                        string exam = "";
                        for (int i = 0; i < reservationEntity.Exam.Count; i++) {
                            exam += (i + 1) + ". " + reservationEntity.Exam[i].MajorExamName + ": " + reservationEntity.Exam[i].SubExamName + "\n\n";
                        }
                        exam = exam.Remove(exam.Length - 2);
                        pdfTable.AddCell(new Phrase(rm.GetString("Examination"), fontTable));
                        pdfTable.AddCell(new Phrase(exam, fontTable));

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create)) {
                            Document pdfDoc = new Document(PageSize.A5.Rotate(), 50f, 50f, 50f, 50f);
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
            if (DateTime.Today >= Convert.ToDateTime(reservationEntity.ReservationDate)) {
                reservationEntity.StatusId = 2;
                reservationDAO.ChangeStatus(reservationEntity);

                reservationEntity = reservationDAO.FindById(reservationId);
                LabelStatus.Text = reservationEntity.StatusName;
                LabelStatus.BackColor = ColorTranslator.FromHtml("#f1f772");

                ButtonUpdate.Enabled = false;
                ButtonCompleteReception.Enabled = false;
                ButtonCompleteTreatment.Enabled = true;

                MessageBox.Show(rm.GetString("ReceptionSuccessMsg"), rm.GetString("ReceptionTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(rm.GetString("ReceptionFailureMsg"), rm.GetString("ReceptionTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCompleteTreatment_Click(object sender, EventArgs e) {
            reservationEntity.StatusId = 3;
            reservationDAO.ChangeStatus(reservationEntity);

            reservationEntity = reservationDAO.FindById(reservationId);
            LabelStatus.Text = reservationEntity.StatusName;
            LabelStatus.BackColor = ColorTranslator.FromHtml("#d5a6bd");

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

                reservationEntity.Exam = new List<ExamItem>();
                foreach (ComboBox comboBoxSubExam in subExamComboBoxList) {
                    ExamItem examItem = new ExamItem() {
                        SubExamId = int.Parse(comboBoxSubExam.SelectedValue.ToString())
                    };
                    reservationEntity.Exam.Add(examItem);
                }

                reservationDAO.Update(reservationEntity);
                MessageBox.Show(rm.GetString("EditSuccessMsg"), rm.GetString("EditSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                reservationEntity = reservationDAO.FindById(reservationId);

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

            TableLayoutPanelView.Visible = false;
            TableLayoutPanelUpdate.Visible = true;

            CreateTableLayoutPanelUpdate();
        }

        private void CompleteUpdate() {
            ButtonCompleteUpdate.Visible = false;
            ButtonCancelUpdate.Visible = false;

            LabelReservationDate.Visible = true;
            DateTimePickerReservationDate.Visible = false;

            ButtonAddExam.Visible = false;
            ButtonRemoveExam.Visible = false;

            TableLayoutPanelUpdate.Visible = false;
            TableLayoutPanelView.Visible = true;

            this.examCount = reservationEntity.Exam.Count;

            InitializeControl();
        }

        private void ReservationDetailForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (patientDetailInfoForm != null)
                patientDetailInfoForm.ReloadForm();
            if (reservationListByDateForm != null)
                reservationListByDateForm.ReloadForm();
        }

        private void ButtonAddExam_Click(object sender, EventArgs e) {
            TableLayoutPanelUpdate.RowCount += 2;

            Label labelMajorTitle = new Label {
                Text = rm.GetString("MajorExam") + (examCount + 1) + "：",
                Size = new Size(120, 15),
                TextAlign = ContentAlignment.MiddleRight,
                Margin = new Padding(5)
            };
            TableLayoutPanelUpdate.Controls.Add(labelMajorTitle, 0, 2 * examCount);

            ComboBox comboBoxMajorExam = new ComboBox {
                Size = new Size(200, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            TableLayoutPanelUpdate.Controls.Add(comboBoxMajorExam, 1, 2 * examCount);
            List<ExamItem> majorExamList = examDAO.GetMajorExamList();
            List<Object> majorItems = new List<Object>();
            foreach (ExamItem majorExam in majorExamList) {
                majorItems.Add(new { Value = majorExam.MajorExamId, Text = majorExam.MajorExamName });
            }
            comboBoxMajorExam.ValueMember = "Value";
            comboBoxMajorExam.DisplayMember = "Text";
            comboBoxMajorExam.DataSource = majorItems;

            Label labelSubTitle = new Label {
                Text = rm.GetString("SubExam") + (examCount + 1) + "：",
                Size = new Size(120, 15),
                TextAlign = ContentAlignment.MiddleRight,
                Margin = new Padding(5)
            };
            TableLayoutPanelUpdate.Controls.Add(labelSubTitle, 0, 2 * examCount + 1);

            ComboBox comboBoxSubExam = new ComboBox {
                Size = new Size(340, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            TableLayoutPanelUpdate.Controls.Add(comboBoxSubExam, 1, 2 * examCount + 1);
            List<ExamItem> subExamList = examDAO.GetSubExamList(1);
            List<Object> subItems = new List<Object>();
            foreach (ExamItem subExam in subExamList) {
                subItems.Add(new { Value = subExam.SubExamId, Text = subExam.SubExamName });
            }
            comboBoxSubExam.ValueMember = "Value";
            comboBoxSubExam.DisplayMember = "Text";
            comboBoxSubExam.DataSource = subItems;

            comboBoxMajorExam.SelectedIndexChanged += (object o, EventArgs ea) => {
                subExamList = examDAO.GetSubExamList(int.Parse(comboBoxMajorExam.SelectedValue.ToString()));
                subItems = new List<Object>();
                foreach (ExamItem subExam in subExamList) {
                    subItems.Add(new { Value = subExam.SubExamId, Text = subExam.SubExamName });
                }
                comboBoxSubExam.ValueMember = "Value";
                comboBoxSubExam.DisplayMember = "Text";
                comboBoxSubExam.DataSource = subItems;
            };

            subExamComboBoxList.Add(comboBoxSubExam);
            examCount += 1;
            CheckButtonAddRemoveExam();
        }

        private void ButtonRemoveExam_Click(object sender, EventArgs e) {
            examCount -= 1;

            Control control = TableLayoutPanelUpdate.GetControlFromPosition(0, 2 * examCount);
            TableLayoutPanelUpdate.Controls.Remove(control);
            control = TableLayoutPanelUpdate.GetControlFromPosition(0, 2 * examCount + 1);
            TableLayoutPanelUpdate.Controls.Remove(control);
            control = TableLayoutPanelUpdate.GetControlFromPosition(1, 2 * examCount);
            TableLayoutPanelUpdate.Controls.Remove(control);
            control = TableLayoutPanelUpdate.GetControlFromPosition(1, 2 * examCount + 1);
            TableLayoutPanelUpdate.Controls.Remove(control);

            TableLayoutPanelUpdate.RowCount -= 2;

            subExamComboBoxList.RemoveAt(examCount);
            CheckButtonAddRemoveExam();
        }

        private void CheckButtonAddRemoveExam() {
            if (examCount >= MaxExam) {
                ButtonAddExam.Visible = false;
            } else {
                ButtonAddExam.Visible = true;
            }
            if (examCount <= 1) {
                ButtonRemoveExam.Visible = false;
            } else {
                ButtonRemoveExam.Visible = true;
            }
        }
    }
}