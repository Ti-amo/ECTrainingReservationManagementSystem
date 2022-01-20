namespace ReservationManagementSystem
{
    partial class PatientRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegisterForm));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMajorExam = new System.Windows.Forms.Label();
            this.labelSubExam = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.DateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxMajorExam = new System.Windows.Forms.ComboBox();
            this.ComboBoxSubExam = new System.Windows.Forms.ComboBox();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.tableLayoutPanelExam = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddExam = new System.Windows.Forms.Button();
            this.buttonRemoveExam = new System.Windows.Forms.Button();
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelExam.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.Name = "LabelTitle";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // labelMajorExam
            // 
            resources.ApplyResources(this.labelMajorExam, "labelMajorExam");
            this.labelMajorExam.Name = "labelMajorExam";
            // 
            // labelSubExam
            // 
            resources.ApplyResources(this.labelSubExam, "labelSubExam");
            this.labelSubExam.Name = "labelSubExam";
            // 
            // TextBoxName
            // 
            resources.ApplyResources(this.TextBoxName, "TextBoxName");
            this.TextBoxName.Name = "TextBoxName";
            // 
            // DateTimePickerReservationDate
            // 
            resources.ApplyResources(this.DateTimePickerReservationDate, "DateTimePickerReservationDate");
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            // 
            // ComboBoxMajorExam
            // 
            this.ComboBoxMajorExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboBoxMajorExam, "ComboBoxMajorExam");
            this.ComboBoxMajorExam.FormattingEnabled = true;
            this.ComboBoxMajorExam.Name = "ComboBoxMajorExam";
            this.ComboBoxMajorExam.SelectedIndexChanged += new System.EventHandler(this.MajorExamChanged);
            // 
            // ComboBoxSubExam
            // 
            this.ComboBoxSubExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboBoxSubExam, "ComboBoxSubExam");
            this.ComboBoxSubExam.FormattingEnabled = true;
            this.ComboBoxSubExam.Name = "ComboBoxSubExam";
            // 
            // ButtonReserve
            // 
            resources.ApplyResources(this.ButtonReserve, "ButtonReserve");
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // tableLayoutPanelExam
            // 
            resources.ApplyResources(this.tableLayoutPanelExam, "tableLayoutPanelExam");
            this.tableLayoutPanelExam.Controls.Add(this.ComboBoxSubExam, 1, 1);
            this.tableLayoutPanelExam.Controls.Add(this.labelSubExam, 0, 1);
            this.tableLayoutPanelExam.Controls.Add(this.ComboBoxMajorExam, 1, 0);
            this.tableLayoutPanelExam.Controls.Add(this.labelMajorExam, 0, 0);
            this.tableLayoutPanelExam.Name = "tableLayoutPanelExam";
            // 
            // buttonAddExam
            // 
            resources.ApplyResources(this.buttonAddExam, "buttonAddExam");
            this.buttonAddExam.Name = "buttonAddExam";
            this.buttonAddExam.UseVisualStyleBackColor = true;
            this.buttonAddExam.Click += new System.EventHandler(this.buttonAddExam_Click);
            // 
            // buttonRemoveExam
            // 
            resources.ApplyResources(this.buttonRemoveExam, "buttonRemoveExam");
            this.buttonRemoveExam.Name = "buttonRemoveExam";
            this.buttonRemoveExam.UseVisualStyleBackColor = true;
            this.buttonRemoveExam.Click += new System.EventHandler(this.buttonRemoveExam_Click);
            // 
            // DateTimePickerBirthDate
            // 
            resources.ApplyResources(this.DateTimePickerBirthDate, "DateTimePickerBirthDate");
            this.DateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            // 
            // PatientRegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateTimePickerBirthDate);
            this.Controls.Add(this.buttonRemoveExam);
            this.Controls.Add(this.buttonAddExam);
            this.Controls.Add(this.tableLayoutPanelExam);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.DateTimePickerReservationDate);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTitle);
            this.Name = "PatientRegisterForm";
            this.tableLayoutPanelExam.ResumeLayout(false);
            this.tableLayoutPanelExam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMajorExam;
        private System.Windows.Forms.Label labelSubExam;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker DateTimePickerReservationDate;
        private System.Windows.Forms.ComboBox ComboBoxMajorExam;
        private System.Windows.Forms.ComboBox ComboBoxSubExam;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExam;
        private System.Windows.Forms.Button buttonAddExam;
        private System.Windows.Forms.Button buttonRemoveExam;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirthDate;
    }
}