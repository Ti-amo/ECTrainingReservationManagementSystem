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
            this.ImageLogo = new System.Windows.Forms.PictureBox();
            this.ButtonPatientRegister = new System.Windows.Forms.Button();
            this.ButtonReservationList = new System.Windows.Forms.Button();
            this.ButtonPatientList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageLogo
            // 
            this.ImageLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImageLogo.BackColor = System.Drawing.Color.Transparent;
            this.ImageLogo.Image = global::ReservationManagementSystem.Properties.Resources.Boom;
            this.ImageLogo.Location = new System.Drawing.Point(212, 4);
            this.ImageLogo.Margin = new System.Windows.Forms.Padding(0);
            this.ImageLogo.Name = "ImageLogo";
            this.ImageLogo.Size = new System.Drawing.Size(449, 153);
            this.ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageLogo.TabIndex = 0;
            this.ImageLogo.TabStop = false;
            // 
            // ButtonPatientRegister
            // 
            this.ButtonPatientRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonPatientRegister.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPatientRegister.Location = new System.Drawing.Point(348, 276);
            this.ButtonPatientRegister.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPatientRegister.Name = "ButtonPatientRegister";
            this.ButtonPatientRegister.Size = new System.Drawing.Size(177, 55);
            this.ButtonPatientRegister.TabIndex = 2;
            this.ButtonPatientRegister.Text = "患者登録";
            this.ButtonPatientRegister.UseVisualStyleBackColor = true;
            this.ButtonPatientRegister.Click += new System.EventHandler(this.ButtonPatientRegister_Click);
            // 
            // ButtonReservationList
            // 
            this.ButtonReservationList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonReservationList.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReservationList.Location = new System.Drawing.Point(348, 363);
            this.ButtonReservationList.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonReservationList.Name = "ButtonReservationList";
            this.ButtonReservationList.Size = new System.Drawing.Size(177, 55);
            this.ButtonReservationList.TabIndex = 3;
            this.ButtonReservationList.Text = "本日の予約";
            this.ButtonReservationList.UseVisualStyleBackColor = true;
            this.ButtonReservationList.Click += new System.EventHandler(this.ButtonReservationList_Click);
            // 
            // ButtonPatientList
            // 
            this.ButtonPatientList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonPatientList.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPatientList.Location = new System.Drawing.Point(348, 188);
            this.ButtonPatientList.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPatientList.Name = "ButtonPatientList";
            this.ButtonPatientList.Size = new System.Drawing.Size(177, 55);
            this.ButtonPatientList.TabIndex = 1;
            this.ButtonPatientList.Text = "患者一覧";
            this.ButtonPatientList.UseVisualStyleBackColor = true;
            this.ButtonPatientList.Click += new System.EventHandler(this.ButtonPatientList_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ImageLogo);
            this.panel2.Controls.Add(this.ButtonReservationList);
            this.panel2.Controls.Add(this.ButtonPatientRegister);
            this.panel2.Controls.Add(this.ButtonPatientList);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 448);
            this.panel2.TabIndex = 5;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 449);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ImageLogo;
        private System.Windows.Forms.Button ButtonPatientRegister;
        private System.Windows.Forms.Button ButtonReservationList;
        private System.Windows.Forms.Button ButtonPatientList;
        private System.Windows.Forms.Panel panel2;
    }
}

