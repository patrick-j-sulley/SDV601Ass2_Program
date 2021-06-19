using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDV601Ass2_Program
{
    public partial class FrmOtherCost : SDV601Ass2_Program.FrmAddCost
    {
        public FrmOtherCost()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsOtherCost lcCost = (ClsOtherCost)_Cost;
            TxtOtherDescription.Text = lcCost.OtherDescription;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsOtherCost lcCost = (ClsOtherCost)_Cost;
            lcCost.OtherDescription = TxtOtherDescription.Text;
        }

    }
}
