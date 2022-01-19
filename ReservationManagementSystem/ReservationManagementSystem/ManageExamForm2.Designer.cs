
namespace ReservationManagementSystem
{
    partial class ManageExamForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelLanguage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DropDownListMajorItem_Add = new System.Windows.Forms.ComboBox();
            this.TextboxMajorItemName_Eng = new System.Windows.Forms.TextBox();
            this.TextboxSubItemName_Ja = new System.Windows.Forms.TextBox();
            this.TextboxSubItemName_Eng = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextboxMajorItemName_Ja = new System.Windows.Forms.TextBox();
            this.PanelDelete = new System.Windows.Forms.Panel();
            this.DropDownListMajorItem_Delete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DropDownListSubItem_Delete = new System.Windows.Forms.ComboBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ToggleButtonStatus = new ReservationManagementSystem.ToggleButton();
            this.PanelAdd.SuspendLayout();
            this.PanelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "診療項目";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "追加";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "削除";
            // 
            // PanelAdd
            // 
            this.PanelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAdd.BackColor = System.Drawing.Color.White;
            this.PanelAdd.Controls.Add(this.TextboxMajorItemName_Ja);
            this.PanelAdd.Controls.Add(this.ButtonEdit);
            this.PanelAdd.Controls.Add(this.ButtonAdd);
            this.PanelAdd.Controls.Add(this.TextboxSubItemName_Eng);
            this.PanelAdd.Controls.Add(this.TextboxSubItemName_Ja);
            this.PanelAdd.Controls.Add(this.TextboxMajorItemName_Eng);
            this.PanelAdd.Controls.Add(this.DropDownListMajorItem_Add);
            this.PanelAdd.Controls.Add(this.label11);
            this.PanelAdd.Controls.Add(this.label10);
            this.PanelAdd.Controls.Add(this.label9);
            this.PanelAdd.Controls.Add(this.LabelLanguage);
            this.PanelAdd.Controls.Add(this.label7);
            this.PanelAdd.Controls.Add(this.label6);
            this.PanelAdd.Location = new System.Drawing.Point(40, 106);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(628, 311);
            this.PanelAdd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "診療大項目";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "日本語";
            // 
            // LabelLanguage
            // 
            this.LabelLanguage.AutoSize = true;
            this.LabelLanguage.Location = new System.Drawing.Point(137, 110);
            this.LabelLanguage.Name = "LabelLanguage";
            this.LabelLanguage.Size = new System.Drawing.Size(40, 16);
            this.LabelLanguage.TabIndex = 2;
            this.LabelLanguage.Text = "英語";
            this.LabelLanguage.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "診療小項目";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "日本語";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "英語";
            // 
            // DropDownListMajorItem_Add
            // 
            this.DropDownListMajorItem_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListMajorItem_Add.FormattingEnabled = true;
            this.DropDownListMajorItem_Add.Location = new System.Drawing.Point(257, 64);
            this.DropDownListMajorItem_Add.Name = "DropDownListMajorItem_Add";
            this.DropDownListMajorItem_Add.Size = new System.Drawing.Size(165, 24);
            this.DropDownListMajorItem_Add.TabIndex = 6;
            // 
            // TextboxMajorItemName_Eng
            // 
            this.TextboxMajorItemName_Eng.Location = new System.Drawing.Point(257, 103);
            this.TextboxMajorItemName_Eng.Name = "TextboxMajorItemName_Eng";
            this.TextboxMajorItemName_Eng.Size = new System.Drawing.Size(165, 23);
            this.TextboxMajorItemName_Eng.TabIndex = 7;
            this.TextboxMajorItemName_Eng.Visible = false;
            // 
            // TextboxSubItemName_Ja
            // 
            this.TextboxSubItemName_Ja.Location = new System.Drawing.Point(257, 179);
            this.TextboxSubItemName_Ja.Name = "TextboxSubItemName_Ja";
            this.TextboxSubItemName_Ja.Size = new System.Drawing.Size(165, 23);
            this.TextboxSubItemName_Ja.TabIndex = 8;
            // 
            // TextboxSubItemName_Eng
            // 
            this.TextboxSubItemName_Eng.Location = new System.Drawing.Point(257, 217);
            this.TextboxSubItemName_Eng.Name = "TextboxSubItemName_Eng";
            this.TextboxSubItemName_Eng.Size = new System.Drawing.Size(165, 23);
            this.TextboxSubItemName_Eng.TabIndex = 9;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(454, 256);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 10;
            this.ButtonAdd.Text = "追加";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(488, 65);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(41, 23);
            this.ButtonEdit.TabIndex = 11;
            this.ButtonEdit.Text = "Add";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextboxMajorItemName_Ja
            // 
            this.TextboxMajorItemName_Ja.Location = new System.Drawing.Point(257, 64);
            this.TextboxMajorItemName_Ja.Name = "TextboxMajorItemName_Ja";
            this.TextboxMajorItemName_Ja.Size = new System.Drawing.Size(165, 23);
            this.TextboxMajorItemName_Ja.TabIndex = 12;
            this.TextboxMajorItemName_Ja.Visible = false;
            // 
            // PanelDelete
            // 
            this.PanelDelete.BackColor = System.Drawing.Color.White;
            this.PanelDelete.Controls.Add(this.ButtonDelete);
            this.PanelDelete.Controls.Add(this.label5);
            this.PanelDelete.Controls.Add(this.DropDownListSubItem_Delete);
            this.PanelDelete.Controls.Add(this.DropDownListMajorItem_Delete);
            this.PanelDelete.Controls.Add(this.label4);
            this.PanelDelete.Location = new System.Drawing.Point(40, 106);
            this.PanelDelete.Name = "PanelDelete";
            this.PanelDelete.Size = new System.Drawing.Size(628, 311);
            this.PanelDelete.TabIndex = 13;
            this.PanelDelete.Visible = false;
            // 
            // DropDownListMajorItem_Delete
            // 
            this.DropDownListMajorItem_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DropDownListMajorItem_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListMajorItem_Delete.FormattingEnabled = true;
            this.DropDownListMajorItem_Delete.Location = new System.Drawing.Point(294, 104);
            this.DropDownListMajorItem_Delete.Name = "DropDownListMajorItem_Delete";
            this.DropDownListMajorItem_Delete.Size = new System.Drawing.Size(165, 24);
            this.DropDownListMajorItem_Delete.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "診療大項目";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "診療小項目";
            // 
            // DropDownListSubItem_Delete
            // 
            this.DropDownListSubItem_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DropDownListSubItem_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListSubItem_Delete.FormattingEnabled = true;
            this.DropDownListSubItem_Delete.Location = new System.Drawing.Point(294, 171);
            this.DropDownListSubItem_Delete.Name = "DropDownListSubItem_Delete";
            this.DropDownListSubItem_Delete.Size = new System.Drawing.Size(165, 24);
            this.DropDownListSubItem_Delete.TabIndex = 4;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.Location = new System.Drawing.Point(479, 234);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "削除";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ToggleButtonStatus
            // 
            this.ToggleButtonStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleButtonStatus.Location = new System.Drawing.Point(562, 63);
            this.ToggleButtonStatus.MinimumSize = new System.Drawing.Size(45, 22);
            this.ToggleButtonStatus.Name = "ToggleButtonStatus";
            this.ToggleButtonStatus.OffBackColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.OffToggleColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.OnBackColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.OnToggleColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.Size = new System.Drawing.Size(60, 22);
            this.ToggleButtonStatus.SolidStyle = false;
            this.ToggleButtonStatus.TabIndex = 6;
            this.ToggleButtonStatus.Text = "toggleButton1";
            this.ToggleButtonStatus.UseVisualStyleBackColor = true;
            this.ToggleButtonStatus.CheckedChanged += new System.EventHandler(this.ToggleButtonStatus_CheckedChanged);
            // 
            // ManageExamForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 443);
            this.Controls.Add(this.PanelDelete);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.ToggleButtonStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageExamForm2";
            this.Text = "ManageExamForm2";
            this.Load += new System.EventHandler(this.ManageExamForm2_Load);
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.PanelDelete.ResumeLayout(false);
            this.PanelDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ToggleButton ToggleButtonStatus;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextboxSubItemName_Eng;
        private System.Windows.Forms.TextBox TextboxSubItemName_Ja;
        private System.Windows.Forms.TextBox TextboxMajorItemName_Eng;
        private System.Windows.Forms.ComboBox DropDownListMajorItem_Add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextboxMajorItemName_Ja;
        private System.Windows.Forms.Panel PanelDelete;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DropDownListSubItem_Delete;
        private System.Windows.Forms.ComboBox DropDownListMajorItem_Delete;
        private System.Windows.Forms.Label label4;
    }
}