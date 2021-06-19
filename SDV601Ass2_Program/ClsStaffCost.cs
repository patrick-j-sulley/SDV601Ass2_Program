using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601Ass2_Program
{
    [Serializable]
    public class ClsStaffCost : ClsCost
    {

        private string _StaffDesc;

        private static FrmStaffCost _FrmStaffCost = new FrmStaffCost();

        public string StaffDesc
        {
            get
            {
                return _StaffDesc;
            }
            set
            {
                _StaffDesc = value;
            }
        }

        public override bool ViewEdit()
        {
            return _FrmStaffCost.ShowDialog(this);
        }

        public override decimal CalcCost(ClsTour prTour)
        {
            return InputAmount * Convert.ToDecimal((prTour.EndDate - prTour.StartDate).TotalDays);
        }

        public override string ToString()
        {
            return CostName + "\t" + "\t" + "\t" + "Staff" + "\t" + "\t" + "$" + InputAmount + "per Day";
        }

    }
}
