namespace SDV601Ass2_Program
{
    partial class FrmAddCost
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCostName = new System.Windows.Forms.TextBox();
            this.NudCostAmount = new System.Windows.Forms.NumericUpDown();
            this.BtnSaveCost = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudCostAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCostName
            // 
            this.TxtCostName.Location = new System.Drawing.Point(16, 31);
            this.TxtCostName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCostName.MaxLength = 100;
            this.TxtCostName.Name = "TxtCostName";
            this.TxtCostName.Size = new System.Drawing.Size(344, 22);
            this.TxtCostName.TabIndex = 0;
            // 
            // NudCostAmount
            // 
            this.NudCostAmount.DecimalPlaces = 2;
            this.NudCostAmount.Location = new System.Drawing.Point(16, 82);
            this.NudCostAmount.Margin = new System.Windows.Forms.Padding(4);
            this.NudCostAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudCostAmount.Name = "NudCostAmount";
            this.NudCostAmount.Size = new System.Drawing.Size(345, 22);
            this.NudCostAmount.TabIndex = 1;
            // 
            // BtnSaveCost
            // 
            this.BtnSaveCost.Location = new System.Drawing.Point(16, 201);
            this.BtnSaveCost.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveCost.Name = "BtnSaveCost";
            this.BtnSaveCost.Size = new System.Drawing.Size(100, 28);
            this.BtnSaveCost.TabIndex = 3;
            this.BtnSaveCost.Text = "Save Cost";
            this.BtnSaveCost.UseVisualStyleBackColor = true;
            this.BtnSaveCost.Click += new System.EventHandler(this.BtnSaveCost_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(261, 201);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 28);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmAddCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 244);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSaveCost);
            this.Controls.Add(this.NudCostAmount);
            this.Controls.Add(this.TxtCostName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddCost";
            this.Text = "FrmAddCost";
            ((System.ComponentModel.ISupportInitialize)(this.NudCostAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSaveCost;
        private System.Windows.Forms.Button BtnCancel;
        protected System.Windows.Forms.NumericUpDown NudCostAmount;
        protected System.Windows.Forms.TextBox TxtCostName;
    }
}