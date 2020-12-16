namespace wypozyczalniaSamochodow
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginPanel1 = new wypozyczalniaSamochodow.LoginPanel();
            this.adminClient1 = new wypozyczalniaSamochodow.AdminClient();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginPanel1);
            this.panel2.Controls.Add(this.adminClient1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // loginPanel1
            // 
            resources.ApplyResources(this.loginPanel1, "loginPanel1");
            this.loginPanel1.Name = "loginPanel1";
            // 
            // adminClient1
            // 
            resources.ApplyResources(this.adminClient1, "adminClient1");
            this.adminClient1.Name = "adminClient1";
            // 
            // App
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panel2);
            this.Name = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private LoginPanel loginPanel1;
        private AdminClient adminClient1;
    }
}

