using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SDV601Ass2_Program
{
    [Serializable]
    public class ClsTour
    {
        public readonly string[] CostType = { "Staff", "Vehicle", "Other" };

        private List<ClsCost> _CostList = new List<ClsCost>();

        private string _TourCode;
        private string _TourName;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today.AddDays(1);
        private int _MaxPassengerAmount;
        private decimal _TravelDistance;
        private decimal _MarkUpPercentage;
        private decimal _OverallTourCost;
        private decimal _OverallCostsTotal;
        private decimal _PricePerPassenger;

        private static FrmAddTour _FrmTour = new FrmAddTour();



        public bool ViewEdit()
        {
            return _FrmTour.ShowDialog(this);

        }

        public decimal calcExpensesTotal()
        {
            decimal lcTotal = 0;

            foreach (ClsCost _cost in _CostList)
            {
                lcTotal += _cost.CalcCost(this);
            }

            OverallCostsTotal = lcTotal;

            return lcTotal;
        }

        public decimal calcTourTotal()
        {
            if (OverallCostsTotal != 0 & MarkUpPercentage != 0)
            {
                decimal lcTotal = 0;

                lcTotal = OverallCostsTotal + ((OverallCostsTotal * 100) / MarkUpPercentage);
                OverallTourCost = lcTotal;

                return lcTotal;
            }
            else

                return 0;
        }

        public decimal calcPricePerPassenger()
        {
            if (OverallTourCost != 0 & MaxPassengerAmount != 0)
            {
                decimal lcTotal;

                lcTotal = OverallTourCost / MaxPassengerAmount;
                PricePerPassenger = lcTotal;

                return lcTotal;
            }
            else

                return 0;
        }

        public override string ToString()
        {
            return TourName + "\t" + "\t" + "\t" + (StartDate.ToString("d")) + "\t" + "\t" + "\t" + "$" + PricePerPassenger;
        }

        public List<ClsCost> CostList
        {
            get
            {
                return _CostList;
            }
        }

        public string TourName
        {
            get
            {
                return _TourName;
            }
            set
            {
                _TourName = value;
            }
        }

        public string TourCode
        {
            get
            {
                return _TourCode;
            }
            set
            {
                _TourCode = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                _EndDate = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                _StartDate = value;
            }
        }

        public decimal TravelDistance
        {
            get
            {
                return _TravelDistance;
            }
            set
            {
                _TravelDistance = value;
            }
        }

        public int MaxPassengerAmount
        {
            get
            {
                return _MaxPassengerAmount;
            }
            set
            {
                _MaxPassengerAmount = value;
            }
        }

        public decimal MarkUpPercentage
        {
            get
            {
                return _MarkUpPercentage;
            }
            set
            {
                _MarkUpPercentage = value;
            }
        }

        public decimal PricePerPassenger
        {
            get
            {
                return _PricePerPassenger;
            }
            set
            {
                _PricePerPassenger = value;
            }
        }

        public decimal OverallTourCost
        {
            get
            {
                return _OverallTourCost;
            }
            set
            {
                _OverallTourCost = value;
            }
        }

        public decimal OverallCostsTotal
        {
            get
            {
                return _OverallCostsTotal;
            }

            set
            {
                _OverallCostsTotal = value;
            }
        }

    }
}
