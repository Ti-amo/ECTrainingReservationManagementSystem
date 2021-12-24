namespace ReservationManagementSystem
{
    partial class ReservationListByDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationListByDateForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.DateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.LabelPageNumber = new System.Windows.Forms.Label();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.DataGridViewReservationList = new System.Windows.Forms.DataGridView();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ContainerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReservationList)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            resources.ApplyResources(this.ContainerPanel, "ContainerPanel");
            this.ContainerPanel.Controls.Add(this.DateTimePickerReservationDate);
            this.ContainerPanel.Name = "ContainerPanel";
            // 
            // DateTimePickerReservationDate
            // 
            resources.ApplyResources(this.DateTimePickerReservationDate, "DateTimePickerReservationDate");
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            this.DateTimePickerReservationDate.ValueChanged += new System.EventHandler(this.DateTimePickerReservationDate_ValueChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.ButtonNext);
            this.panel1.Controls.Add(this.LabelPageNumber);
            this.panel1.Controls.Add(this.ButtonPrevious);
            this.panel1.Controls.Add(this.DataGridViewReservationList);
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Name = "panel1";
            // 
            // ButtonNext
            // 
            resources.ApplyResources(this.ButtonNext, "ButtonNext");
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // LabelPageNumber
            // 
            resources.ApplyResources(this.LabelPageNumber, "LabelPageNumber");
            this.LabelPageNumber.Name = "LabelPageNumber";
            // 
            // ButtonPrevious
            // 
            resources.ApplyResources(this.ButtonPrevious, "ButtonPrevious");
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // DataGridViewReservationList
            // 
            resources.ApplyResources(this.DataGridViewReservationList, "DataGridViewReservationList");
            this.DataGridViewReservationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewReservationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewReservationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewReservationList.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewReservationList.Name = "DataGridViewReservationList";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewReservationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewReservationList.Paint += new System.Windows.Forms.PaintEventHandler(this.DataGridViewReservationList_Paint);
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.Name = "LabelTitle";
            // 
            // ReservationListByDateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContainerPanel);
            this.Name = "ReservationListByDateForm";
            this.Load += new System.EventHandler(this.ReservationListByDateForm_Load);
            this.ContainerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReservationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.DateTimePicker DateTimePickerReservationDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Label LabelPageNumber;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.DataGridView DataGridViewReservationList;
        private System.Windows.Forms.Label LabelTitle;
    }
}