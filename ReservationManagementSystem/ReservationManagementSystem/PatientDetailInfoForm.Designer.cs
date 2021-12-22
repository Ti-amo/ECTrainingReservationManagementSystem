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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDetailInfoForm));
            this.ContainerPatientInfo = new System.Windows.Forms.Panel();
            this.ButtonEditDoB = new System.Windows.Forms.Button();
            this.ButtonEditName = new System.Windows.Forms.Button();
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
            this.ContainerPatientInfo.Controls.Add(this.ButtonEditDoB);
            this.ContainerPatientInfo.Controls.Add(this.ButtonEditName);
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
            this.ContainerPatientInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContainerPatientInfo.Name = "ContainerPatientInfo";
            this.ContainerPatientInfo.Size = new System.Drawing.Size(945, 305);
            this.ContainerPatientInfo.TabIndex = 0;
            // 
            // ButtonEditDoB
            // 
            this.ButtonEditDoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonEditDoB.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditDoB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditDoB.BackgroundImage")));
            this.ButtonEditDoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditDoB.FlatAppearance.BorderSize = 0;
            this.ButtonEditDoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditDoB.Location = new System.Drawing.Point(745, 175);
            this.ButtonEditDoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonEditDoB.Name = "ButtonEditDoB";
            this.ButtonEditDoB.Size = new System.Drawing.Size(19, 17);
            this.ButtonEditDoB.TabIndex = 11;
            this.ButtonEditDoB.UseVisualStyleBackColor = false;
            this.ButtonEditDoB.Click += new System.EventHandler(this.ButtonEditDoB_Click);
            // 
            // ButtonEditName
            // 
            this.ButtonEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonEditName.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditName.BackgroundImage")));
            this.ButtonEditName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditName.FlatAppearance.BorderSize = 0;
            this.ButtonEditName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditName.Location = new System.Drawing.Point(745, 128);
            this.ButtonEditName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonEditName.Name = "ButtonEditName";
            this.ButtonEditName.Size = new System.Drawing.Size(19, 17);
            this.ButtonEditName.TabIndex = 10;
            this.ButtonEditName.UseVisualStyleBackColor = false;
            this.ButtonEditName.Click += new System.EventHandler(this.ButtonEditName_Click);
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReserve.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(763, 225);
            this.ButtonReserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(120, 37);
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
            this.LabelLine.Location = new System.Drawing.Point(64, 286);
            this.LabelLine.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLine.Name = "LabelLine";
            this.LabelLine.Size = new System.Drawing.Size(44, 16);
            this.LabelLine.TabIndex = 8;
            this.LabelLine.Text = "label6";
            // 
            // TextboxDateOfBirth
            // 
            this.TextboxDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxDateOfBirth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxDateOfBirth.Location = new System.Drawing.Point(497, 167);
            this.TextboxDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxDateOfBirth.Name = "TextboxDateOfBirth";
            this.TextboxDateOfBirth.ReadOnly = true;
            this.TextboxDateOfBirth.Size = new System.Drawing.Size(221, 22);
            this.TextboxDateOfBirth.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "生年月日";
            // 
            // TextboxName
            // 
            this.TextboxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxName.Location = new System.Drawing.Point(497, 123);
            this.TextboxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.ReadOnly = true;
            this.TextboxName.Size = new System.Drawing.Size(221, 22);
            this.TextboxName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "氏名";
            // 
            // TextboxId
            // 
            this.TextboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxId.Location = new System.Drawing.Point(497, 79);
            this.TextboxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxId.Name = "TextboxId";
            this.TextboxId.ReadOnly = true;
            this.TextboxId.Size = new System.Drawing.Size(221, 22);
            this.TextboxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // LabelTitleInfo
            // 
            this.LabelTitleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelTitleInfo.AutoSize = true;
            this.LabelTitleInfo.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleInfo.Location = new System.Drawing.Point(407, 27);
            this.LabelTitleInfo.Name = "LabelTitleInfo";
            this.LabelTitleInfo.Size = new System.Drawing.Size(128, 27);
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
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 273);
            this.panel2.TabIndex = 1;
            // 
            // LabelPageNumber
            // 
            this.LabelPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPageNumber.AutoSize = true;
            this.LabelPageNumber.Location = new System.Drawing.Point(713, 228);
            this.LabelPageNumber.Name = "LabelPageNumber";
            this.LabelPageNumber.Size = new System.Drawing.Size(49, 20);
            this.LabelPageNumber.TabIndex = 5;
            this.LabelPageNumber.Text = "1/10";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNext.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(785, 219);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(100, 28);
            this.ButtonNext.TabIndex = 4;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPrevious.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrevious.Location = new System.Drawing.Point(595, 219);
            this.ButtonPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(100, 28);
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
            this.DataGridViewReserveList.Location = new System.Drawing.Point(61, 68);
            this.DataGridViewReserveList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewReserveList.Name = "DataGridViewReserveList";
            this.DataGridViewReserveList.RowHeadersWidth = 51;
            this.DataGridViewReserveList.Size = new System.Drawing.Size(821, 130);
            this.DataGridViewReserveList.TabIndex = 1;
            // 
            // LabelHistory
            // 
            this.LabelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelHistory.AutoSize = true;
            this.LabelHistory.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistory.Location = new System.Drawing.Point(428, 18);
            this.LabelHistory.Name = "LabelHistory";
            this.LabelHistory.Size = new System.Drawing.Size(128, 27);
            this.LabelHistory.TabIndex = 0;
            this.LabelHistory.Text = "診療履歴";
            // 
            // PatientDetailInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 578);
            this.Controls.Add(this.LabelTitleInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ContainerPatientInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientDetailInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button ButtonEditDoB;
        private System.Windows.Forms.Button ButtonEditName;
    }
}