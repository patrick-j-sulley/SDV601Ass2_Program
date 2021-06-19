using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601Ass2_Program
{
    public class ClsNameComparer : IComparer<ClsTour>
    {
        public int Compare(ClsTour prTourX, ClsTour prTourY)
        {
            return prTourX.TourName.CompareTo(prTourY.TourName);
        }
    }
}
