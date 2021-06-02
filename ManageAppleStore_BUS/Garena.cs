using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_BUS
{
    class Garena
    {
        static string wordSerapate(string Str)
        {
            string StrWord = "";
            foreach (var key in Str)
            {
                if (key < '0' || key > '9')
                {
                    StrWord += key;
                }
            }
            return StrWord;
        }

        static int numberSerapate(string Str)
        {
            string StrNumber = "";
            foreach (var key in Str)
            {
                if (key >= '0' && key <= '9')
                {
                    StrNumber += key;
                }
            }
            return Convert.ToInt32(StrNumber);
        }

        public static string returnMaxID(List<string> LstID)
        {
            if (LstID.Count > 0)
            {
                // B1: Tach lay chu.
                string StrMaxEmpID = wordSerapate(LstID[0]);

                // B2: Tach lay so cho vao list
                int ILength = LstID.Count();
                List<int> LstNumber = new List<int>();
                foreach (var id in LstID)
                {
                    LstNumber.Add(numberSerapate(id));
                }

                // B3: Tim max tu list number va tang max len 1 don vi.
                int IMaxID = LstNumber.Max() + 1;

                // B4: Merge phan chu va so lon nhat lai voi nhau.
                StrMaxEmpID += IMaxID.ToString();

                return StrMaxEmpID;
            }
            return "1";
        }
    }
}
