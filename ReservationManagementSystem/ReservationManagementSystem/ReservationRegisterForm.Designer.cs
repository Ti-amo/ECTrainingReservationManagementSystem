namespace ReservationManagementSystem
{
    partial class ReservationRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationRegisterForm));
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.ComboBoxSubExam = new System.Windows.Forms.ComboBox();
            this.ComboBoxMajorExam = new System.Windows.Forms.ComboBox();
            this.DateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonReserve
            // 
            resources.ApplyResources(this.ButtonReserve, "ButtonReserve");
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // ComboBoxSubExam
            // 
            this.ComboBoxSubExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboBoxSubExam, "ComboBoxSubExam");
            this.ComboBoxSubExam.FormattingEnabled = true;
            this.ComboBoxSubExam.Name = "ComboBoxSubExam";
            // 
            // ComboBoxMajorExam
            // 
            this.ComboBoxMajorExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboBoxMajorExam, "ComboBoxMajorExam");
            this.ComboBoxMajorExam.FormattingEnabled = true;
            this.ComboBoxMajorExam.Name = "ComboBoxMajorExam";
            this.ComboBoxMajorExam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMajorExam_SelectedIndexChanged);
            // 
            // DateTimePickerReservationDate
            // 
            this.DateTimePickerReservationDate.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.DateTimePickerReservationDate, "DateTimePickerReservationDate");
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            this.DateTimePickerReservationDate.ValueChanged += new System.EventHandler(this.DateTimePickerReservationDate_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.Name = "LabelTitle";
            // 
            // ReservationRegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.ComboBoxSubExam);
            this.Controls.Add(this.ComboBoxMajorExam);
            this.Controls.Add(this.DateTimePickerReservationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LabelTitle);
            this.Name = "ReservationRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.ComboBox ComboBoxSubExam;
        private System.Windows.Forms.ComboBox ComboBoxMajorExam;
        private System.Windows.Forms.DateTimePicker DateTimePickerReservationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label LabelTitle;
    }
}