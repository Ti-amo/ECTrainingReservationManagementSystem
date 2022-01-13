
namespace ReservationManagementSystem
{
    partial class PatientListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientListForm));
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextboxSearch = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.DataGridViewPatientList = new System.Windows.Forms.DataGridView();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextboxPageNumber = new System.Windows.Forms.TextBox();
            this.LabelTotalPages = new System.Windows.Forms.Label();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPatientList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.ButtonSearch);
            this.ContainerPanel.Controls.Add(this.TextboxSearch);
            resources.ApplyResources(this.ContainerPanel, "ContainerPanel");
            this.ContainerPanel.Name = "ContainerPanel";
            // 
            // ButtonSearch
            // 
            resources.ApplyResources(this.ButtonSearch, "ButtonSearch");
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.TabStop = false;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextboxSearch
            // 
            resources.ApplyResources(this.TextboxSearch, "TextboxSearch");
            this.TextboxSearch.Name = "TextboxSearch";
            this.TextboxSearch.TabStop = false;
            this.TextboxSearch.TextChanged += new System.EventHandler(this.TextboxSearch_TextChanged);
            this.TextboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxSearch_KeyDown);
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.Name = "LabelTitle";
            // 
            // DataGridViewPatientList
            // 
            resources.ApplyResources(this.DataGridViewPatientList, "DataGridViewPatientList");
            this.DataGridViewPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewPatientList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPatientList.Name = "DataGridViewPatientList";
            this.DataGridViewPatientList.ReadOnly = true;
            this.DataGridViewPatientList.Paint += new System.Windows.Forms.PaintEventHandler(this.DataGridViewPatientList_Paint);
            // 
            // ButtonNext
            // 
            resources.ApplyResources(this.ButtonNext, "ButtonNext");
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.TabStop = false;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextboxPageNumber);
            this.panel1.Controls.Add(this.ButtonNext);
            this.panel1.Controls.Add(this.LabelTotalPages);
            this.panel1.Controls.Add(this.ButtonPrevious);
            this.panel1.Controls.Add(this.DataGridViewPatientList);
            this.panel1.Controls.Add(this.LabelTitle);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TextboxPageNumber
            // 
            resources.ApplyResources(this.TextboxPageNumber, "TextboxPageNumber");
            this.TextboxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxPageNumber.Name = "TextboxPageNumber";
            this.TextboxPageNumber.TabStop = false;
            this.TextboxPageNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxPageNumber_KeyDown);
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
            // PatientListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContainerPanel);
            this.Name = "PatientListForm";
            this.Load += new System.EventHandler(this.PatientListForm_Load);
            this.ContainerPanel.ResumeLayout(false);
            this.ContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPatientList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextboxSearch;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.DataGridView DataGridViewPatientList;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTotalPages;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.TextBox TextboxPageNumber;
    }
}