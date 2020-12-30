namespace wypozyczalniaSamochodow
{
    partial class CarConditionPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.finePanel = new System.Windows.Forms.Panel();
            this.efficientCheckbox = new System.Windows.Forms.CheckBox();
            this.fineCheckbox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.finePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(87, 32);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(371, 245);
            this.description.TabIndex = 1;
            this.description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koszt:";
            // 
            // cost
            // 
            this.cost.DecimalPlaces = 2;
            this.cost.Location = new System.Drawing.Point(550, 27);
            this.cost.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(120, 22);
            this.cost.TabIndex = 3;
            this.cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cost.ThousandsSeparator = true;
            // 
            // finePanel
            // 
            this.finePanel.Controls.Add(this.description);
            this.finePanel.Controls.Add(this.cost);
            this.finePanel.Controls.Add(this.label1);
            this.finePanel.Controls.Add(this.label2);
            this.finePanel.Location = new System.Drawing.Point(44, 166);
            this.finePanel.Name = "finePanel";
            this.finePanel.Size = new System.Drawing.Size(710, 299);
            this.finePanel.TabIndex = 4;
            // 
            // efficientCheckbox
            // 
            this.efficientCheckbox.AutoSize = true;
            this.efficientCheckbox.Checked = true;
            this.efficientCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.efficientCheckbox.Location = new System.Drawing.Point(70, 45);
            this.efficientCheckbox.Name = "efficientCheckbox";
            this.efficientCheckbox.Size = new System.Drawing.Size(155, 21);
            this.efficientCheckbox.TabIndex = 5;
            this.efficientCheckbox.Text = "Pojazd jest sprawny";
            this.efficientCheckbox.UseVisualStyleBackColor = true;
            // 
            // fineCheckbox
            // 
            this.fineCheckbox.AutoSize = true;
            this.fineCheckbox.Location = new System.Drawing.Point(70, 115);
            this.fineCheckbox.Name = "fineCheckbox";
            this.fineCheckbox.Size = new System.Drawing.Size(60, 21);
            this.fineCheckbox.TabIndex = 6;
            this.fineCheckbox.Text = "Kara";
            this.fineCheckbox.UseVisualStyleBackColor = true;
            this.fineCheckbox.CheckedChanged += new System.EventHandler(this.fineCheckbox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(544, 75);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 35);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save);
            // 
            // CarConditionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fineCheckbox);
            this.Controls.Add(this.efficientCheckbox);
            this.Controls.Add(this.finePanel);
            this.Name = "CarConditionPanel";
            this.Size = new System.Drawing.Size(1615, 759);
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.finePanel.ResumeLayout(false);
            this.finePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cost;
        private System.Windows.Forms.Panel finePanel;
        private System.Windows.Forms.CheckBox efficientCheckbox;
        private System.Windows.Forms.CheckBox fineCheckbox;
        private System.Windows.Forms.Button saveButton;
    }
}
