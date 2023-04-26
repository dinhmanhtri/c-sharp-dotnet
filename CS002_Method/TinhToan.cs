using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS002_Method
{
    public class TinhToan
    {
        public static int TinhGiaiThua(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * TinhGiaiThua(number - 1);
        }

        // overloading method
        public static double TinhGiaiThua(double number)
        {
            if (number == 1)
            {
                return 1.0;
            }
            return number * TinhGiaiThua(number - 1);
        }
    }
}