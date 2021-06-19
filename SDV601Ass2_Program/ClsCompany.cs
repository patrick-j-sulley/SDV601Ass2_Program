using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SDV601Ass2_Program
{

    [Serializable]
    public class ClsCompany
    {

        private static string SaveFileName = "saveData";
        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();
        private static readonly string[] _SortByType = { "Name", "Start Date" };



        public static void SaveTours()
        {
            using (FileStream lcFileStream = new FileStream(SaveFileName, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, TourList);
            }
        }

        public static void RetrieveTours()
        {
            using (FileStream lcFileStream = new FileStream(SaveFileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                TourList = (Dictionary<string, ClsTour>)
                                            lcFormatter.Deserialize(lcFileStream);
            }
        }


        public static Dictionary<string, ClsTour> TourList
        {
            get
            {
                return _TourList;
            }
            set
            {
                _TourList = value;
            }
        }

        public static string[] SortByType => _SortByType;
    }
}
