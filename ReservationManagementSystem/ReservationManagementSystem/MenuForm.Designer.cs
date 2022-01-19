namespace ReservationManagementSystem
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.ButtonPatientRegister = new System.Windows.Forms.Button();
            this.ButtonReservationList = new System.Windows.Forms.Button();
            this.ButtonPatientList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonExam = new System.Windows.Forms.Button();
            this.ButtonLanguage = new System.Windows.Forms.Button();
            this.ImageLogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPatientRegister
            // 
            resources.ApplyResources(this.ButtonPatientRegister, "ButtonPatientRegister");
            this.ButtonPatientRegister.Name = "ButtonPatientRegister";
            this.ButtonPatientRegister.UseVisualStyleBackColor = true;
            this.ButtonPatientRegister.Click += new System.EventHandler(this.ButtonPatientRegister_Click);
            // 
            // ButtonReservationList
            // 
            resources.ApplyResources(this.ButtonReservationList, "ButtonReservationList");
            this.ButtonReservationList.Name = "ButtonReservationList";
            this.ButtonReservationList.UseVisualStyleBackColor = true;
            this.ButtonReservationList.Click += new System.EventHandler(this.ButtonReservationList_Click);
            // 
            // ButtonPatientList
            // 
            resources.ApplyResources(this.ButtonPatientList, "ButtonPatientList");
            this.ButtonPatientList.Name = "ButtonPatientList";
            this.ButtonPatientList.UseVisualStyleBackColor = true;
            this.ButtonPatientList.Click += new System.EventHandler(this.ButtonPatientList_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ButtonExam);
            this.panel2.Controls.Add(this.ButtonLanguage);
            this.panel2.Controls.Add(this.ImageLogo);
            this.panel2.Controls.Add(this.ButtonReservationList);
            this.panel2.Controls.Add(this.ButtonPatientRegister);
            this.panel2.Controls.Add(this.ButtonPatientList);
            this.panel2.Name = "panel2";
            // 
            // ButtonExam
            // 
            resources.ApplyResources(this.ButtonExam, "ButtonExam");
            this.ButtonExam.Name = "ButtonExam";
            this.ButtonExam.UseVisualStyleBackColor = true;
            this.ButtonExam.Click += new System.EventHandler(this.ButtonExam_Click);
            // 
            // ButtonLanguage
            // 
            resources.ApplyResources(this.ButtonLanguage, "ButtonLanguage");
            this.ButtonLanguage.Name = "ButtonLanguage";
            this.ButtonLanguage.UseVisualStyleBackColor = true;
            this.ButtonLanguage.Click += new System.EventHandler(this.ButtonLanguage_Click);
            // 
            // ImageLogo
            // 
            resources.ApplyResources(this.ImageLogo, "ImageLogo");
            this.ImageLogo.BackColor = System.Drawing.Color.Transparent;
            this.ImageLogo.Image = global::ReservationManagementSystem.Properties.Resources.Boom;
            this.ImageLogo.Name = "ImageLogo";
            this.ImageLogo.TabStop = false;
            // 
            // MenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ImageLogo;
        private System.Windows.Forms.Button ButtonPatientRegister;
        private System.Windows.Forms.Button ButtonReservationList;
        private System.Windows.Forms.Button ButtonPatientList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonLanguage;
        private System.Windows.Forms.Button ButtonExam;
    }
}

