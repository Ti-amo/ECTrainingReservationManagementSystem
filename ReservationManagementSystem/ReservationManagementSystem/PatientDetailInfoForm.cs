using System;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class PatientDetailInfoForm : Form
    {
        public string PatientId { get; set; }
        public PatientDetailInfoForm()
        {
            InitializeComponent();
        }

        private void PatientDetailInfoForm_Load(object sender, EventArgs e)
        {
            label1.Text = PatientId;
        }

      
    }
}
