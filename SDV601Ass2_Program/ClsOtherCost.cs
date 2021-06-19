using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601Ass2_Program
{
    [Serializable]
    public class ClsOtherCost : ClsCost
    {


        private string _OtherDescription;
        private static FrmOtherCost _FrmOtherCost = new FrmOtherCost();

        public string OtherDescription
        {
            get
            {
                return _OtherDescription;
            }
            set
            {
                _OtherDescription = value;
            }
        }

        public override bool ViewEdit()
        {
            return _FrmOtherCost.ShowDialog(this);
        }

        public override decimal CalcCost(ClsTour prTour)
        {
            return InputAmount;
        }

        public override string ToString()
        {
            return CostName + "\t" + "\t" + "\t" + "Other" + "\t" + "\t" + "\t" + "$" + InputAmount;
        }

    }

}
