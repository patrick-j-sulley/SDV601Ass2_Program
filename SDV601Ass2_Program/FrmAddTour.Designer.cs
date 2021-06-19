namespace SDV601Ass2_Program
{
    partial class FrmAddTour
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
            this.TxtTourCode = new System.Windows.Forms.TextBox();
            this.TxtTourName = new System.Windows.Forms.TextBox();
            this.DTStartDate = new System.Windows.Forms.DateTimePicker();
            this.DTEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbTourCosts = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAddCost = new System.Windows.Forms.Button();
            this.BtnEditCost = new System.Windows.Forms.Button();
            this.BtnRemCost = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CbCostType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblTourCost = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.LblPassengerPrice = new System.Windows.Forms.Label();
            this.NudMaxPass = new System.Windows.Forms.NumericUpDown();
            this.NudTravDist = new System.Windows.Forms.NumericUpDown();
            this.NudMarkUp = new System.Windows.Forms.NumericUpDown();
            this.O = new System.Windows.Forms.Label();
            this.LblOverallExpensesAmt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTravDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMarkUp)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTourCode
            // 
            this.TxtTourCode.Location = new System.Drawing.Point(124, 7);
            this.TxtTourCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTourCode.MaxLength = 15;
            this.TxtTourCode.Name = "TxtTourCode";
            this.TxtTourCode.Size = new System.Drawing.Size(369, 22);
            this.TxtTourCode.TabIndex = 0;
            // 
            // TxtTourName
            // 
            this.TxtTourName.Location = new System.Drawing.Point(124, 39);
            this.TxtTourName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTourName.MaxLength = 100;
            this.TxtTourName.Name = "TxtTourName";
            this.TxtTourName.Size = new System.Drawing.Size(369, 22);
            this.TxtTourName.TabIndex = 1;
            // 
            // DTStartDate
            // 
            this.DTStartDate.Location = new System.Drawing.Point(124, 66);
            this.DTStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTStartDate.Name = "DTStartDate";
            this.DTStartDate.Size = new System.Drawing.Size(369, 22);
            this.DTStartDate.TabIndex = 5;
            this.DTStartDate.ValueChanged += new System.EventHandler(this.DTStartDate_ValueChanged);
            // 
            // DTEndDate
            // 
            this.DTEndDate.Location = new System.Drawing.Point(124, 95);
            this.DTEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTEndDate.Name = "DTEndDate";
            this.DTEndDate.Size = new System.Drawing.Size(369, 22);
            this.DTEndDate.TabIndex = 6;
            this.DTEndDate.ValueChanged += new System.EventHandler(this.DTEndDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tour Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tour Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max Psngr Amt.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Travel Dist. (KM)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mark Up %";
            // 
            // LbTourCosts
            // 
            this.LbTourCosts.FormattingEnabled = true;
            this.LbTourCosts.ItemHeight = 16;
            this.LbTourCosts.Location = new System.Drawing.Point(12, 254);
            this.LbTourCosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbTourCosts.Name = "LbTourCosts";
            this.LbTourCosts.Size = new System.Drawing.Size(487, 116);
            this.LbTourCosts.TabIndex = 14;
            this.LbTourCosts.DoubleClick += new System.EventHandler(this.LbTourCosts_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cost";
            // 
            // BtnAddCost
            // 
            this.BtnAddCost.Location = new System.Drawing.Point(12, 375);
            this.BtnAddCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCost.Name = "BtnAddCost";
            this.BtnAddCost.Size = new System.Drawing.Size(123, 23);
            this.BtnAddCost.TabIndex = 19;
            this.BtnAddCost.Text = "Add New Cost";
            this.BtnAddCost.UseVisualStyleBackColor = true;
            this.BtnAddCost.Click += new System.EventHandler(this.BtnAddCost_Click);
            // 
            // BtnEditCost
            // 
            this.BtnEditCost.Location = new System.Drawing.Point(164, 375);
            this.BtnEditCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditCost.Name = "BtnEditCost";
            this.BtnEditCost.Size = new System.Drawing.Size(141, 23);
            this.BtnEditCost.TabIndex = 20;
            this.BtnEditCost.Text = "Edit Selected Cost";
            this.BtnEditCost.UseVisualStyleBackColor = true;
            this.BtnEditCost.Click += new System.EventHandler(this.BtnEditCost_Click);
            // 
            // BtnRemCost
            // 
            this.BtnRemCost.Location = new System.Drawing.Point(331, 375);
            this.BtnRemCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemCost.Name = "BtnRemCost";
            this.BtnRemCost.Size = new System.Drawing.Size(168, 23);
            this.BtnRemCost.TabIndex = 21;
            this.BtnRemCost.Text = "Remove Selected Cost";
            this.BtnRemCost.UseVisualStyleBackColor = true;
            this.BtnRemCost.Click += new System.EventHandler(this.BtnRemCost_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 532);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(253, 23);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Save Tour Settings and Exit";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbCostType
            // 
            this.CbCostType.FormattingEnabled = true;
            this.CbCostType.Location = new System.Drawing.Point(240, 415);
            this.CbCostType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbCostType.Name = "CbCostType";
            this.CbCostType.Size = new System.Drawing.Size(167, 24);
            this.CbCostType.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Select Cost Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 454);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Overall Tour Cost:";
            // 
            // LblTourCost
            // 
            this.LblTourCost.AutoSize = true;
            this.LblTourCost.Location = new System.Drawing.Point(268, 454);
            this.LblTourCost.Name = "LblTourCost";
            this.LblTourCost.Size = new System.Drawing.Size(52, 17);
            this.LblTourCost.TabIndex = 26;
            this.LblTourCost.Text = "$00.00";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(329, 532);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(165, 23);
            this.BtnCancel.TabIndex = 27;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 475);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Price Per Passenger:";
            // 
            // LblPassengerPrice
            // 
            this.LblPassengerPrice.AutoSize = true;
            this.LblPassengerPrice.Location = new System.Drawing.Point(268, 475);
            this.LblPassengerPrice.Name = "LblPassengerPrice";
            this.LblPassengerPrice.Size = new System.Drawing.Size(52, 17);
            this.LblPassengerPrice.TabIndex = 29;
            this.LblPassengerPrice.Text = "$00.00";
            // 
            // NudMaxPass
            // 
            this.NudMaxPass.Location = new System.Drawing.Point(124, 123);
            this.NudMaxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NudMaxPass.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NudMaxPass.Name = "NudMaxPass";
            this.NudMaxPass.Size = new System.Drawing.Size(371, 22);
            this.NudMaxPass.TabIndex = 30;
            this.NudMaxPass.ValueChanged += new System.EventHandler(this.NudMaxPass_ValueChanged);
            // 
            // NudTravDist
            // 
            this.NudTravDist.Location = new System.Drawing.Point(124, 151);
            this.NudTravDist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NudTravDist.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.NudTravDist.Name = "NudTravDist";
            this.NudTravDist.Size = new System.Drawing.Size(371, 22);
            this.NudTravDist.TabIndex = 31;
            this.NudTravDist.ValueChanged += new System.EventHandler(this.NudTravDist_ValueChanged);
            // 
            // NudMarkUp
            // 
            this.NudMarkUp.DecimalPlaces = 1;
            this.NudMarkUp.Location = new System.Drawing.Point(124, 180);
            this.NudMarkUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NudMarkUp.Name = "NudMarkUp";
            this.NudMarkUp.Size = new System.Drawing.Size(371, 22);
            this.NudMarkUp.TabIndex = 32;
            this.NudMarkUp.ValueChanged += new System.EventHandler(this.NudMarkUp_ValueChanged);
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Location = new System.Drawing.Point(120, 496);
            this.O.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(150, 17);
            this.O.TabIndex = 33;
            this.O.Text = "Overall Expenses Amt:";
            // 
            // LblOverallExpensesAmt
            // 
            this.LblOverallExpensesAmt.AutoSize = true;
            this.LblOverallExpensesAmt.Location = new System.Drawing.Point(268, 496);
            this.LblOverallExpensesAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOverallExpensesAmt.Name = "LblOverallExpensesAmt";
            this.LblOverallExpensesAmt.Size = new System.Drawing.Size(52, 17);
            this.LblOverallExpensesAmt.TabIndex = 34;
            this.LblOverallExpensesAmt.Text = "$00.00";
            // 
            // FrmAddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 580);
            this.Controls.Add(this.LblOverallExpensesAmt);
            this.Controls.Add(this.O);
            this.Controls.Add(this.NudMarkUp);
            this.Controls.Add(this.NudTravDist);
            this.Controls.Add(this.NudMaxPass);
            this.Controls.Add(this.LblPassengerPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblTourCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CbCostType);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRemCost);
            this.Controls.Add(this.BtnEditCost);
            this.Controls.Add(this.BtnAddCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbTourCosts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTEndDate);
            this.Controls.Add(this.DTStartDate);
            this.Controls.Add(this.TxtTourName);
            this.Controls.Add(this.TxtTourCode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAddTour";
            this.Text = "Add Tour";
            this.Load += new System.EventHandler(this.FrmAddTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTravDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMarkUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTourCode;
        private System.Windows.Forms.TextBox TxtTourName;
        private System.Windows.Forms.DateTimePicker DTStartDate;
        private System.Windows.Forms.DateTimePicker DTEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LbTourCosts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnAddCost;
        private System.Windows.Forms.Button BtnEditCost;
        private System.Windows.Forms.Button BtnRemCost;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CbCostType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblTourCost;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblPassengerPrice;
        private System.Windows.Forms.NumericUpDown NudMaxPass;
        private System.Windows.Forms.NumericUpDown NudTravDist;
        private System.Windows.Forms.NumericUpDown NudMarkUp;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label LblOverallExpensesAmt;
    }
}