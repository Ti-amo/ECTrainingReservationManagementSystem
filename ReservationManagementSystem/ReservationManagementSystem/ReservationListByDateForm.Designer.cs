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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.DateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.TextboxPageNumber = new System.Windows.Forms.TextBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.LabelTotalPages = new System.Windows.Forms.Label();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.DataGridViewReservationList = new System.Windows.Forms.DataGridView();
            this.ContainerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReservationList)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            resources.ApplyResources(this.ContainerPanel, "ContainerPanel");
            this.ContainerPanel.Controls.Add(this.LabelTitle);
            this.ContainerPanel.Name = "ContainerPanel";
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.Name = "LabelTitle";
            // 
            // DateTimePickerReservationDate
            // 
            resources.ApplyResources(this.DateTimePickerReservationDate, "DateTimePickerReservationDate");
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            this.DateTimePickerReservationDate.TabStop = false;
            this.DateTimePickerReservationDate.ValueChanged += new System.EventHandler(this.DateTimePickerReservationDate_ValueChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.panelStatus);
            this.panel1.Controls.Add(this.DateTimePickerReservationDate);
            this.panel1.Controls.Add(this.TextboxPageNumber);
            this.panel1.Controls.Add(this.ButtonNext);
            this.panel1.Controls.Add(this.LabelTotalPages);
            this.panel1.Controls.Add(this.ButtonPrevious);
            this.panel1.Controls.Add(this.DataGridViewReservationList);
            this.panel1.Name = "panel1";
            // 
            // panelStatus
            // 
            resources.ApplyResources(this.panelStatus, "panelStatus");
            this.panelStatus.Name = "panelStatus";
            // 
            // TextboxPageNumber
            // 
            resources.ApplyResources(this.TextboxPageNumber, "TextboxPageNumber");
            this.TextboxPageNumber.Name = "TextboxPageNumber";
            this.TextboxPageNumber.TabStop = false;
            this.TextboxPageNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxPageNumber_KeyDown);
            // 
            // ButtonNext
            // 
            resources.ApplyResources(this.ButtonNext, "ButtonNext");
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.TabStop = false;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // LabelTotalPages
            // 
            resources.ApplyResources(this.LabelTotalPages, "LabelTotalPages");
            this.LabelTotalPages.Name = "LabelTotalPages";
            // 
            // ButtonPrevious
            // 
            resources.ApplyResources(this.ButtonPrevious, "ButtonPrevious");
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.TabStop = false;
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // DataGridViewReservationList
            // 
            resources.ApplyResources(this.DataGridViewReservationList, "DataGridViewReservationList");
            this.DataGridViewReservationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewReservationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewReservationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewReservationList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewReservationList.Name = "DataGridViewReservationList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewReservationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewReservationList.Paint += new System.Windows.Forms.PaintEventHandler(this.DataGridViewReservationList_Paint);
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
            this.ContainerPanel.PerformLayout();
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
        private System.Windows.Forms.Label LabelTotalPages;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.DataGridView DataGridViewReservationList;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextboxPageNumber;
        private System.Windows.Forms.FlowLayoutPanel panelStatus;
    }
}