
namespace ReservationManagementSystem {
    partial class ReservationDetailForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ComboBoxSubExam = new System.Windows.Forms.ComboBox();
            this.ComboBoxMajorExam = new System.Windows.Forms.ComboBox();
            this.DateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.ButtonCompleteReception = new System.Windows.Forms.Button();
            this.ButtonCompleteTreatment = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelReservationID = new System.Windows.Forms.Label();
            this.LabelPatient = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelReservationDate = new System.Windows.Forms.Label();
            this.LabelMajorExam = new System.Windows.Forms.Label();
            this.LabelSubExam = new System.Windows.Forms.Label();
            this.ButtonCompleteUpdate = new System.Windows.Forms.Button();
            this.ButtonCancelUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(249, 32);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(124, 27);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "予約詳細";
            // 
            // ComboBoxSubExam
            // 
            this.ComboBoxSubExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubExam.FormattingEnabled = true;
            this.ComboBoxSubExam.ItemHeight = 16;
            this.ComboBoxSubExam.Location = new System.Drawing.Point(183, 300);
            this.ComboBoxSubExam.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxSubExam.Name = "ComboBoxSubExam";
            this.ComboBoxSubExam.Size = new System.Drawing.Size(324, 24);
            this.ComboBoxSubExam.TabIndex = 22;
            this.ComboBoxSubExam.Visible = false;
            // 
            // ComboBoxMajorExam
            // 
            this.ComboBoxMajorExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMajorExam.FormattingEnabled = true;
            this.ComboBoxMajorExam.Location = new System.Drawing.Point(183, 260);
            this.ComboBoxMajorExam.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxMajorExam.Name = "ComboBoxMajorExam";
            this.ComboBoxMajorExam.Size = new System.Drawing.Size(151, 24);
            this.ComboBoxMajorExam.TabIndex = 21;
            this.ComboBoxMajorExam.Visible = false;
            this.ComboBoxMajorExam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMajorExam_SelectedIndexChanged);
            // 
            // DateTimePickerReservationDate
            // 
            this.DateTimePickerReservationDate.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerReservationDate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Location = new System.Drawing.Point(183, 176);
            this.DateTimePickerReservationDate.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            this.DateTimePickerReservationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerReservationDate.Size = new System.Drawing.Size(151, 23);
            this.DateTimePickerReservationDate.TabIndex = 20;
            this.DateTimePickerReservationDate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "診療項目：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "状態：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "予約日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "患者：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "予約ID：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "小項目：";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Enabled = false;
            this.ButtonUpdate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.Location = new System.Drawing.Point(33, 376);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(83, 34);
            this.ButtonUpdate.TabIndex = 26;
            this.ButtonUpdate.Text = "編集";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExport.Location = new System.Drawing.Point(145, 376);
            this.ButtonExport.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(83, 34);
            this.ButtonExport.TabIndex = 27;
            this.ButtonExport.Text = "出力";
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // ButtonCompleteReception
            // 
            this.ButtonCompleteReception.Enabled = false;
            this.ButtonCompleteReception.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCompleteReception.Location = new System.Drawing.Point(254, 376);
            this.ButtonCompleteReception.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCompleteReception.Name = "ButtonCompleteReception";
            this.ButtonCompleteReception.Size = new System.Drawing.Size(102, 34);
            this.ButtonCompleteReception.TabIndex = 28;
            this.ButtonCompleteReception.Text = "受付完了";
            this.ButtonCompleteReception.UseVisualStyleBackColor = true;
            this.ButtonCompleteReception.Click += new System.EventHandler(this.ButtonCompleteReception_Click);
            // 
            // ButtonCompleteTreatment
            // 
            this.ButtonCompleteTreatment.Enabled = false;
            this.ButtonCompleteTreatment.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCompleteTreatment.Location = new System.Drawing.Point(387, 376);
            this.ButtonCompleteTreatment.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCompleteTreatment.Name = "ButtonCompleteTreatment";
            this.ButtonCompleteTreatment.Size = new System.Drawing.Size(102, 34);
            this.ButtonCompleteTreatment.TabIndex = 29;
            this.ButtonCompleteTreatment.Text = "診療完了";
            this.ButtonCompleteTreatment.UseVisualStyleBackColor = true;
            this.ButtonCompleteTreatment.Click += new System.EventHandler(this.ButtonCompleteTreatment_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(517, 376);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(83, 34);
            this.ButtonDelete.TabIndex = 30;
            this.ButtonDelete.Text = "削除";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelReservationID
            // 
            this.LabelReservationID.AutoSize = true;
            this.LabelReservationID.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReservationID.Location = new System.Drawing.Point(180, 96);
            this.LabelReservationID.Name = "LabelReservationID";
            this.LabelReservationID.Size = new System.Drawing.Size(0, 16);
            this.LabelReservationID.TabIndex = 31;
            // 
            // LabelPatient
            // 
            this.LabelPatient.AutoSize = true;
            this.LabelPatient.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPatient.Location = new System.Drawing.Point(180, 138);
            this.LabelPatient.Name = "LabelPatient";
            this.LabelPatient.Size = new System.Drawing.Size(0, 16);
            this.LabelPatient.TabIndex = 32;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(180, 220);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(0, 16);
            this.LabelStatus.TabIndex = 33;
            // 
            // LabelReservationDate
            // 
            this.LabelReservationDate.AutoSize = true;
            this.LabelReservationDate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReservationDate.Location = new System.Drawing.Point(180, 181);
            this.LabelReservationDate.Name = "LabelReservationDate";
            this.LabelReservationDate.Size = new System.Drawing.Size(0, 16);
            this.LabelReservationDate.TabIndex = 34;
            // 
            // LabelMajorExam
            // 
            this.LabelMajorExam.AutoSize = true;
            this.LabelMajorExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMajorExam.Location = new System.Drawing.Point(180, 263);
            this.LabelMajorExam.Name = "LabelMajorExam";
            this.LabelMajorExam.Size = new System.Drawing.Size(0, 16);
            this.LabelMajorExam.TabIndex = 35;
            // 
            // LabelSubExam
            // 
            this.LabelSubExam.AutoSize = true;
            this.LabelSubExam.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubExam.Location = new System.Drawing.Point(180, 303);
            this.LabelSubExam.Name = "LabelSubExam";
            this.LabelSubExam.Size = new System.Drawing.Size(0, 16);
            this.LabelSubExam.TabIndex = 36;
            // 
            // ButtonCompleteUpdate
            // 
            this.ButtonCompleteUpdate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCompleteUpdate.Location = new System.Drawing.Point(498, 87);
            this.ButtonCompleteUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCompleteUpdate.Name = "ButtonCompleteUpdate";
            this.ButtonCompleteUpdate.Size = new System.Drawing.Size(102, 34);
            this.ButtonCompleteUpdate.TabIndex = 37;
            this.ButtonCompleteUpdate.Text = "完了";
            this.ButtonCompleteUpdate.UseVisualStyleBackColor = true;
            this.ButtonCompleteUpdate.Visible = false;
            this.ButtonCompleteUpdate.Click += new System.EventHandler(this.ButtonCompleteUpdate_Click);
            // 
            // ButtonCancelUpdate
            // 
            this.ButtonCancelUpdate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancelUpdate.Location = new System.Drawing.Point(498, 138);
            this.ButtonCancelUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancelUpdate.Name = "ButtonCancelUpdate";
            this.ButtonCancelUpdate.Size = new System.Drawing.Size(102, 34);
            this.ButtonCancelUpdate.TabIndex = 38;
            this.ButtonCancelUpdate.Text = "キャンセル";
            this.ButtonCancelUpdate.UseVisualStyleBackColor = true;
            this.ButtonCancelUpdate.Visible = false;
            this.ButtonCancelUpdate.Click += new System.EventHandler(this.ButtonCancelUpdate_Click);
            // 
            // ReservationDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.ButtonCancelUpdate);
            this.Controls.Add(this.ButtonCompleteUpdate);
            this.Controls.Add(this.LabelSubExam);
            this.Controls.Add(this.LabelMajorExam);
            this.Controls.Add(this.LabelReservationDate);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelPatient);
            this.Controls.Add(this.LabelReservationID);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonCompleteTreatment);
            this.Controls.Add(this.ButtonCompleteReception);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ComboBoxSubExam);
            this.Controls.Add(this.ComboBoxMajorExam);
            this.Controls.Add(this.DateTimePickerReservationDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelTitle);
            this.Name = "ReservationDetailForm";
            this.Text = "ReservationDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox ComboBoxSubExam;
        private System.Windows.Forms.ComboBox ComboBoxMajorExam;
        private System.Windows.Forms.DateTimePicker DateTimePickerReservationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.Button ButtonCompleteReception;
        private System.Windows.Forms.Button ButtonCompleteTreatment;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelReservationID;
        private System.Windows.Forms.Label LabelPatient;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelReservationDate;
        private System.Windows.Forms.Label LabelMajorExam;
        private System.Windows.Forms.Label LabelSubExam;
        private System.Windows.Forms.Button ButtonCompleteUpdate;
        private System.Windows.Forms.Button ButtonCancelUpdate;
    }
}