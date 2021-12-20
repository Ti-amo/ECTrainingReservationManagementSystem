
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelLine = new System.Windows.Forms.Label();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.TextboxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.ButtonReserve = new System.Windows.Forms.Button();
=======
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.DataGridViewReserveList = new System.Windows.Forms.DataGridView();
            this.LabelHistory = new System.Windows.Forms.Label();
            this.LabelPageNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReserveList)).BeginInit();
>>>>>>> 509cf71 (create patient detail info)
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelLine);
            this.panel1.Controls.Add(this.ButtonReserve);
            this.panel1.Controls.Add(this.TextboxDateOfBirth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextboxName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextboxId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 222);
            this.panel1.TabIndex = 0;
            // 
            // LabelLine
            // 
            this.LabelLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLine.AutoSize = true;
            this.LabelLine.Location = new System.Drawing.Point(49, 206);
            this.LabelLine.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLine.Name = "LabelLine";
            this.LabelLine.Size = new System.Drawing.Size(35, 13);
            this.LabelLine.TabIndex = 8;
            this.LabelLine.Text = "label6";
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReserve.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(644, 166);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(75, 30);
            this.ButtonReserve.TabIndex = 7;
            this.ButtonReserve.Text = "予約登録";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            // 
            // TextboxDateOfBirth
            // 
            this.TextboxDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxDateOfBirth.BackColor = System.Drawing.Color.White;
            this.TextboxDateOfBirth.Location = new System.Drawing.Point(414, 138);
            this.TextboxDateOfBirth.Name = "TextboxDateOfBirth";
            this.TextboxDateOfBirth.ReadOnly = true;
            this.TextboxDateOfBirth.Size = new System.Drawing.Size(140, 20);
            this.TextboxDateOfBirth.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "生年月日";
            // 
            // TextboxName
            // 
            this.TextboxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxName.BackColor = System.Drawing.Color.White;
            this.TextboxName.Location = new System.Drawing.Point(414, 102);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.ReadOnly = true;
            this.TextboxName.Size = new System.Drawing.Size(140, 20);
            this.TextboxName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "氏名";
            // 
            // TextboxId
            // 
            this.TextboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextboxId.BackColor = System.Drawing.Color.White;
            this.TextboxId.Location = new System.Drawing.Point(414, 66);
            this.TextboxId.Name = "TextboxId";
            this.TextboxId.ReadOnly = true;
            this.TextboxId.Size = new System.Drawing.Size(140, 20);
            this.TextboxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(502, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
=======
            this.label1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
>>>>>>> 509cf71 (create patient detail info)
            this.label1.TabIndex = 0;
            this.label1.Text = "患者情報";
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
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 274);
            this.panel2.TabIndex = 1;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNext.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(644, 231);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext.TabIndex = 4;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPrevious.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrevious.Location = new System.Drawing.Point(479, 231);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(75, 23);
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
            this.DataGridViewReserveList.Location = new System.Drawing.Point(50, 75);
            this.DataGridViewReserveList.Name = "DataGridViewReserveList";
            this.DataGridViewReserveList.Size = new System.Drawing.Size(669, 137);
            this.DataGridViewReserveList.TabIndex = 1;
            // 
            // LabelHistory
            // 
            this.LabelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelHistory.AutoSize = true;
            this.LabelHistory.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistory.Location = new System.Drawing.Point(335, 26);
            this.LabelHistory.Name = "LabelHistory";
            this.LabelHistory.Size = new System.Drawing.Size(98, 21);
            this.LabelHistory.TabIndex = 0;
            this.LabelHistory.Text = "診療履歴";
            // 
            // LabelPageNumber
            // 
            this.LabelPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPageNumber.AutoSize = true;
            this.LabelPageNumber.Location = new System.Drawing.Point(579, 238);
            this.LabelPageNumber.Name = "LabelPageNumber";
            this.LabelPageNumber.Size = new System.Drawing.Size(40, 16);
            this.LabelPageNumber.TabIndex = 5;
            this.LabelPageNumber.Text = "1/10";
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Location = new System.Drawing.Point(937, 451);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(155, 51);
            this.ButtonReserve.TabIndex = 1;
            this.ButtonReserve.Text = "予約登録";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // PatientDetailInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
=======
            this.ClientSize = new System.Drawing.Size(769, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
>>>>>>> 509cf71 (create patient detail info)
            this.Name = "PatientDetailInfoForm";
            this.Text = "PatientDetailInfoForm";
            this.Load += new System.EventHandler(this.PatientDetailInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReserveList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.TextBox TextboxDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextboxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.DataGridView DataGridViewReserveList;
        private System.Windows.Forms.Label LabelHistory;
        private System.Windows.Forms.Label LabelLine;
        private System.Windows.Forms.Label LabelPageNumber;
    }
}