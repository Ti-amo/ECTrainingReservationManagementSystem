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

        public ReservationDetailForm() {
            InitializeComponent();

            ReservationDAO reservationDAO = new ReservationDAO();
            reservationEntity = reservationDAO.FindByPatient("EC000001")[0];

            LabelReservationID.Text = reservationEntity.ReservationId.ToString();
            LabelPatient.Text = reservationEntity.PatientName;
            LabelReservationDate.Text = reservationEntity.ReservationDate;
            LabelStatus.Text = reservationEntity.StatusName;
            LabelMajorExam.Text = reservationEntity.Exam.MajorExamName;
            LabelSubExam.Text = reservationEntity.Exam.SubExamName;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e) {
            LabelReservationDate.Visible = false;
            DateTimePickerReservationDate.Visible = true;
            DateTimePickerReservationDate.Text = LabelReservationDate.Text;
        }
    }
}
