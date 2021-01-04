namespace wypozyczalniaSamochodow
{
    partial class ReservationPanel
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
            this.reservationTable = new System.Windows.Forms.DataGridView();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editReservationButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancelReservationButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 781);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(60, 203);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(92, 31);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Powrót";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.goBack);
            // 
            // reservationTable
            // 
            this.reservationTable.AllowUserToAddRows = false;
            this.reservationTable.AllowUserToDeleteRows = false;
            this.reservationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.model,
            this.brand,
            this.carNumber,
            this.dateBegin,
            this.dateEnd,
            this.editReservationButton,
            this.cancelReservationButton});
            this.reservationTable.Location = new System.Drawing.Point(228, 3);
            this.reservationTable.Name = "reservationTable";
            this.reservationTable.ReadOnly = true;
            this.reservationTable.RowHeadersWidth = 51;
            this.reservationTable.RowTemplate.Height = 24;
            this.reservationTable.Size = new System.Drawing.Size(1536, 778);
            this.reservationTable.TabIndex = 1;
            this.reservationTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationTable_CellContentClick);
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 125;
            // 
            // brand
            // 
            this.brand.HeaderText = "Marka";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 125;
            // 
            // carNumber
            // 
            this.carNumber.HeaderText = "Numer rejestracyjny";
            this.carNumber.MinimumWidth = 6;
            this.carNumber.Name = "carNumber";
            this.carNumber.ReadOnly = true;
            this.carNumber.Width = 125;
            // 
            // dateBegin
            // 
            this.dateBegin.HeaderText = "Data rozpoczęcia";
            this.dateBegin.MinimumWidth = 6;
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.ReadOnly = true;
            this.dateBegin.Width = 125;
            // 
            // dateEnd
            // 
            this.dateEnd.HeaderText = "Data zakończenia";
            this.dateEnd.MinimumWidth = 6;
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.ReadOnly = true;
            this.dateEnd.Width = 125;
            // 
            // editReservationButton
            // 
            this.editReservationButton.HeaderText = "Edytuj";
            this.editReservationButton.MinimumWidth = 6;
            this.editReservationButton.Name = "editReservationButton";
            this.editReservationButton.ReadOnly = true;
            this.editReservationButton.Width = 125;
            // 
            // cancelReservationButton
            // 
            this.cancelReservationButton.HeaderText = "Anuluj";
            this.cancelReservationButton.MinimumWidth = 6;
            this.cancelReservationButton.Name = "cancelReservationButton";
            this.cancelReservationButton.ReadOnly = true;
            this.cancelReservationButton.Width = 125;
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reservationTable);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationPanel";
            this.Size = new System.Drawing.Size(1764, 781);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView reservationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnd;
        private System.Windows.Forms.DataGridViewButtonColumn editReservationButton;
        private System.Windows.Forms.DataGridViewButtonColumn cancelReservationButton;
    }
}
