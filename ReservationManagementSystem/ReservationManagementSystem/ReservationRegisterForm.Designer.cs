﻿namespace ReservationManagementSystem
{
    partial class ReservationRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationRegisterForm));
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.DateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.tableLayoutPanelExam = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxSubExam = new System.Windows.Forms.ComboBox();
            this.ComboBoxMajorExam = new System.Windows.Forms.ComboBox();
            this.labelMajorExam = new System.Windows.Forms.Label();
            this.labelSubExam = new System.Windows.Forms.Label();
            this.buttonAddExam = new System.Windows.Forms.Button();
            this.buttonRemoveExam = new System.Windows.Forms.Button();
            this.tableLayoutPanelExam.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonReserve
            // 
            resources.ApplyResources(this.ButtonReserve, "ButtonReserve");
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // DateTimePickerReservationDate
            // 
            resources.ApplyResources(this.DateTimePickerReservationDate, "DateTimePickerReservationDate");
            this.DateTimePickerReservationDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReservationDate.Name = "DateTimePickerReservationDate";
            this.DateTimePickerReservationDate.ValueChanged += new System.EventHandler(this.DateTimePickerReservationDate_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.Name = "LabelTitle";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.Name = "labelID";
            // 
            // tableLayoutPanelExam
            // 
            resources.ApplyResources(this.tableLayoutPanelExam, "tableLayoutPanelExam");
            this.tableLayoutPanelExam.Controls.Add(this.ComboBoxSubExam, 1, 1);
            this.tableLayoutPanelExam.Controls.Add(this.ComboBoxMajorExam, 1, 0);
            this.tableLayoutPanelExam.Controls.Add(this.labelMajorExam, 0, 0);
            this.tableLayoutPanelExam.Controls.Add(this.labelSubExam, 0, 1);
            this.tableLayoutPanelExam.Name = "tableLayoutPanelExam";
            // 
            // ComboBoxSubExam
            // 
            resources.ApplyResources(this.ComboBoxSubExam, "ComboBoxSubExam");
            this.ComboBoxSubExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubExam.FormattingEnabled = true;
            this.ComboBoxSubExam.Name = "ComboBoxSubExam";
            // 
            // ComboBoxMajorExam
            // 
            resources.ApplyResources(this.ComboBoxMajorExam, "ComboBoxMajorExam");
            this.ComboBoxMajorExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMajorExam.FormattingEnabled = true;
            this.ComboBoxMajorExam.Name = "ComboBoxMajorExam";
            this.ComboBoxMajorExam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMajorExam_SelectedIndexChanged);
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
            // ReservationRegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemoveExam);
            this.Controls.Add(this.buttonAddExam);
            this.Controls.Add(this.tableLayoutPanelExam);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.DateTimePickerReservationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LabelTitle);
            this.Name = "ReservationRegisterForm";
            this.tableLayoutPanelExam.ResumeLayout(false);
            this.tableLayoutPanelExam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.DateTimePicker DateTimePickerReservationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExam;
        private System.Windows.Forms.ComboBox ComboBoxSubExam;
        private System.Windows.Forms.Label labelSubExam;
        private System.Windows.Forms.ComboBox ComboBoxMajorExam;
        private System.Windows.Forms.Label labelMajorExam;
        private System.Windows.Forms.Button buttonAddExam;
        private System.Windows.Forms.Button buttonRemoveExam;
    }
}