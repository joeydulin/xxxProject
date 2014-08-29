using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSalary
{
    //Take note, this is a Static Class
    public static class Deductions
    {
        
        //Static Classes, use static Methods
        public static double GetTotalDeductions(double GrossPay )
        {
            double TotalDeductions = GetSGTI(GrossPay) + GetPhilHealth(GrossPay) + GetTax(GrossPay) + GetEquityPlan(GrossPay);
           
            return TotalDeductions;
        }

       
        public static double GetEquityPlan(double GrossPay)
       {
            
            //EDIT
            return 32.00;
        }

        public static double GetSGTI(double GrossPay)
        {
           //EDIT
           return 6.00;
        }

        public static double GetPhilHealth(double GrossPay)
        {
            //DO Logic for PhilHealth
            
            double PhilHealth = 0;
            if (GrossPay >= 5000 && GrossPay < 6000)
            {
                PhilHealth = 50;
            }
            else if (GrossPay >=6000 && GrossPay < 7000)
            {
                PhilHealth = 62.50;
            }
            else if (GrossPay>= 7000 && GrossPay < 8000)
            {
                PhilHealth = 75.00;
            }
            else if (GrossPay >= 8000 && GrossPay < 9000)
            {
                PhilHealth = 87.50;
            }
            else if (GrossPay >= 9000 && GrossPay < 10000)
            {
                PhilHealth = 100;
            }
            else if (GrossPay >= 10000 && GrossPay < 11000)
            {
                PhilHealth = 112.50;
            }
            else if (GrossPay >= 11000 && GrossPay < 12000)
            {
                PhilHealth = 125.00;
            }
            else if (GrossPay >= 12000 && GrossPay < 13000)
            {
                PhilHealth = 137.50;
            }
            else if (GrossPay >= 13000 && GrossPay < 14000)
            {
                PhilHealth = 150.00;
            }
            else if (GrossPay >= 14000 && GrossPay < 15000)
            {
                PhilHealth = 162.50;
            }
            else if (GrossPay >= 15000 && GrossPay < 16000)
            {
                PhilHealth = 175.00;
            }
            else if (GrossPay >= 16000 && GrossPay < 17000)
            {
                PhilHealth = 187.50;
            }
            else if (GrossPay >= 17000 && GrossPay < 18000)
            {
                PhilHealth = 200.00;
            }
            else if (GrossPay >= 18000 && GrossPay < 19000)
            {
                PhilHealth = 212.50;
            }
            else if (GrossPay >= 20000 && GrossPay < 21000)
            {
                PhilHealth = 237.00;
            }
            else if (GrossPay >= 21000 && GrossPay < 22000)
            {
                PhilHealth = 250.00;
            }
            else if (GrossPay >= 22000 && GrossPay < 23000)
            {
                PhilHealth = 262.00;
            }
            else if (GrossPay >= 23000 && GrossPay < 24000)
            {
                PhilHealth = 275.00;
            }
            else if (GrossPay >= 24000 && GrossPay < 25000)
            {
                PhilHealth = 287.00;
            }
            else if (GrossPay >= 25000 && GrossPay < 26000)
            {
                PhilHealth = 300.00;
            }
            else if (GrossPay >= 26000 && GrossPay < 27000)
            {
                PhilHealth = 312.00;
            }
            else if (GrossPay >= 27000 && GrossPay < 28000)
            {
                PhilHealth = 325.00;
            }
            else if (GrossPay >= 28000 && GrossPay < 29000)
            {
                PhilHealth = 337.50;
            }
            else if (GrossPay >= 29000 && GrossPay < 30000)
            {
                PhilHealth = 350.00;
            }
            else if (GrossPay >= 30000 && GrossPay < 57700)
            {
                PhilHealth = 362.00;
            }
            else if (GrossPay <= 57700)
            {
                PhilHealth = 375.00;
            }

            return PhilHealth;
        }

        public static double GetTax(double GrossPay)
        {
            //DO Tax Computation
            double tax = GrossPay * .12;
            return tax;
        }

    }


   
}
