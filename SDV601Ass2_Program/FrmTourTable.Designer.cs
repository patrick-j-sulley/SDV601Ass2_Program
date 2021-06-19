namespace SDV601Ass2_Program
{
    partial class FrmTourTable
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
            this.components = new System.ComponentModel.Container();
            this.LbTours = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbSortBy = new System.Windows.Forms.ComboBox();
            this.BtnAddTour = new System.Windows.Forms.Button();
            this.BtnEditTour = new System.Windows.Forms.Button();
            this.BtnDeleteTour = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.TmrAutoSave = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LbTours
            // 
            this.LbTours.FormattingEnabled = true;
            this.LbTours.ItemHeight = 16;
            this.LbTours.Location = new System.Drawing.Point(12, 34);
            this.LbTours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbTours.Name = "LbTours";
            this.LbTours.Size = new System.Drawing.Size(509, 212);
            this.LbTours.TabIndex = 0;
            this.LbTours.UseTabStops = false;
            this.LbTours.DoubleClick += new System.EventHandler(this.LbTours_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price Per Passenger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sort By (Name or Start Date)";
            // 
            // CbSortBy
            // 
            this.CbSortBy.FormattingEnabled = true;
            this.CbSortBy.Location = new System.Drawing.Point(393, 261);
            this.CbSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbSortBy.Name = "CbSortBy";
            this.CbSortBy.Size = new System.Drawing.Size(128, 24);
            this.CbSortBy.TabIndex = 5;
            this.CbSortBy.SelectedIndexChanged += new System.EventHandler(this.CbSortBy_SelectedIndexChanged);
            // 
            // BtnAddTour
            // 
            this.BtnAddTour.Location = new System.Drawing.Point(12, 262);
            this.BtnAddTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddTour.Name = "BtnAddTour";
            this.BtnAddTour.Size = new System.Drawing.Size(179, 23);
            this.BtnAddTour.TabIndex = 6;
            this.BtnAddTour.Text = "Add New Tour";
            this.BtnAddTour.UseVisualStyleBackColor = true;
            this.BtnAddTour.Click += new System.EventHandler(this.BtnAddTour_Click);
            // 
            // BtnEditTour
            // 
            this.BtnEditTour.Location = new System.Drawing.Point(12, 289);
            this.BtnEditTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditTour.Name = "BtnEditTour";
            this.BtnEditTour.Size = new System.Drawing.Size(179, 23);
            this.BtnEditTour.TabIndex = 7;
            this.BtnEditTour.Text = "Edit Selected Tour";
            this.BtnEditTour.UseVisualStyleBackColor = true;
            this.BtnEditTour.Click += new System.EventHandler(this.BtnEditTour_Click);
            // 
            // BtnDeleteTour
            // 
            this.BtnDeleteTour.Location = new System.Drawing.Point(12, 316);
            this.BtnDeleteTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteTour.Name = "BtnDeleteTour";
            this.BtnDeleteTour.Size = new System.Drawing.Size(179, 23);
            this.BtnDeleteTour.TabIndex = 8;
            this.BtnDeleteTour.Text = "Delete Selected Tour";
            this.BtnDeleteTour.UseVisualStyleBackColor = true;
            this.BtnDeleteTour.Click += new System.EventHandler(this.BtnDeleteTour_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(200, 289);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(316, 50);
            this.BtnQuit.TabIndex = 9;
            this.BtnQuit.Text = "Exit Program";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // TmrAutoSave
            // 
            this.TmrAutoSave.Interval = 10000;
            this.TmrAutoSave.Tick += new System.EventHandler(this.TmrAutoSave_Tick);
            // 
            // FrmTourTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 345);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnDeleteTour);
            this.Controls.Add(this.BtnEditTour);
            this.Controls.Add(this.BtnAddTour);
            this.Controls.Add(this.CbSortBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbTours);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTourTable";
            this.Text = "Tour Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbTours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbSortBy;
        private System.Windows.Forms.Button BtnAddTour;
        private System.Windows.Forms.Button BtnEditTour;
        private System.Windows.Forms.Button BtnDeleteTour;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Timer TmrAutoSave;
    }
}

