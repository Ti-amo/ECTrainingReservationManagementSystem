
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
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DropDownListSubItem_Delete = new System.Windows.Forms.ComboBox();
            this.DropDownListMajorItem_Delete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonDelete
            // 
            resources.ApplyResources(this.ButtonDelete, "ButtonDelete");
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
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
            // ExamItemDeleteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DropDownListSubItem_Delete);
            this.Controls.Add(this.DropDownListMajorItem_Delete);
            this.Controls.Add(this.label4);
            this.Name = "ExamItemDeleteForm";
            this.Load += new System.EventHandler(this.ExamItemDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DropDownListSubItem_Delete;
        private System.Windows.Forms.ComboBox DropDownListMajorItem_Delete;
        private System.Windows.Forms.Label label4;
    }
}