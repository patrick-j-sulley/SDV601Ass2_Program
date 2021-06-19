namespace SDV601Ass2_Program
{
    partial class FrmOtherCost
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
            this.TxtOtherDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudCostAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCostName
            // 
            this.TxtCostName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // TxtOtherDescription
            // 
            this.TxtOtherDescription.Location = new System.Drawing.Point(16, 132);
            this.TxtOtherDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtOtherDescription.MaxLength = 100;
            this.TxtOtherDescription.Name = "TxtOtherDescription";
            this.TxtOtherDescription.Size = new System.Drawing.Size(344, 22);
            this.TxtOtherDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name of Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cost Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description of Cost";
            // 
            // FrmOtherCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(377, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOtherDescription);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmOtherCost";
            this.Text = "Add Other Cost";
            this.Controls.SetChildIndex(this.TxtCostName, 0);
            this.Controls.SetChildIndex(this.NudCostAmount, 0);
            this.Controls.SetChildIndex(this.TxtOtherDescription, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NudCostAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOtherDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
