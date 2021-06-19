using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDV601Ass2_Program
{
    public partial class FrmVehicleCost : SDV601Ass2_Program.FrmAddCost
    {
        public FrmVehicleCost()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsVehicleCost lcCost = (ClsVehicleCost)_Cost;
            TxtVehicleDesc.Text = lcCost.VehicleDescription;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsVehicleCost lcCost = (ClsVehicleCost)_Cost;
            lcCost.VehicleDescription = TxtVehicleDesc.Text;
        }

    }
}
