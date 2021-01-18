namespace wypozyczalniaSamochodow
{
    partial class RegistrationPanel
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.houseNumberLabel = new System.Windows.Forms.Label();
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNumberLabel = new System.Windows.Forms.Label();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.BackToLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(30, 40);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Imie:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(140, 35);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Click += new System.EventHandler(this.firstNameTextBox_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(30, 75);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Nazwisko:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(140, 70);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.Click += new System.EventHandler(this.lastNameTextBox_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(30, 110);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(41, 13);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "Miasto:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(140, 105);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(120, 20);
            this.cityTextBox.TabIndex = 5;
            this.cityTextBox.Click += new System.EventHandler(this.cityTextBox_Click);
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(30, 145);
            this.adressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(34, 13);
            this.adressLabel.TabIndex = 6;
            this.adressLabel.Text = "Ulica:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(140, 140);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(120, 20);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.Click += new System.EventHandler(this.addressTextBox_Click);
            // 
            // houseNumberLabel
            // 
            this.houseNumberLabel.AutoSize = true;
            this.houseNumberLabel.Location = new System.Drawing.Point(30, 180);
            this.houseNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.houseNumberLabel.Name = "houseNumberLabel";
            this.houseNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.houseNumberLabel.TabIndex = 8;
            this.houseNumberLabel.Text = "Numer domu:";
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.Location = new System.Drawing.Point(140, 175);
            this.houseNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.houseNumberTextBox.TabIndex = 9;
            this.houseNumberTextBox.Click += new System.EventHandler(this.houseNumberTextBox_Click);
            // 
            // apartmentNumberLabel
            // 
            this.apartmentNumberLabel.AutoSize = true;
            this.apartmentNumberLabel.Location = new System.Drawing.Point(30, 215);
            this.apartmentNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apartmentNumberLabel.Name = "apartmentNumberLabel";
            this.apartmentNumberLabel.Size = new System.Drawing.Size(96, 13);
            this.apartmentNumberLabel.TabIndex = 10;
            this.apartmentNumberLabel.Text = "Numer mieszkania:";
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(140, 210);
            this.apartmentNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.apartmentNumberTextBox.TabIndex = 11;
            this.apartmentNumberTextBox.Click += new System.EventHandler(this.apartmentNumberTextBox_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(30, 265);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(140, 260);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(120, 20);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(30, 300);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(37, 13);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Haslo:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.Location = new System.Drawing.Point(140, 295);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(120, 20);
            this.passwordTextBox.TabIndex = 15;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(150, 375);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(100, 30);
            this.RegistrationButton.TabIndex = 16;
            this.RegistrationButton.Text = "Zarejestruj";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.save);
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Location = new System.Drawing.Point(30, 335);
            this.passwordLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(76, 13);
            this.passwordLabel2.TabIndex = 17;
            this.passwordLabel2.Text = "Powtorz haslo:";
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(140, 330);
            this.passwordTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '●';
            this.passwordTextBox2.Size = new System.Drawing.Size(120, 20);
            this.passwordTextBox2.TabIndex = 18;
            this.passwordTextBox2.Click += new System.EventHandler(this.passwordTextBox2_Click);
            // 
            // BackToLoginButton
            // 
            this.BackToLoginButton.Location = new System.Drawing.Point(40, 375);
            this.BackToLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackToLoginButton.Name = "BackToLoginButton";
            this.BackToLoginButton.Size = new System.Drawing.Size(80, 30);
            this.BackToLoginButton.TabIndex = 19;
            this.BackToLoginButton.Text = "Powrót";
            this.BackToLoginButton.UseVisualStyleBackColor = true;
            this.BackToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // RegistrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackToLoginButton);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(this.apartmentNumberLabel);
            this.Controls.Add(this.houseNumberTextBox);
            this.Controls.Add(this.houseNumberLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationPanel";
            this.Size = new System.Drawing.Size(520, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label houseNumberLabel;
        private System.Windows.Forms.TextBox houseNumberTextBox;
        private System.Windows.Forms.Label apartmentNumberLabel;
        private System.Windows.Forms.TextBox apartmentNumberTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Button BackToLoginButton;
    }
}
