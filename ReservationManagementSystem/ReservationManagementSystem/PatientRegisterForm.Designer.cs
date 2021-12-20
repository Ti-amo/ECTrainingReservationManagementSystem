namespace ReservationManagementSystem
{
    partial class PatientRegisterForm
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.DatetimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxMajorExam = new System.Windows.Forms.ComboBox();
            this.ComboBoxSubExam = new System.Windows.Forms.ComboBox();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(338, 38);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(151, 33);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "患者登録";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "患者名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "生年月日：";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 444);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "予約日付：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "診療項目：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "小項目：";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(208, 114);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(200, 27);
            this.TextBoxName.TabIndex = 8;
            // 
            // DatetimePickerBirthDate
            // 
            this.DatetimePickerBirthDate.CustomFormat = "yyyy-MM-dd";
            this.DatetimePickerBirthDate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatetimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatetimePickerBirthDate.Location = new System.Drawing.Point(208, 162);
            this.DatetimePickerBirthDate.Name = "DatetimePickerBirthDate";
            this.DatetimePickerBirthDate.Size = new System.Drawing.Size(200, 27);
            this.DatetimePickerBirthDate.TabIndex = 9;
            // 
            // DateTimePickerReservationDate
            // 
            this.DateTimePickerReservationDate.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerReservationDate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Location = new System.Drawing.Point(208, 220);
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            this.DateTimePickerReservationDate.Size = new System.Drawing.Size(200, 27);
            this.DateTimePickerReservationDate.TabIndex = 10;
            // 
            // ComboBoxMajorExam
            // 
            this.ComboBoxMajorExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMajorExam.FormattingEnabled = true;
            this.ComboBoxMajorExam.Location = new System.Drawing.Point(208, 266);
            this.ComboBoxMajorExam.Name = "ComboBoxMajorExam";
            this.ComboBoxMajorExam.Size = new System.Drawing.Size(200, 28);
            this.ComboBoxMajorExam.TabIndex = 11;
            this.ComboBoxMajorExam.SelectedIndexChanged += new System.EventHandler(this.MajorExamChanged);
            // 
            // ComboBoxSubExam
            // 
            this.ComboBoxSubExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubExam.FormattingEnabled = true;
            this.ComboBoxSubExam.ItemHeight = 20;
            this.ComboBoxSubExam.Location = new System.Drawing.Point(208, 315);
            this.ComboBoxSubExam.Name = "ComboBoxSubExam";
            this.ComboBoxSubExam.Size = new System.Drawing.Size(466, 28);
            this.ComboBoxSubExam.TabIndex = 12;
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(713, 359);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(111, 33);
            this.ButtonReserve.TabIndex = 13;
            this.ButtonReserve.Text = "予約";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // PatientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 444);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.ComboBoxSubExam);
            this.Controls.Add(this.ComboBoxMajorExam);
            this.Controls.Add(this.DateTimePickerReservationDate);
            this.Controls.Add(this.DatetimePickerBirthDate);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTitle);
            this.Name = "PatientRegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker DatetimePickerBirthDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerReservationDate;
        private System.Windows.Forms.ComboBox ComboBoxMajorExam;
        private System.Windows.Forms.ComboBox ComboBoxSubExam;
        private System.Windows.Forms.Button ButtonReserve;
    }
}