namespace wypozyczalniaSamochodow
{
    partial class CarReturnPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reservationTable = new System.Windows.Forms.DataGridView();
            this.reservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReturnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 593);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(50, 120);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 25);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Powrót";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.goBack);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reservationTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(171, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 593);
            this.panel2.TabIndex = 1;
            // 
            // reservationTable
            // 
            this.reservationTable.AllowUserToAddRows = false;
            this.reservationTable.AllowUserToDeleteRows = false;
            this.reservationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationId,
            this.brand,
            this.model,
            this.carNumber,
            this.dateBegin,
            this.dateEnd,
            this.carReturnButton});
            this.reservationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationTable.Location = new System.Drawing.Point(0, 0);
            this.reservationTable.Name = "reservationTable";
            this.reservationTable.ReadOnly = true;
            this.reservationTable.Size = new System.Drawing.Size(1031, 593);
            this.reservationTable.TabIndex = 0;
            this.reservationTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationTable_CellContentClick);
            // 
            // reservationId
            // 
            this.reservationId.HeaderText = "ID:";
            this.reservationId.Name = "reservationId";
            this.reservationId.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.HeaderText = "Marka:";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Model:";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // carNumber
            // 
            this.carNumber.HeaderText = "Numer rejestracyjny:";
            this.carNumber.Name = "carNumber";
            this.carNumber.ReadOnly = true;
            // 
            // dateBegin
            // 
            this.dateBegin.HeaderText = "Data rozpoczęcia:";
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.ReadOnly = true;
            // 
            // dateEnd
            // 
            this.dateEnd.HeaderText = "Data zakończenia:";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.ReadOnly = true;
            // 
            // carReturnButton
            // 
            this.carReturnButton.HeaderText = "Oddaj pojazd";
            this.carReturnButton.Name = "carReturnButton";
            this.carReturnButton.ReadOnly = true;
            // 
            // CarReturnPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarReturnPanel";
            this.Size = new System.Drawing.Size(1202, 593);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView reservationTable;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnd;
        private System.Windows.Forms.DataGridViewButtonColumn carReturnButton;
    }
}
