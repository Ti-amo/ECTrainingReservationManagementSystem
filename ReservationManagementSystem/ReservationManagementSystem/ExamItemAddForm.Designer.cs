
namespace ReservationManagementSystem
{
    partial class ExamItemAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamItemAddForm));
            this.TextboxMajorItemName_Ja = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextboxSubItemName_Eng = new System.Windows.Forms.TextBox();
            this.TextboxSubItemName_Ja = new System.Windows.Forms.TextBox();
            this.TextboxMajorItemName_Eng = new System.Windows.Forms.TextBox();
            this.DropDownListMajorItem_Add = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelLanguage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextboxMajorItemName_Ja
            // 
            resources.ApplyResources(this.TextboxMajorItemName_Ja, "TextboxMajorItemName_Ja");
            this.TextboxMajorItemName_Ja.Name = "TextboxMajorItemName_Ja";
            // 
            // ButtonAdd
            // 
            resources.ApplyResources(this.ButtonAdd, "ButtonAdd");
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextboxSubItemName_Eng
            // 
            resources.ApplyResources(this.TextboxSubItemName_Eng, "TextboxSubItemName_Eng");
            this.TextboxSubItemName_Eng.Name = "TextboxSubItemName_Eng";
            // 
            // TextboxSubItemName_Ja
            // 
            resources.ApplyResources(this.TextboxSubItemName_Ja, "TextboxSubItemName_Ja");
            this.TextboxSubItemName_Ja.Name = "TextboxSubItemName_Ja";
            // 
            // TextboxMajorItemName_Eng
            // 
            resources.ApplyResources(this.TextboxMajorItemName_Eng, "TextboxMajorItemName_Eng");
            this.TextboxMajorItemName_Eng.Name = "TextboxMajorItemName_Eng";
            // 
            // DropDownListMajorItem_Add
            // 
            resources.ApplyResources(this.DropDownListMajorItem_Add, "DropDownListMajorItem_Add");
            this.DropDownListMajorItem_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListMajorItem_Add.FormattingEnabled = true;
            this.DropDownListMajorItem_Add.Name = "DropDownListMajorItem_Add";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // LabelLanguage
            // 
            resources.ApplyResources(this.LabelLanguage, "LabelLanguage");
            this.LabelLanguage.Name = "LabelLanguage";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ButtonEdit
            // 
            resources.ApplyResources(this.ButtonEdit, "ButtonEdit");
            this.ButtonEdit.BackgroundImage = global::ReservationManagementSystem.Properties.Resources.add;
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ExamItemAddForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextboxMajorItemName_Ja);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextboxSubItemName_Eng);
            this.Controls.Add(this.TextboxSubItemName_Ja);
            this.Controls.Add(this.TextboxMajorItemName_Eng);
            this.Controls.Add(this.DropDownListMajorItem_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExamItemAddForm";
            this.Load += new System.EventHandler(this.ExamItemAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxMajorItemName_Ja;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextboxSubItemName_Eng;
        private System.Windows.Forms.TextBox TextboxSubItemName_Ja;
        private System.Windows.Forms.TextBox TextboxMajorItemName_Eng;
        private System.Windows.Forms.ComboBox DropDownListMajorItem_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}