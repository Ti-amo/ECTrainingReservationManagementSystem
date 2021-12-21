namespace ReservationManagementSystem
{
    partial class PatientDetailInfoForm
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
            this.ContainerPatientInfo = new System.Windows.Forms.Panel();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.LabelLine = new System.Windows.Forms.Label();
            this.TextboxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTitleInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelPageNumber = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.DataGridViewReserveList = new System.Windows.Forms.DataGridView();
            this.LabelHistory = new System.Windows.Forms.Label();
            this.ContainerPatientInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReserveList)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPatientInfo
            // 
            this.ContainerPatientInfo.Controls.Add(this.ButtonReserve);
            this.ContainerPatientInfo.Controls.Add(this.LabelLine);
            this.ContainerPatientInfo.Controls.Add(this.TextboxDateOfBirth);
            this.ContainerPatientInfo.Controls.Add(this.label4);
            this.ContainerPatientInfo.Controls.Add(this.TextboxName);
            this.ContainerPatientInfo.Controls.Add(this.label3);
            this.ContainerPatientInfo.Controls.Add(this.TextboxId);
            this.ContainerPatientInfo.Controls.Add(this.label2);
            this.ContainerPatientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerPatientInfo.Location = new System.Drawing.Point(0, 0);
            this.ContainerPatientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.ContainerPatientInfo.Name = "ContainerPatientInfo";
            this.ContainerPatientInfo.Size = new System.Drawing.Size(709, 248);
            this.ContainerPatientInfo.TabIndex = 0;
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReserve.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(572, 183);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(90, 30);
            this.ButtonReserve.TabIndex = 9;
            this.ButtonReserve.Text = "予約登録";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // LabelLine
            // 
            this.LabelLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLine.AutoSize = true;
            this.LabelLine.Location = new System.Drawing.Point(48, 232);
            this.LabelLine.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLine.Name = "LabelLine";
            this.LabelLine.Size = new System.Drawing.Size(35, 13);
            this.LabelLine.TabIndex = 8;
            this.LabelLine.Text = "label6";
            // 
            // TextboxDateOfBirth
            // 
            this.TextboxDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxDateOfBirth.BackColor = System.Drawing.Color.White;
            this.TextboxDateOfBirth.Location = new System.Drawing.Point(373, 136);
            this.TextboxDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxDateOfBirth.Name = "TextboxDateOfBirth";
            this.TextboxDateOfBirth.ReadOnly = true;
            this.TextboxDateOfBirth.Size = new System.Drawing.Size(167, 20);
            this.TextboxDateOfBirth.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "生年月日";
            // 
            // TextboxName
            // 
            this.TextboxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxName.BackColor = System.Drawing.Color.White;
            this.TextboxName.Location = new System.Drawing.Point(373, 100);
            this.TextboxName.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.ReadOnly = true;
            this.TextboxName.Size = new System.Drawing.Size(167, 20);
            this.TextboxName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "氏名";
            // 
            // TextboxId
            // 
            this.TextboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxId.BackColor = System.Drawing.Color.White;
            this.TextboxId.Location = new System.Drawing.Point(373, 64);
            this.TextboxId.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxId.Name = "TextboxId";
            this.TextboxId.ReadOnly = true;
            this.TextboxId.Size = new System.Drawing.Size(167, 20);
            this.TextboxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // LabelTitleInfo
            // 
            this.LabelTitleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelTitleInfo.AutoSize = true;
            this.LabelTitleInfo.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleInfo.Location = new System.Drawing.Point(305, 22);
            this.LabelTitleInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitleInfo.Name = "LabelTitleInfo";
            this.LabelTitleInfo.Size = new System.Drawing.Size(102, 21);
            this.LabelTitleInfo.TabIndex = 0;
            this.LabelTitleInfo.Text = "患者情報";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelPageNumber);
            this.panel2.Controls.Add(this.ButtonNext);
            this.panel2.Controls.Add(this.ButtonPrevious);
            this.panel2.Controls.Add(this.DataGridViewReserveList);
            this.panel2.Controls.Add(this.LabelHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 248);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 222);
            this.panel2.TabIndex = 1;
            // 
            // LabelPageNumber
            // 
            this.LabelPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPageNumber.AutoSize = true;
            this.LabelPageNumber.Location = new System.Drawing.Point(535, 185);
            this.LabelPageNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPageNumber.Name = "LabelPageNumber";
            this.LabelPageNumber.Size = new System.Drawing.Size(40, 16);
            this.LabelPageNumber.TabIndex = 5;
            this.LabelPageNumber.Text = "1/10";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNext.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(589, 178);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext.TabIndex = 4;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPrevious.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrevious.Location = new System.Drawing.Point(446, 178);
            this.ButtonPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrevious.TabIndex = 2;
            this.ButtonPrevious.Text = "<";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // DataGridViewReserveList
            // 
            this.DataGridViewReserveList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewReserveList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewReserveList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewReserveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReserveList.Location = new System.Drawing.Point(46, 55);
            this.DataGridViewReserveList.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewReserveList.Name = "DataGridViewReserveList";
            this.DataGridViewReserveList.Size = new System.Drawing.Size(616, 106);
            this.DataGridViewReserveList.TabIndex = 1;
            // 
            // LabelHistory
            // 
            this.LabelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelHistory.AutoSize = true;
            this.LabelHistory.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistory.Location = new System.Drawing.Point(321, 15);
            this.LabelHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelHistory.Name = "LabelHistory";
            this.LabelHistory.Size = new System.Drawing.Size(102, 21);
            this.LabelHistory.TabIndex = 0;
            this.LabelHistory.Text = "診療履歴";
            // 
            // PatientDetailInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 470);
            this.Controls.Add(this.LabelTitleInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ContainerPatientInfo);
            this.Name = "PatientDetailInfoForm";
            this.Text = "PatientDetailInfoForm";
            this.Load += new System.EventHandler(this.PatientDetailInfoForm_Load);
            this.ContainerPatientInfo.ResumeLayout(false);
            this.ContainerPatientInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReserveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPatientInfo;
        private System.Windows.Forms.TextBox TextboxDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextboxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTitleInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.DataGridView DataGridViewReserveList;
        private System.Windows.Forms.Label LabelHistory;
        private System.Windows.Forms.Label LabelLine;
        private System.Windows.Forms.Label LabelPageNumber;
        private System.Windows.Forms.Button ButtonReserve;
    }
}