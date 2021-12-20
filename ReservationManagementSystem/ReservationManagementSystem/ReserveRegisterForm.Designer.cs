namespace ReservationManagementSystem
{
    partial class ReserveRegisterForm
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
            this.ButtonReserve.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(733, 408);
            this.ButtonReserve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(125, 41);
            this.ButtonReserve.TabIndex = 26;
            this.ButtonReserve.Text = "予約";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // ComboBoxSubExam
            // 
            this.ComboBoxSubExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubExam.FormattingEnabled = true;
            this.ComboBoxSubExam.ItemHeight = 24;
            this.ComboBoxSubExam.Location = new System.Drawing.Point(248, 328);
            this.ComboBoxSubExam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxSubExam.Name = "ComboBoxSubExam";
            this.ComboBoxSubExam.Size = new System.Drawing.Size(524, 32);
            this.ComboBoxSubExam.TabIndex = 25;
            this.ComboBoxSubExam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubExam_SelectedIndexChanged);
            // 
            // ComboBoxMajorExam
            // 
            this.ComboBoxMajorExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMajorExam.FormattingEnabled = true;
            this.ComboBoxMajorExam.Location = new System.Drawing.Point(248, 255);
            this.ComboBoxMajorExam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxMajorExam.Name = "ComboBoxMajorExam";
            this.ComboBoxMajorExam.Size = new System.Drawing.Size(224, 32);
            this.ComboBoxMajorExam.TabIndex = 24;
            this.ComboBoxMajorExam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMajorExam_SelectedIndexChanged);
            // 
            // DateTimePickerReservationDate
            // 
            this.DateTimePickerReservationDate.CustomFormat = "yyyy/MM/dd";
            this.DateTimePickerReservationDate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Location = new System.Drawing.Point(248, 180);
            this.DateTimePickerReservationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            this.DateTimePickerReservationDate.Size = new System.Drawing.Size(224, 31);
            this.DateTimePickerReservationDate.TabIndex = 23;
            this.DateTimePickerReservationDate.ValueChanged += new System.EventHandler(this.DateTimePickerReservationDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "小項目：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "診療項目：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "予約日付：";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 489);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(354, 77);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(177, 40);
            this.LabelTitle.TabIndex = 14;
            this.LabelTitle.Text = "予約登録";
            // 
            // ReserveRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 489);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.ComboBoxSubExam);
            this.Controls.Add(this.ComboBoxMajorExam);
            this.Controls.Add(this.DateTimePickerReservationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LabelTitle);
            this.Name = "ReserveRegisterForm";
            this.Text = "ReserveRegisterForm";
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