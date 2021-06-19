using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601Ass2_Program
{
    [Serializable]
    public abstract class ClsCost
    {

        private string _CostName;
        private decimal _InputAmount;


        public static ClsCost NewCost(int prCostTypeChoice)
        {
            switch (prCostTypeChoice)
        {
           case 0:
               return new ClsStaffCost();

            case 1:
                return new ClsVehicleCost();

            case 2:
                return new ClsOtherCost();
            default:
                return null;
        }
        }

        public abstract bool ViewEdit();

        public abstract decimal CalcCost(ClsTour prTour);

        public override abstract string ToString();

        public string CostName
        {
            get
            {
                return _CostName;
            }
            set
            {
                _CostName = value;
            }
        }

        public decimal InputAmount
        {
            get
            {
                return _InputAmount;
            }

            set
            {
                _InputAmount = value;
            }
        }

    }


   

}
