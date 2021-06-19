using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDV601Ass2_Program
{
    public partial class FrmStaffCost : SDV601Ass2_Program.FrmAddCost
    {
        public FrmStaffCost()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsStaffCost lcCost = (ClsStaffCost)_Cost;
            TxtStaffDesc.Text = lcCost.StaffDesc;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsStaffCost lcCost = (ClsStaffCost)_Cost;
            lcCost.StaffDesc = TxtStaffDesc.Text;
        }
    }

}

