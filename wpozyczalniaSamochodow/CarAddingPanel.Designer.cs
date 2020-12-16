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
            this.odometerTextbox = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.isDisabledCheckbox = new System.Windows.Forms.CheckBox();
            this.efficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.imageUrlTextBox = new System.Windows.Forms.TextBox();
            this.registrationNumberTextbox = new System.Windows.Forms.TextBox();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.modelTextbox = new System.Windows.Forms.TextBox();
            this.brandTextbox = new System.Windows.Forms.TextBox();
            this.imageUrlLabel = new System.Windows.Forms.Label();
            this.isDisabledLabel = new System.Windows.Forms.Label();
            this.efficiencyLabel = new System.Windows.Forms.Label();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.odometerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odometerTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // odometerTextbox
            // 
            this.odometerTextbox.Location = new System.Drawing.Point(244, 195);
            this.odometerTextbox.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.odometerTextbox.Name = "odometerTextbox";
            this.odometerTextbox.Size = new System.Drawing.Size(120, 20);
            this.odometerTextbox.TabIndex = 39;
            this.odometerTextbox.ThousandsSeparator = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(644, 195);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 37;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save);
            // 
            // isDisabledCheckbox
            // 
            this.isDisabledCheckbox.AutoSize = true;
            this.isDisabledCheckbox.Location = new System.Drawing.Point(243, 289);
            this.isDisabledCheckbox.Name = "isDisabledCheckbox";
            this.isDisabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.isDisabledCheckbox.TabIndex = 36;
            this.isDisabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // efficiencyCheckbox
            // 
            this.efficiencyCheckbox.AutoSize = true;
            this.efficiencyCheckbox.Location = new System.Drawing.Point(243, 258);
            this.efficiencyCheckbox.Name = "efficiencyCheckbox";
            this.efficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.efficiencyCheckbox.TabIndex = 35;
            this.efficiencyCheckbox.UseVisualStyleBackColor = true;
            // 
            // imageUrlTextBox
            // 
            this.imageUrlTextBox.Location = new System.Drawing.Point(243, 314);
            this.imageUrlTextBox.Name = "imageUrlTextBox";
            this.imageUrlTextBox.Size = new System.Drawing.Size(100, 20);
            this.imageUrlTextBox.TabIndex = 34;
            // 
            // registrationNumberTextbox
            // 
            this.registrationNumberTextbox.Location = new System.Drawing.Point(243, 225);
            this.registrationNumberTextbox.Name = "registrationNumberTextbox";
            this.registrationNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.registrationNumberTextbox.TabIndex = 33;
            // 
            // typeCombobox
            // 
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Location = new System.Drawing.Point(243, 158);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(121, 21);
            this.typeCombobox.TabIndex = 32;
            // 
            // modelTextbox
            // 
            this.modelTextbox.Location = new System.Drawing.Point(243, 133);
            this.modelTextbox.Name = "modelTextbox";
            this.modelTextbox.Size = new System.Drawing.Size(100, 20);
            this.modelTextbox.TabIndex = 31;
            // 
            // brandTextbox
            // 
            this.brandTextbox.Location = new System.Drawing.Point(243, 102);
            this.brandTextbox.Name = "brandTextbox";
            this.brandTextbox.Size = new System.Drawing.Size(100, 20);
            this.brandTextbox.TabIndex = 30;
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Location = new System.Drawing.Point(86, 317);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(55, 13);
            this.imageUrlLabel.TabIndex = 29;
            this.imageUrlLabel.Text = "Image Url:";
            // 
            // isDisabledLabel
            // 
            this.isDisabledLabel.AutoSize = true;
            this.isDisabledLabel.Location = new System.Drawing.Point(90, 290);
            this.isDisabledLabel.Name = "isDisabledLabel";
            this.isDisabledLabel.Size = new System.Drawing.Size(60, 13);
            this.isDisabledLabel.TabIndex = 28;
            this.isDisabledLabel.Text = "Is disabled:";
            // 
            // efficiencyLabel
            // 
            this.efficiencyLabel.AutoSize = true;
            this.efficiencyLabel.Location = new System.Drawing.Point(90, 258);
            this.efficiencyLabel.Name = "efficiencyLabel";
            this.efficiencyLabel.Size = new System.Drawing.Size(56, 13);
            this.efficiencyLabel.TabIndex = 27;
            this.efficiencyLabel.Text = "Efficiency:";
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Location = new System.Drawing.Point(90, 228);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(104, 13);
            this.registrationNumberLabel.TabIndex = 26;
            this.registrationNumberLabel.Text = "Registration number:";
            // 
            // odometerLabel
            // 
            this.odometerLabel.AutoSize = true;
            this.odometerLabel.Location = new System.Drawing.Point(90, 198);
            this.odometerLabel.Name = "odometerLabel";
            this.odometerLabel.Size = new System.Drawing.Size(56, 13);
            this.odometerLabel.TabIndex = 25;
            this.odometerLabel.Text = "Odometer:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(90, 166);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 24;
            this.typeLabel.Text = "Type:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(90, 136);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(39, 13);
            this.modelLabel.TabIndex = 23;
            this.modelLabel.Text = "Model:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(90, 109);
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
            this.Controls.Add(this.odometerTextbox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.isDisabledCheckbox);
            this.Controls.Add(this.efficiencyCheckbox);
            this.Controls.Add(this.imageUrlTextBox);
            this.Controls.Add(this.registrationNumberTextbox);
            this.Controls.Add(this.typeCombobox);
            this.Controls.Add(this.modelTextbox);
            this.Controls.Add(this.brandTextbox);
            this.Controls.Add(this.imageUrlLabel);
            this.Controls.Add(this.isDisabledLabel);
            this.Controls.Add(this.efficiencyLabel);
            this.Controls.Add(this.registrationNumberLabel);
            this.Controls.Add(this.odometerLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandLabel);
            this.Name = "CarAddingPanel";
            this.Size = new System.Drawing.Size(1000, 448);
            ((System.ComponentModel.ISupportInitialize)(this.odometerTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown odometerTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox isDisabledCheckbox;
        private System.Windows.Forms.CheckBox efficiencyCheckbox;
        private System.Windows.Forms.TextBox imageUrlTextBox;
        private System.Windows.Forms.TextBox registrationNumberTextbox;
        private System.Windows.Forms.ComboBox typeCombobox;
        private System.Windows.Forms.TextBox modelTextbox;
        private System.Windows.Forms.TextBox brandTextbox;
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
