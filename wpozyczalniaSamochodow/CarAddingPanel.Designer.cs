namespace wypozyczalniaSamochodow
{
    partial class CarAddingPanel
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
            this.odometerTextBox = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.isDisabledCheckBox = new System.Windows.Forms.CheckBox();
            this.efficiencyCheckBox = new System.Windows.Forms.CheckBox();
            this.imageUrlTextBox = new System.Windows.Forms.TextBox();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.imageUrlLabel = new System.Windows.Forms.Label();
            this.isDisabledLabel = new System.Windows.Forms.Label();
            this.efficiencyLabel = new System.Windows.Forms.Label();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.odometerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odometerTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // odometerTextBox
            // 
            this.odometerTextBox.Location = new System.Drawing.Point(240, 190);
            this.odometerTextBox.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.odometerTextBox.Name = "odometerTextBox";
            this.odometerTextBox.Size = new System.Drawing.Size(120, 20);
            this.odometerTextBox.TabIndex = 39;
            this.odometerTextBox.ThousandsSeparator = true;
            this.odometerTextBox.Click += new System.EventHandler(this.odometerTextBox_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(640, 195);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 37;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save);
            // 
            // isDisabledCheckBox
            // 
            this.isDisabledCheckBox.AutoSize = true;
            this.isDisabledCheckBox.Location = new System.Drawing.Point(240, 300);
            this.isDisabledCheckBox.Name = "isDisabledCheckBox";
            this.isDisabledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isDisabledCheckBox.TabIndex = 36;
            this.isDisabledCheckBox.UseVisualStyleBackColor = true;
            this.isDisabledCheckBox.Click += new System.EventHandler(this.isDisabledCheckBox_Click);
            // 
            // efficiencyCheckBox
            // 
            this.efficiencyCheckBox.AutoSize = true;
            this.efficiencyCheckBox.Location = new System.Drawing.Point(240, 265);
            this.efficiencyCheckBox.Name = "efficiencyCheckBox";
            this.efficiencyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.efficiencyCheckBox.TabIndex = 35;
            this.efficiencyCheckBox.UseVisualStyleBackColor = true;
            this.efficiencyCheckBox.Click += new System.EventHandler(this.efficiencyCheckBox_Click);
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(260, 330);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(100, 20);
            this.imageUrlTextBox.TabIndex = 34;
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Location = new System.Drawing.Point(260, 225);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.registrationNumberTextBox.TabIndex = 33;
            this.registrationNumberTextBox.Click += new System.EventHandler(this.registrationNumberTextBox_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(240, 155);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(120, 21);
            this.typeComboBox.TabIndex = 32;
            this.typeComboBox.Click += new System.EventHandler(this.typeComboBox_Click);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(260, 120);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 31;
            this.modelTextBox.Click += new System.EventHandler(this.modelTextBox_Click);
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.Color.White;
            this.brandTextBox.Location = new System.Drawing.Point(260, 85);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 30;
            this.brandTextBox.Click += new System.EventHandler(this.brandTextBox_Click);
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(90, 335);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(163, 13);
            this.imageUrlLabel.TabIndex = 29;
            this.imageUrlLabel.Text = "Zdjecie pogladowe: (opcjonalnie)";
            // 
            // isDisabledLabel
            // 
            this.isDisabledLabel.AutoSize = true;
            this.isDisabledLabel.Location = new System.Drawing.Point(90, 300);
            this.isDisabledLabel.Name = "isDisabledLabel";
            this.isDisabledLabel.Size = new System.Drawing.Size(65, 13);
            this.isDisabledLabel.TabIndex = 28;
            this.isDisabledLabel.Text = "Niesprawny:";
            // 
            // efficiencyLabel
            // 
            this.efficiencyLabel.AutoSize = true;
            this.efficiencyLabel.Location = new System.Drawing.Point(90, 265);
            this.efficiencyLabel.Name = "efficiencyLabel";
            this.efficiencyLabel.Size = new System.Drawing.Size(55, 13);
            this.efficiencyLabel.TabIndex = 27;
            this.efficiencyLabel.Text = "Dostepny:";
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Location = new System.Drawing.Point(90, 230);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(107, 13);
            this.registrationNumberLabel.TabIndex = 26;
            this.registrationNumberLabel.Text = "Tablica rejestracyjna:";
            // 
            // odometerLabel
            // 
            this.odometerLabel.AutoSize = true;
            this.odometerLabel.Location = new System.Drawing.Point(90, 195);
            this.odometerLabel.Name = "odometerLabel";
            this.odometerLabel.Size = new System.Drawing.Size(51, 13);
            this.odometerLabel.TabIndex = 25;
            this.odometerLabel.Text = "Przebieg:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(90, 160);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(28, 13);
            this.typeLabel.TabIndex = 24;
            this.typeLabel.Text = "Typ:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(90, 125);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(39, 13);
            this.modelLabel.TabIndex = 23;
            this.modelLabel.Text = "Model:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(90, 90);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(40, 13);
            this.brandLabel.TabIndex = 22;
            this.brandLabel.Text = "Marka:";
            // 
            // CarAddingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.odometerTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.isDisabledCheckBox);
            this.Controls.Add(this.efficiencyCheckBox);
            this.Controls.Add(this.imageUrlTextBox);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.imageUrlLabel);
            this.Controls.Add(this.isDisabledLabel);
            this.Controls.Add(this.efficiencyLabel);
            this.Controls.Add(this.registrationNumberLabel);
            this.Controls.Add(this.odometerLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandLabel);
            this.Name = "CarAddingPanel";
            this.Size = new System.Drawing.Size(1000, 450);
            ((System.ComponentModel.ISupportInitialize)(this.odometerTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown odometerTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox isDisabledCheckBox;
        private System.Windows.Forms.CheckBox efficiencyCheckBox;
        private System.Windows.Forms.TextBox imageUrlTextBox;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label imageUrlLabel;
        private System.Windows.Forms.Label isDisabledLabel;
        private System.Windows.Forms.Label efficiencyLabel;
        private System.Windows.Forms.Label registrationNumberLabel;
        private System.Windows.Forms.Label odometerLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
    }
}
