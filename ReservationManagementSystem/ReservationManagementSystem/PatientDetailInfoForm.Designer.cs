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
            this.LabelTitleInfo = new System.Windows.Forms.Label();
            this.ButtonEditDoB = new System.Windows.Forms.Button();
            this.ButtonEditName = new System.Windows.Forms.Button();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.LabelLine = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelPageNumber = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.DataGridViewReserveList = new System.Windows.Forms.DataGridView();
            this.LabelHistory = new System.Windows.Forms.Label();
            this.DateTimePickerDoB = new ReservationManagementSystem.FlatDateTimePicker();
            this.ContainerPatientInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReserveList)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPatientInfo
            // 
            this.ContainerPatientInfo.BackColor = System.Drawing.Color.Transparent;
            this.ContainerPatientInfo.Controls.Add(this.LabelTitleInfo);
            this.ContainerPatientInfo.Controls.Add(this.DateTimePickerDoB);
            this.ContainerPatientInfo.Controls.Add(this.ButtonEditDoB);
            this.ContainerPatientInfo.Controls.Add(this.ButtonEditName);
            this.ContainerPatientInfo.Controls.Add(this.ButtonReserve);
            this.ContainerPatientInfo.Controls.Add(this.LabelLine);
            this.ContainerPatientInfo.Controls.Add(this.label4);
            this.ContainerPatientInfo.Controls.Add(this.TextboxName);
            this.ContainerPatientInfo.Controls.Add(this.label3);
            this.ContainerPatientInfo.Controls.Add(this.TextboxId);
            this.ContainerPatientInfo.Controls.Add(this.label2);
            this.ContainerPatientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerPatientInfo.Location = new System.Drawing.Point(0, 0);
            this.ContainerPatientInfo.Margin = new System.Windows.Forms.Padding(2);
            resources.ApplyResources(this.ContainerPatientInfo, "ContainerPatientInfo");
            this.ContainerPatientInfo.Name = "ContainerPatientInfo";
            // 
            // LabelTitleInfo
            // 
            resources.ApplyResources(this.LabelTitleInfo, "LabelTitleInfo");
            this.LabelTitleInfo.Name = "LabelTitleInfo";
            // 
            // DateTimePickerDoB
            // 
            resources.ApplyResources(this.DateTimePickerDoB, "DateTimePickerDoB");
            this.DateTimePickerDoB.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateTimePickerDoB.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.DateTimePickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDoB.Name = "DateTimePickerDoB";
            this.DateTimePickerDoB.Value = new System.DateTime(2021, 12, 22, 0, 0, 0, 0);
            // 
            // ButtonEditDoB
            // 
            resources.ApplyResources(this.ButtonEditDoB, "ButtonEditDoB");
            this.ButtonEditDoB.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditDoB.FlatAppearance.BorderSize = 0;
            this.ButtonEditDoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditDoB.Location = new System.Drawing.Point(469, 156);
            this.ButtonEditDoB.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEditDoB.Name = "ButtonEditDoB";
            this.ButtonEditDoB.UseVisualStyleBackColor = false;
            this.ButtonEditDoB.Click += new System.EventHandler(this.ButtonEditDoB_Click);
            // 
            // ButtonEditName
            // 
            resources.ApplyResources(this.ButtonEditName, "ButtonEditName");
            this.ButtonEditName.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditName.FlatAppearance.BorderSize = 0;
            this.ButtonEditName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditName.Location = new System.Drawing.Point(469, 115);
            this.ButtonEditName.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEditName.Name = "ButtonEditName";
            this.ButtonEditName.UseVisualStyleBackColor = false;
            this.ButtonEditName.Click += new System.EventHandler(this.ButtonEditName_Click);
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReserve.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(573, 188);
            this.ButtonReserve.Margin = new System.Windows.Forms.Padding(2);
            resources.ApplyResources(this.ButtonReserve, "ButtonReserve");
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // LabelLine
            // 
            resources.ApplyResources(this.LabelLine, "LabelLine");
            this.LabelLine.Name = "LabelLine";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TextboxName
            // 
            resources.ApplyResources(this.TextboxName, "TextboxName");
            this.TextboxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TextboxId
            // 
            resources.ApplyResources(this.TextboxId, "TextboxId");
            this.TextboxId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxId.Name = "TextboxId";
            this.TextboxId.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // LabelPageNumber
            // 
            resources.ApplyResources(this.LabelPageNumber, "LabelPageNumber");
            this.LabelPageNumber.Name = "LabelPageNumber";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNext.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(588, 178);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(2);
            resources.ApplyResources(this.ButtonNext, "ButtonNext");
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPrevious.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrevious.Location = new System.Drawing.Point(445, 178);
            this.ButtonPrevious.Margin = new System.Windows.Forms.Padding(2);
            resources.ApplyResources(this.ButtonPrevious, "ButtonPrevious");
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // DataGridViewReserveList
            // 
            resources.ApplyResources(this.DataGridViewReserveList, "DataGridViewReserveList");
            this.DataGridViewReserveList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewReserveList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewReserveList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewReserveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReserveList.Location = new System.Drawing.Point(45, 55);
            this.DataGridViewReserveList.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewReserveList.Name = "DataGridViewReserveList";
            this.DataGridViewReserveList.ReadOnly = true;
            this.DataGridViewReserveList.Size = new System.Drawing.Size(618, 86);
            this.DataGridViewReserveList.TabIndex = 1;
            this.DataGridViewReserveList.Paint += new System.Windows.Forms.PaintEventHandler(this.DataGridViewReserveList_Paint);
            // 
            // LabelHistory
            // 
            resources.ApplyResources(this.LabelHistory, "LabelHistory");
            this.LabelHistory.Name = "LabelHistory";
            // 
            // DateTimePickerDoB
            // 
            this.DateTimePickerDoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DateTimePickerDoB.BorderColor = System.Drawing.Color.Empty;
            this.DateTimePickerDoB.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerDoB.Enabled = false;
            this.DateTimePickerDoB.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDoB.Location = new System.Drawing.Point(330, 151);
            this.DateTimePickerDoB.Name = "DateTimePickerDoB";
            this.DateTimePickerDoB.Size = new System.Drawing.Size(126, 23);
            this.DateTimePickerDoB.TabIndex = 13;
            // 
            // PatientDetailInfoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ContainerPatientInfo);
            this.Name = "PatientDetailInfoForm";
            this.Load += new System.EventHandler(this.PatientDetailInfoForm_Load);
            this.ContainerPatientInfo.ResumeLayout(false);
            this.ContainerPatientInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReserveList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPatientInfo;
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
        private FlatDateTimePicker DateTimePickerDoB;
    }
}