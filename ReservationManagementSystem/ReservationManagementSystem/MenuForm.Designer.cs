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
            this.ContainerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.ImageLogo = new System.Windows.Forms.PictureBox();
            this.ButtonPatientList = new System.Windows.Forms.Button();
            this.ButtonPatientRegister = new System.Windows.Forms.Button();
            this.ButtonReservationList = new System.Windows.Forms.Button();
            this.ContainerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerMenu
            // 
            this.ContainerMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContainerMenu.BackColor = System.Drawing.SystemColors.Control;
            this.ContainerMenu.ColumnCount = 1;
            this.ContainerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContainerMenu.Controls.Add(this.ImageLogo, 0, 0);
            this.ContainerMenu.Controls.Add(this.ButtonPatientRegister, 0, 2);
            this.ContainerMenu.Controls.Add(this.ButtonReservationList, 0, 3);
            this.ContainerMenu.Controls.Add(this.ButtonPatientList, 0, 1);
            this.ContainerMenu.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerMenu.Location = new System.Drawing.Point(141, 47);
            this.ContainerMenu.Margin = new System.Windows.Forms.Padding(0);
            this.ContainerMenu.Name = "ContainerMenu";
            this.ContainerMenu.RowCount = 4;
            this.ContainerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.ContainerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.ContainerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.ContainerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.ContainerMenu.Size = new System.Drawing.Size(319, 273);
            this.ContainerMenu.TabIndex = 4;
            // 
            // ImageLogo
            // 
            this.ImageLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageLogo.Image = global::ReservationManagementSystem.Properties.Resources.Boom;
            this.ImageLogo.Location = new System.Drawing.Point(0, 0);
            this.ImageLogo.Margin = new System.Windows.Forms.Padding(0);
            this.ImageLogo.Name = "ImageLogo";
            this.ImageLogo.Size = new System.Drawing.Size(319, 125);
            this.ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageLogo.TabIndex = 0;
            this.ImageLogo.TabStop = false;
            // 
            // ButtonPatientList
            // 
            this.ButtonPatientList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonPatientList.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPatientList.Location = new System.Drawing.Point(109, 134);
            this.ButtonPatientList.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPatientList.Name = "ButtonPatientList";
            this.ButtonPatientList.Size = new System.Drawing.Size(100, 30);
            this.ButtonPatientList.TabIndex = 1;
            this.ButtonPatientList.Text = "患者一覧";
            this.ButtonPatientList.UseVisualStyleBackColor = true;
            this.ButtonPatientList.Click += new System.EventHandler(this.ButtonPatientList_Click);
            // 
            // ButtonPatientRegister
            // 
            this.ButtonPatientRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonPatientRegister.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPatientRegister.Location = new System.Drawing.Point(109, 183);
            this.ButtonPatientRegister.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPatientRegister.Name = "ButtonPatientRegister";
            this.ButtonPatientRegister.Size = new System.Drawing.Size(100, 30);
            this.ButtonPatientRegister.TabIndex = 2;
            this.ButtonPatientRegister.Text = "患者登録";
            this.ButtonPatientRegister.UseVisualStyleBackColor = true;
            this.ButtonPatientRegister.Click += new System.EventHandler(this.ButtonPatientRegister_Click);
            // 
            // ButtonReservationList
            // 
            this.ButtonReservationList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonReservationList.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReservationList.Location = new System.Drawing.Point(109, 233);
            this.ButtonReservationList.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonReservationList.Name = "ButtonReservationList";
            this.ButtonReservationList.Size = new System.Drawing.Size(100, 30);
            this.ButtonReservationList.TabIndex = 3;
            this.ButtonReservationList.Text = "本日の予約";
            this.ButtonReservationList.UseVisualStyleBackColor = true;
            this.ButtonReservationList.Click += new System.EventHandler(this.ButtonReservationList_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ContainerMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ContainerMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContainerMenu;
        private System.Windows.Forms.PictureBox ImageLogo;
        private System.Windows.Forms.Button ButtonPatientRegister;
        private System.Windows.Forms.Button ButtonReservationList;
        private System.Windows.Forms.Button ButtonPatientList;
    }
}

