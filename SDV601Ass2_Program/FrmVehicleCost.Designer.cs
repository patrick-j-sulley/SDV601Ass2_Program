namespace SDV601Ass2_Program
{
    partial class FrmVehicleCost
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
            this.TxtVehicleDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVehicleDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudCostAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCostName
            // 
            this.TxtCostName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // TxtVehicleDesc
            // 
            this.TxtVehicleDesc.Location = new System.Drawing.Point(16, 134);
            this.TxtVehicleDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtVehicleDesc.MaxLength = 100;
            this.TxtVehicleDesc.Name = "TxtVehicleDesc";
            this.TxtVehicleDesc.Size = new System.Drawing.Size(344, 22);
            this.TxtVehicleDesc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type of Vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Charge Per KM";
            // 
            // TxtVehicleDescription
            // 
            this.TxtVehicleDescription.AutoSize = true;
            this.TxtVehicleDescription.Location = new System.Drawing.Point(12, 114);
            this.TxtVehicleDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtVehicleDescription.Name = "TxtVehicleDescription";
            this.TxtVehicleDescription.Size = new System.Drawing.Size(145, 17);
            this.TxtVehicleDescription.TabIndex = 8;
            this.TxtVehicleDescription.Text = "Description of Vehicle";
            // 
            // FrmVehicleCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(377, 244);
            this.Controls.Add(this.TxtVehicleDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtVehicleDesc);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmVehicleCost";
            this.Text = "Add Vehicle Cost";
            this.Controls.SetChildIndex(this.TxtCostName, 0);
            this.Controls.SetChildIndex(this.NudCostAmount, 0);
            this.Controls.SetChildIndex(this.TxtVehicleDesc, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtVehicleDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NudCostAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtVehicleDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtVehicleDescription;
    }
}
