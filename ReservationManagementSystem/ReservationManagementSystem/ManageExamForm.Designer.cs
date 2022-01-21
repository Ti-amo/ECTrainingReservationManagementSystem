
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageExamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.ToggleButtonStatus = new ReservationManagementSystem.ToggleButton();
            this.SuspendLayout();
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
            // PanelContainer
            // 
            resources.ApplyResources(this.PanelContainer, "PanelContainer");
            this.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelContainer.Name = "PanelContainer";
            // 
            // ToggleButtonStatus
            // 
            resources.ApplyResources(this.ToggleButtonStatus, "ToggleButtonStatus");
            this.ToggleButtonStatus.Name = "ToggleButtonStatus";
            this.ToggleButtonStatus.OffBackColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.OffToggleColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.OnBackColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.OnToggleColor = System.Drawing.Color.Black;
            this.ToggleButtonStatus.SolidStyle = false;
            this.ToggleButtonStatus.UseVisualStyleBackColor = true;
            this.ToggleButtonStatus.CheckedChanged += new System.EventHandler(this.ToggleButtonStatus_CheckedChanged);
            // 
            // ManageExamForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.ToggleButtonStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageExamForm";
            this.Load += new System.EventHandler(this.ManageExamForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ToggleButton ToggleButtonStatus;
        private System.Windows.Forms.Panel PanelContainer;
    }
}