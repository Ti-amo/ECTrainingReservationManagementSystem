
namespace ReservationManagementSystem
{
    partial class ExamItemDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamItemDeleteForm));
            this.ButtonDeleteSubExam = new System.Windows.Forms.Button();
            this.LabelSubItem = new System.Windows.Forms.Label();
            this.DropDownListSubItem_Delete = new System.Windows.Forms.ComboBox();
            this.DropDownListMajorItem_Delete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonDeleteMajorExam = new System.Windows.Forms.Button();
            this.LabelNotification = new System.Windows.Forms.Label();
            this.PanelNotification = new System.Windows.Forms.Panel();
            this.LabelNotifi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDeleteSubExam
            // 
            resources.ApplyResources(this.ButtonDeleteSubExam, "ButtonDeleteSubExam");
            this.ButtonDeleteSubExam.Name = "ButtonDeleteSubExam";
            this.ButtonDeleteSubExam.UseVisualStyleBackColor = true;
            this.ButtonDeleteSubExam.Click += new System.EventHandler(this.ButtonDeleteSubExam_Click);
            // 
            // LabelSubItem
            // 
            resources.ApplyResources(this.LabelSubItem, "LabelSubItem");
            this.LabelSubItem.Name = "LabelSubItem";
            // 
            // DropDownListSubItem_Delete
            // 
            resources.ApplyResources(this.DropDownListSubItem_Delete, "DropDownListSubItem_Delete");
            this.DropDownListSubItem_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListSubItem_Delete.FormattingEnabled = true;
            this.DropDownListSubItem_Delete.Name = "DropDownListSubItem_Delete";
            // 
            // DropDownListMajorItem_Delete
            // 
            resources.ApplyResources(this.DropDownListMajorItem_Delete, "DropDownListMajorItem_Delete");
            this.DropDownListMajorItem_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListMajorItem_Delete.FormattingEnabled = true;
            this.DropDownListMajorItem_Delete.Name = "DropDownListMajorItem_Delete";
            this.DropDownListMajorItem_Delete.SelectedIndexChanged += new System.EventHandler(this.DropDownListMajorItem_Delete_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // ButtonDeleteMajorExam
            // 
            resources.ApplyResources(this.ButtonDeleteMajorExam, "ButtonDeleteMajorExam");
            this.ButtonDeleteMajorExam.Name = "ButtonDeleteMajorExam";
            this.ButtonDeleteMajorExam.UseVisualStyleBackColor = true;
            this.ButtonDeleteMajorExam.Click += new System.EventHandler(this.ButtonDeleteMajorExam_Click);
            // 
            // LabelNotification
            // 
            resources.ApplyResources(this.LabelNotification, "LabelNotification");
            this.LabelNotification.Name = "LabelNotification";
            // 
            // PanelNotification
            // 
            resources.ApplyResources(this.PanelNotification, "PanelNotification");
            this.PanelNotification.Controls.Add(this.LabelNotifi);
            this.PanelNotification.Controls.Add(this.pictureBox1);
            this.PanelNotification.Name = "PanelNotification";
            // 
            // LabelNotifi
            // 
            resources.ApplyResources(this.LabelNotifi, "LabelNotifi");
            this.LabelNotifi.Name = "LabelNotifi";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::ReservationManagementSystem.Properties.Resources.sad;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ExamItemDeleteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelNotification);
            this.Controls.Add(this.LabelNotification);
            this.Controls.Add(this.ButtonDeleteMajorExam);
            this.Controls.Add(this.ButtonDeleteSubExam);
            this.Controls.Add(this.LabelSubItem);
            this.Controls.Add(this.DropDownListSubItem_Delete);
            this.Controls.Add(this.DropDownListMajorItem_Delete);
            this.Controls.Add(this.label4);
            this.Name = "ExamItemDeleteForm";
            this.Load += new System.EventHandler(this.ExamItemDeleteForm_Load);
            this.PanelNotification.ResumeLayout(false);
            this.PanelNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDeleteSubExam;
        private System.Windows.Forms.Label LabelSubItem;
        private System.Windows.Forms.ComboBox DropDownListSubItem_Delete;
        private System.Windows.Forms.ComboBox DropDownListMajorItem_Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonDeleteMajorExam;
        private System.Windows.Forms.Label LabelNotification;
        private System.Windows.Forms.Panel PanelNotification;
        private System.Windows.Forms.Label LabelNotifi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}