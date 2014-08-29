using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSalary
{
    public static class Allowances
    {
        public static double GetTotalAllowances(double grossPay)
        {
            double totalAllowances = GetClothing(grossPay) + GetQuarterAllowance(grossPay) + GetLaundryAllowance(grossPay) + GetPera(grossPay);

            return totalAllowances;
        }
        public static double GetClothing(double grossPay)
        {
            //EDIT
            double clothing = 200;
            return clothing;
        }
        public static double GetQuarterAllowance(double grossPay)
        {
            
            double quarterAllowance = 200;
            return quarterAllowance;
        }
        public static double GetLaundryAllowance(double grossPay)
        {
         
            double laundryAllowance = 30;
            return laundryAllowance;
        }
        public static double GetPera(double grossPay)
        {
            
            double pera = 2000;
            return pera;
        }
        public static double GetHazardPay(double grossPay)
        {
            
            return 240.00;
        }

    }
}
