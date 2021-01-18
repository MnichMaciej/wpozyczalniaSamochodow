namespace wypozyczalniaSamochodow
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.addingCarButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.carsTable = new System.Windows.Forms.DataGridView();
            this.carEditingPanel1 = new wypozyczalniaSamochodow.CarEditingPanel();
            this.carAddingPanel1 = new wypozyczalniaSamochodow.CarAddingPanel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiency = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDisabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editCarButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.goBackButton);
            this.menuPanel.Controls.Add(this.addingCarButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(217, 611);
            this.menuPanel.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(30, 100);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(138, 23);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "Powrót";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBack);
            // 
            // addingCarButton
            // 
            this.addingCarButton.Location = new System.Drawing.Point(30, 60);
            this.addingCarButton.Name = "addingCarButton";
            this.addingCarButton.Size = new System.Drawing.Size(138, 23);
            this.addingCarButton.TabIndex = 0;
            this.addingCarButton.Text = "Dodaj samochód";
            this.addingCarButton.UseVisualStyleBackColor = true;
            this.addingCarButton.Click += new System.EventHandler(this.addCar);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.carsTable);
            this.mainPanel.Controls.Add(this.carEditingPanel1);
            this.mainPanel.Controls.Add(this.carAddingPanel1);
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1436, 706);
            this.mainPanel.TabIndex = 1;
            // 
            // carsTable
            // 
            this.carsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.carsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.brand,
            this.model,
            this.type,
            this.odometer,
            this.registrationNumber,
            this.efficiency,
            this.isDisabled,
            this.editCarButton});
            this.carsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsTable.Location = new System.Drawing.Point(0, 0);
            this.carsTable.Name = "carsTable";
            this.carsTable.RowHeadersWidth = 51;
            this.carsTable.Size = new System.Drawing.Size(1436, 706);
            this.carsTable.TabIndex = 0;
            this.carsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsTable_CellContentClick);
            // 
            // carEditingPanel1
            // 
            this.carEditingPanel1.AutoSize = true;
            this.carEditingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carEditingPanel1.Location = new System.Drawing.Point(0, 0);
            this.carEditingPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.carEditingPanel1.Name = "carEditingPanel1";
            this.carEditingPanel1.Size = new System.Drawing.Size(1436, 706);
            this.carEditingPanel1.TabIndex = 1;
            this.carEditingPanel1.Visible = false;
            // 
            // carAddingPanel1
            // 
            this.carAddingPanel1.AutoSize = true;
            this.carAddingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carAddingPanel1.Location = new System.Drawing.Point(0, 0);
            this.carAddingPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.carAddingPanel1.Name = "carAddingPanel1";
            this.carAddingPanel1.Size = new System.Drawing.Size(1436, 706);
            this.carAddingPanel1.TabIndex = 2;
            this.carAddingPanel1.Visible = false;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID:";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 46;
            // 
            // brand
            // 
            this.brand.Frozen = true;
            this.brand.HeaderText = "Marka:";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 65;
            // 
            // model
            // 
            this.model.Frozen = true;
            this.model.HeaderText = "Model:";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 64;
            // 
            // type
            // 
            this.type.Frozen = true;
            this.type.HeaderText = "Typ:";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 53;
            // 
            // odometer
            // 
            this.odometer.Frozen = true;
            this.odometer.HeaderText = "Przebieg:";
            this.odometer.MinimumWidth = 6;
            this.odometer.Name = "odometer";
            this.odometer.ReadOnly = true;
            this.odometer.Width = 76;
            // 
            // registrationNumber
            // 
            this.registrationNumber.Frozen = true;
            this.registrationNumber.HeaderText = "Tablica rejestracyjna:";
            this.registrationNumber.MinimumWidth = 6;
            this.registrationNumber.Name = "registrationNumber";
            this.registrationNumber.ReadOnly = true;
            this.registrationNumber.Width = 121;
            // 
            // efficiency
            // 
            this.efficiency.Frozen = true;
            this.efficiency.HeaderText = "Dostepny:";
            this.efficiency.MinimumWidth = 6;
            this.efficiency.Name = "efficiency";
            this.efficiency.ReadOnly = true;
            this.efficiency.Width = 61;
            // 
            // isDisabled
            // 
            this.isDisabled.HeaderText = "Niesprawny:";
            this.isDisabled.MinimumWidth = 6;
            this.isDisabled.Name = "isDisabled";
            this.isDisabled.ReadOnly = true;
            this.isDisabled.Width = 71;
            // 
            // editCarButton
            // 
            this.editCarButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.editCarButton.HeaderText = "Edytuj:";
            this.editCarButton.MinimumWidth = 6;
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Text = "Edytuj";
            this.editCarButton.ToolTipText = "Edytuj";
            this.editCarButton.UseColumnTextForButtonValue = true;
            // 
            // CarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "CarPanel";
            this.Size = new System.Drawing.Size(1207, 611);
            this.menuPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addingCarButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridView carsTable;
        private CarEditingPanel carEditingPanel1;
        private CarAddingPanel carAddingPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn efficiency;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDisabled;
        private System.Windows.Forms.DataGridViewButtonColumn editCarButton;
    }
}
