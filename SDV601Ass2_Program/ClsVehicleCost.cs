using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601Ass2_Program
{
    [Serializable]
    public class ClsVehicleCost : ClsCost
    {

        private string _VehicleDescription;
        private static FrmVehicleCost _FrmVehicleCost = new FrmVehicleCost();

        public string VehicleDescription
        {
            get
            {
                return _VehicleDescription;
            }
            set
            {
                _VehicleDescription = value;
            }
        }

        public override bool ViewEdit()
        {
            return _FrmVehicleCost.ShowDialog(this);
        }

        public override decimal CalcCost(ClsTour prTour)
        {
            return InputAmount * prTour.TravelDistance;
        }

        public override string ToString()
        {
            return CostName + "\t" + "\t" + "\t" + "Vehicle" + "\t" + "\t" + "\t" + "$" + InputAmount + " per km";
        }

    }
}
