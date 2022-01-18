
namespace ReservationManagementSystem
{
    partial class ManageExamForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageAdd = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextboxSubItemName_Eng = new System.Windows.Forms.TextBox();
            this.TextboxSubItemName_Ja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxMajorItemName_Eng = new System.Windows.Forms.TextBox();
            this.LabelLanguage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DropDownListMajorItem_Add = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPageDelete = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DropDownListSubItem_Delete = new System.Windows.Forms.ComboBox();
            this.DropDownListMajorItem_Delete = new System.Windows.Forms.ComboBox();
            this.TextboxMajorItemName_Ja = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabPageAdd.SuspendLayout();
            this.TabPageDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabPageAdd);
            this.tabControl1.Controls.Add(this.TabPageDelete);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 419);
            this.tabControl1.TabIndex = 3;
            // 
            // TabPageAdd
            // 
            this.TabPageAdd.Controls.Add(this.TextboxMajorItemName_Ja);
            this.TabPageAdd.Controls.Add(this.label10);
            this.TabPageAdd.Controls.Add(this.ButtonAdd);
            this.TabPageAdd.Controls.Add(this.ButtonEdit);
            this.TabPageAdd.Controls.Add(this.TextboxSubItemName_Eng);
            this.TabPageAdd.Controls.Add(this.TextboxSubItemName_Ja);
            this.TabPageAdd.Controls.Add(this.label6);
            this.TabPageAdd.Controls.Add(this.label5);
            this.TabPageAdd.Controls.Add(this.label4);
            this.TabPageAdd.Controls.Add(this.TextboxMajorItemName_Eng);
            this.TabPageAdd.Controls.Add(this.LabelLanguage);
            this.TabPageAdd.Controls.Add(this.label2);
            this.TabPageAdd.Controls.Add(this.DropDownListMajorItem_Add);
            this.TabPageAdd.Controls.Add(this.label1);
            this.TabPageAdd.Location = new System.Drawing.Point(4, 26);
            this.TabPageAdd.Name = "TabPageAdd";
            this.TabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAdd.Size = new System.Drawing.Size(678, 389);
            this.TabPageAdd.TabIndex = 0;
            this.TabPageAdd.Text = "追加";
            this.TabPageAdd.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "診療項目追加";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(454, 336);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 11;
            this.ButtonAdd.Text = "追加";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(488, 117);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(41, 23);
            this.ButtonEdit.TabIndex = 10;
            this.ButtonEdit.Text = "Add";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextboxSubItemName_Eng
            // 
            this.TextboxSubItemName_Eng.Location = new System.Drawing.Point(268, 293);
            this.TextboxSubItemName_Eng.Name = "TextboxSubItemName_Eng";
            this.TextboxSubItemName_Eng.Size = new System.Drawing.Size(165, 23);
            this.TextboxSubItemName_Eng.TabIndex = 9;
            // 
            // TextboxSubItemName_Ja
            // 
            this.TextboxSubItemName_Ja.Location = new System.Drawing.Point(268, 249);
            this.TextboxSubItemName_Ja.Name = "TextboxSubItemName_Ja";
            this.TextboxSubItemName_Ja.Size = new System.Drawing.Size(165, 23);
            this.TextboxSubItemName_Ja.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "英語";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "日本語";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "診療小項目";
            // 
            // TextboxMajorItemName_Eng
            // 
            this.TextboxMajorItemName_Eng.Location = new System.Drawing.Point(268, 161);
            this.TextboxMajorItemName_Eng.Name = "TextboxMajorItemName_Eng";
            this.TextboxMajorItemName_Eng.Size = new System.Drawing.Size(165, 23);
            this.TextboxMajorItemName_Eng.TabIndex = 4;
            this.TextboxMajorItemName_Eng.Visible = false;
            // 
            // LabelLanguage
            // 
            this.LabelLanguage.AutoSize = true;
            this.LabelLanguage.Location = new System.Drawing.Point(181, 168);
            this.LabelLanguage.Name = "LabelLanguage";
            this.LabelLanguage.Size = new System.Drawing.Size(40, 16);
            this.LabelLanguage.TabIndex = 3;
            this.LabelLanguage.Text = "英語";
            this.LabelLanguage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "日本語";
            // 
            // DropDownListMajorItem_Add
            // 
            this.DropDownListMajorItem_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListMajorItem_Add.FormattingEnabled = true;
            this.DropDownListMajorItem_Add.Location = new System.Drawing.Point(268, 116);
            this.DropDownListMajorItem_Add.Name = "DropDownListMajorItem_Add";
            this.DropDownListMajorItem_Add.Size = new System.Drawing.Size(165, 24);
            this.DropDownListMajorItem_Add.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "診療大項目";
            // 
            // TabPageDelete
            // 
            this.TabPageDelete.Controls.Add(this.label9);
            this.TabPageDelete.Controls.Add(this.ButtonDelete);
            this.TabPageDelete.Controls.Add(this.label8);
            this.TabPageDelete.Controls.Add(this.label7);
            this.TabPageDelete.Controls.Add(this.DropDownListSubItem_Delete);
            this.TabPageDelete.Controls.Add(this.DropDownListMajorItem_Delete);
            this.TabPageDelete.Location = new System.Drawing.Point(4, 26);
            this.TabPageDelete.Name = "TabPageDelete";
            this.TabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDelete.Size = new System.Drawing.Size(678, 389);
            this.TabPageDelete.TabIndex = 1;
            this.TabPageDelete.Text = "削除";
            this.TabPageDelete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(284, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "診療項目削除";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(436, 301);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "削除";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "診療小項目";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "診療大項目";
            // 
            // DropDownListSubItem_Delete
            // 
            this.DropDownListSubItem_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListSubItem_Delete.FormattingEnabled = true;
            this.DropDownListSubItem_Delete.Location = new System.Drawing.Point(307, 218);
            this.DropDownListSubItem_Delete.Name = "DropDownListSubItem_Delete";
            this.DropDownListSubItem_Delete.Size = new System.Drawing.Size(165, 24);
            this.DropDownListSubItem_Delete.TabIndex = 1;
            // 
            // DropDownListMajorItem_Delete
            // 
            this.DropDownListMajorItem_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListMajorItem_Delete.FormattingEnabled = true;
            this.DropDownListMajorItem_Delete.Location = new System.Drawing.Point(307, 138);
            this.DropDownListMajorItem_Delete.Name = "DropDownListMajorItem_Delete";
            this.DropDownListMajorItem_Delete.Size = new System.Drawing.Size(165, 24);
            this.DropDownListMajorItem_Delete.TabIndex = 0;
            // 
            // TextboxMajorItemName_Ja
            // 
            this.TextboxMajorItemName_Ja.Location = new System.Drawing.Point(268, 116);
            this.TextboxMajorItemName_Ja.Name = "TextboxMajorItemName_Ja";
            this.TextboxMajorItemName_Ja.Size = new System.Drawing.Size(165, 23);
            this.TextboxMajorItemName_Ja.TabIndex = 13;
            this.TextboxMajorItemName_Ja.Visible = false;
            // 
            // ManageExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(710, 443);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageExamForm";
            this.Text = "ManageExamForm";
            this.Load += new System.EventHandler(this.ManageExamForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPageAdd.ResumeLayout(false);
            this.TabPageAdd.PerformLayout();
            this.TabPageDelete.ResumeLayout(false);
            this.TabPageDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageAdd;
        private System.Windows.Forms.TabPage TabPageDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextboxSubItemName_Eng;
        private System.Windows.Forms.TextBox TextboxSubItemName_Ja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextboxMajorItemName_Eng;
        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DropDownListMajorItem_Add;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DropDownListSubItem_Delete;
        private System.Windows.Forms.ComboBox DropDownListMajorItem_Delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextboxMajorItemName_Ja;
    }
}