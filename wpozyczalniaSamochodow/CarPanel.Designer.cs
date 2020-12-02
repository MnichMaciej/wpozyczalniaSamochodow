namespace wpozyczalniaSamochodow
{
    partial class CarPanel
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.addingCarButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.goBackButton);
            this.menuPanel.Controls.Add(this.addingCarButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 601);
            this.menuPanel.TabIndex = 0;
            // 
            // addingCarButton
            // 
            this.addingCarButton.Location = new System.Drawing.Point(32, 61);
            this.addingCarButton.Name = "addingCarButton";
            this.addingCarButton.Size = new System.Drawing.Size(138, 23);
            this.addingCarButton.TabIndex = 0;
            this.addingCarButton.Text = "Dodaj samochód";
            this.addingCarButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(505, 601);
            this.mainPanel.TabIndex = 1;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(32, 102);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(138, 23);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "Powrót";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBack);
            // 
            // CarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "CarPanel";
            this.Size = new System.Drawing.Size(705, 601);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addingCarButton;
        private System.Windows.Forms.Button goBackButton;
    }
}
