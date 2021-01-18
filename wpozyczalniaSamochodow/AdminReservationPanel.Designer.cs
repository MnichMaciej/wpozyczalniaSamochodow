namespace wypozyczalniaSamochodow
{
    partial class AdminReservationPanel
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
            this.reservationTable = new System.Windows.Forms.DataGridView();
            this.carConditionPanel1 = new wypozyczalniaSamochodow.CarConditionPanel();
            this.reservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.carConditionButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.goBackButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 610);
            this.menuPanel.TabIndex = 1;
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
            // reservationTable
            // 
            this.reservationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reservationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationId,
            this.brand,
            this.model,
            this.carNumber,
            this.type,
            this.dateBegin,
            this.dateEnd,
            this.ended,
            this.fine,
            this._checked,
            this.carConditionButton});
            this.reservationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationTable.Location = new System.Drawing.Point(200, 0);
            this.reservationTable.Name = "reservationTable";
            this.reservationTable.RowHeadersWidth = 51;
            this.reservationTable.Size = new System.Drawing.Size(1278, 610);
            this.reservationTable.TabIndex = 2;
            this.reservationTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationTable_CellContentClick);
            // 
            // carConditionPanel1
            // 
            this.carConditionPanel1.Location = new System.Drawing.Point(200, 0);
            this.carConditionPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.carConditionPanel1.Name = "carConditionPanel1";
            this.carConditionPanel1.Size = new System.Drawing.Size(1278, 610);
            this.carConditionPanel1.TabIndex = 3;
            // 
            // reservationId
            // 
            this.reservationId.HeaderText = "ID:";
            this.reservationId.MinimumWidth = 6;
            this.reservationId.Name = "reservationId";
            this.reservationId.ReadOnly = true;
            this.reservationId.Width = 46;
            // 
            // brand
            // 
            this.brand.HeaderText = "Marka:";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.Width = 65;
            // 
            // model
            // 
            this.model.HeaderText = "Model:";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.Width = 64;
            // 
            // carNumber
            // 
            this.carNumber.HeaderText = "Numer rejestracyjny pojazdu:";
            this.carNumber.MinimumWidth = 6;
            this.carNumber.Name = "carNumber";
            this.carNumber.ReadOnly = true;
            this.carNumber.Width = 152;
            // 
            // type
            // 
            this.type.HeaderText = "Typ pojazdu:";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 86;
            // 
            // dateBegin
            // 
            this.dateBegin.HeaderText = "Data rozpoczęcia:";
            this.dateBegin.MinimumWidth = 6;
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.ReadOnly = true;
            this.dateBegin.Width = 108;
            // 
            // dateEnd
            // 
            this.dateEnd.HeaderText = "Data zakończenia:";
            this.dateEnd.MinimumWidth = 6;
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.ReadOnly = true;
            this.dateEnd.Width = 111;
            // 
            // ended
            // 
            this.ended.HeaderText = "Zakończona";
            this.ended.MinimumWidth = 6;
            this.ended.Name = "ended";
            this.ended.ReadOnly = true;
            this.ended.Width = 73;
            // 
            // fine
            // 
            this.fine.HeaderText = "Numer kary:";
            this.fine.MinimumWidth = 6;
            this.fine.Name = "fine";
            this.fine.ReadOnly = true;
            this.fine.Width = 82;
            // 
            // _checked
            // 
            this._checked.HeaderText = "Oceniono";
            this._checked.Name = "_checked";
            this._checked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._checked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._checked.Width = 78;
            // 
            // carConditionButton
            // 
            this.carConditionButton.HeaderText = "Oceń stan pojazdu";
            this.carConditionButton.MinimumWidth = 6;
            this.carConditionButton.Name = "carConditionButton";
            this.carConditionButton.Width = 92;
            // 
            // AdminReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reservationTable);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.carConditionPanel1);
            this.Name = "AdminReservationPanel";
            this.Size = new System.Drawing.Size(1478, 610);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridView reservationTable;
        private CarConditionPanel carConditionPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ended;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _checked;
        private System.Windows.Forms.DataGridViewButtonColumn carConditionButton;
    }
}
