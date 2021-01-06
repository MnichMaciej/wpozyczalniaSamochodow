namespace wypozyczalniaSamochodow
{
    partial class CustomerClient
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
            this.CarReturnPanelButton = new System.Windows.Forms.Button();
            this.FinePanelButton = new System.Windows.Forms.Button();
            this.reservationPanelButton = new System.Windows.Forms.Button();
            this.CarRentalPanelButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.finePanel1 = new wypozyczalniaSamochodow.FinePanel();
            this.carReturnPanel1 = new wypozyczalniaSamochodow.CarReturnPanel();
            this.reservationPanel1 = new wypozyczalniaSamochodow.ReservationPanel();
            this.carRentalPanel1 = new wypozyczalniaSamochodow.CarRentalPanel();
            this.SuspendLayout();
            // 
            // CarReturnPanelButton
            // 
            this.CarReturnPanelButton.Location = new System.Drawing.Point(114, 154);
            this.CarReturnPanelButton.Name = "CarReturnPanelButton";
            this.CarReturnPanelButton.Size = new System.Drawing.Size(202, 66);
            this.CarReturnPanelButton.TabIndex = 0;
            this.CarReturnPanelButton.Text = "Panel zwrotu pojazdu";
            this.CarReturnPanelButton.UseVisualStyleBackColor = true;
            this.CarReturnPanelButton.Click += new System.EventHandler(this.CarReturnPanelButton_Click);
            // 
            // FinePanelButton
            // 
            this.FinePanelButton.Location = new System.Drawing.Point(114, 275);
            this.FinePanelButton.Name = "FinePanelButton";
            this.FinePanelButton.Size = new System.Drawing.Size(202, 69);
            this.FinePanelButton.TabIndex = 1;
            this.FinePanelButton.Text = "Panel Opłat";
            this.FinePanelButton.UseVisualStyleBackColor = true;
            this.FinePanelButton.Click += new System.EventHandler(this.FinePanelButton_Click);
            // 
            // reservationPanelButton
            // 
            this.reservationPanelButton.Location = new System.Drawing.Point(401, 154);
            this.reservationPanelButton.Name = "reservationPanelButton";
            this.reservationPanelButton.Size = new System.Drawing.Size(204, 66);
            this.reservationPanelButton.TabIndex = 2;
            this.reservationPanelButton.Text = "Panel rezerwacji";
            this.reservationPanelButton.UseVisualStyleBackColor = true;
            this.reservationPanelButton.Click += new System.EventHandler(this.reservationPanelButton_Click);
            // 
            // CarRentalPanelButton
            // 
            this.CarRentalPanelButton.Location = new System.Drawing.Point(401, 275);
            this.CarRentalPanelButton.Name = "CarRentalPanelButton";
            this.CarRentalPanelButton.Size = new System.Drawing.Size(204, 69);
            this.CarRentalPanelButton.TabIndex = 3;
            this.CarRentalPanelButton.Text = "Wypożycz samochód";
            this.CarRentalPanelButton.UseVisualStyleBackColor = true;
            this.CarRentalPanelButton.Click += new System.EventHandler(this.CarRentalPanelButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(114, 385);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(491, 55);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Wyloguj";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // finePanel1
            // 
            this.finePanel1.Location = new System.Drawing.Point(181, 385);
            this.finePanel1.Name = "finePanel1";
            this.finePanel1.Size = new System.Drawing.Size(150, 150);
            this.finePanel1.TabIndex = 7;
            // 
            // carReturnPanel1
            // 
            this.carReturnPanel1.Location = new System.Drawing.Point(0, 0);
            this.carReturnPanel1.Name = "carReturnPanel1";
            this.carReturnPanel1.Size = new System.Drawing.Size(150, 150);
            this.carReturnPanel1.TabIndex = 5;
            // 
            // reservationPanel1
            // 
            this.reservationPanel1.Location = new System.Drawing.Point(0, 0);
            this.reservationPanel1.Name = "reservationPanel1";
            this.reservationPanel1.Size = new System.Drawing.Size(1811, 781);
            this.reservationPanel1.TabIndex = 8;
            // 
            // carRentalPanel1
            // 
            this.carRentalPanel1.Location = new System.Drawing.Point(0, 0);
            this.carRentalPanel1.Name = "carRentalPanel1";
            this.carRentalPanel1.Size = new System.Drawing.Size(1454, 713);
            this.carRentalPanel1.TabIndex = 10;
            // 
            // CustomerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.carRentalPanel1);
            this.Controls.Add(this.finePanel1);
            this.Controls.Add(this.carReturnPanel1);
            this.Controls.Add(this.reservationPanel1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CarRentalPanelButton);
            this.Controls.Add(this.reservationPanelButton);
            this.Controls.Add(this.FinePanelButton);
            this.Controls.Add(this.CarReturnPanelButton);
            this.Name = "CustomerClient";
            this.Size = new System.Drawing.Size(4196, 1820);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarReturnPanelButton;
        private System.Windows.Forms.Button FinePanelButton;
        private System.Windows.Forms.Button reservationPanelButton;
        private System.Windows.Forms.Button CarRentalPanelButton;
        private CarReturnPanel carReturnPanel1;
        private FinePanel finePanel1;
        private ReservationPanel reservationPanel1;
        private System.Windows.Forms.Button LogOutButton;
        private CarRentalPanel carRentalPanel1;
    }
}