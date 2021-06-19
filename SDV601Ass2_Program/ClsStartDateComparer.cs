using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601Ass2_Program
{
    public class ClsStartDateComparer : IComparer<ClsTour>
    {
        public int Compare(ClsTour prTourX, ClsTour prTourY)
        {
            return prTourX.StartDate.Date.CompareTo(prTourY.StartDate.Date);
        }
    }
}