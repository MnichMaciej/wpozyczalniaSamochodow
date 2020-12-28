namespace wypozyczalniaSamochodow
{
    partial class AdminClient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carPanelButton = new System.Windows.Forms.Button();
            this.reservationPanelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminReservationPanel1 = new wpozyczalniaSamochodow.AdminReservationPanel();
            this.carPanel1 = new wypozyczalniaSamochodow.CarPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carPanelButton
            // 
            this.carPanelButton.Location = new System.Drawing.Point(197, 304);
            this.carPanelButton.Margin = new System.Windows.Forms.Padding(4);
            this.carPanelButton.Name = "carPanelButton";
            this.carPanelButton.Size = new System.Drawing.Size(176, 28);
            this.carPanelButton.TabIndex = 0;
            this.carPanelButton.Text = "Samochody";
            this.carPanelButton.UseVisualStyleBackColor = true;
            this.carPanelButton.Click += new System.EventHandler(this.openCarPanel);
            // 
            // reservationPanelButton
            // 
            this.reservationPanelButton.Location = new System.Drawing.Point(1253, 304);
            this.reservationPanelButton.Margin = new System.Windows.Forms.Padding(4);
            this.reservationPanelButton.Name = "reservationPanelButton";
            this.reservationPanelButton.Size = new System.Drawing.Size(100, 28);
            this.reservationPanelButton.TabIndex = 1;
            this.reservationPanelButton.Text = "Rezerwacje";
            this.reservationPanelButton.UseVisualStyleBackColor = true;
            this.reservationPanelButton.Click += new System.EventHandler(this.openAdminReservationPanel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminReservationPanel1);
            this.panel1.Controls.Add(this.reservationPanelButton);
            this.panel1.Controls.Add(this.carPanelButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3357, 1456);
            this.panel1.TabIndex = 3;
            // 
            // adminReservationPanel1
            // 
            this.adminReservationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminReservationPanel1.Location = new System.Drawing.Point(0, 0);
            this.adminReservationPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.adminReservationPanel1.Name = "adminReservationPanel1";
            this.adminReservationPanel1.Size = new System.Drawing.Size(4196, 1820);
            this.adminReservationPanel1.TabIndex = 2;
            // 
            // carPanel1
            // 
            this.carPanel1.AutoSize = true;
            this.carPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carPanel1.Location = new System.Drawing.Point(0, 0);
            this.carPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.carPanel1.Name = "carPanel1";
            this.carPanel1.Size = new System.Drawing.Size(1609, 752);
            this.carPanel1.TabIndex = 2;
            // 
            // AdminClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.carPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminClient";
            this.Size = new System.Drawing.Size(3361, 1460);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button carPanelButton;
        private System.Windows.Forms.Button reservationPanelButton;
        private System.Windows.Forms.Panel panel1;
        private CarPanel carPanel1;
        private wpozyczalniaSamochodow.AdminReservationPanel adminReservationPanel1;
    }
}
