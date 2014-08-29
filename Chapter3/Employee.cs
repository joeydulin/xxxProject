using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSalary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName {get; set;}


        private string position;

        public string Position
        {
            get { return position; }
            set
            {
                position = value;

                SetGrossPay(position);

                //At this Point the Gross Pay has been updated

                SetLongPay(HireDate);
                SetTotalDeductions();
                SetTotalSalary();

            }
        }


        //private double GrossPay;
        public double GrossPay { get; private set; }
        private DateTime hireDate;
        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                hireDate = value;


                SetLongPay(hireDate);

            }
        }
        //old code
        //private double LongPay;

        //private double sgti;
        //private double philHealth;
        //private double tax;
        //private double equityplan;
        //private double clothing;
        //private double quarterAllowance; 
        //private double laundryAllowance;
        //private double pera;
        //private double hazardPay;
        //new code
        public double LongPay { get; private set; }
        public double Sgti { get; private set; }
        public double PhilHealth { get; private set; }
        public double Tax { get; private set; }
        public double TotalDeductions
        {
            get
            {
                return Deductions.GetTotalDeductions(GrossPay);
            }
            set
            {

            }
        }
       public double EquityPlan { get; private set; }


        public Employee(string firstname = "Juan", string lastname = "Dela Cruz",string position = "P01")
        {
            //Default HireDate is when creating an instane of the object
            HireDate = DateTime.Now;
            FirstName = firstname;
            LastName = lastname;
            Position = position;

        }

        //METHODS
        private void SetLongPay(DateTime hireDate)
        {
            int YearsOfService = DateTime.Now.Year - hireDate.Year;


            switch (Position)
            {

                case "PO1":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1483.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3115.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 4910;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 6884;
                            
                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 7417;
                            
                        }
                        

                        


                        break;
                    }

                case "PO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5605;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 7859;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 8467;

                        }
                        




                        break;
                    }
                case "PO3":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1867.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3920.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 6178.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 8662.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 9333.00;

                        }





                        break;
                    }
                case "SPO1":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 2171.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 4559.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 7186.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 10076.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 10856.00;

                        }





                        break;
                    }
                case "SPO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 2351.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 4938.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 7783.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 10912.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 11757.00;

                        }





                        break;
                    }
                case "SPO3":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 2539.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 5333.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 8405.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 11785.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 12697.00;

                        }





                        break;
                    }
                case "SPO4":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 2743.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 5759.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 9078.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 12728.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 13713.00;

                        }





                        break;
                    }
                case "INSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 3234.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 6792.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 10705.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 15009.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 16171;

                        }





                        break;
                    }
                case "SINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 3531.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 7416.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 11688.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 16388.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 17656.00;

                        }





                        break;
                    }
                case "CINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 3731.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 7836.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 12351.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 17317.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 18657.00;

                        }





                        break;
                    }
                               case "SUPT":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 4030.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 8463.00;
                        }
                        //Continue the Else If
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 13339.00;
                        }
                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 18702.00;

                        }
                        else if (YearsOfService >= 25 && YearsOfService < 30)
                        {
                            LongPay = 20149.00;

                        }





                        break;
                    }






                default:
                    break;
            }

        }

        private void SetGrossPay(string position)
        {

            switch (position)
            {
                case "P01":
                    {
                        GrossPay = 14834.00;
                        break;
                    }

                case "P02":
                    {
                        GrossPay = 16934.00;
                        break;
                    }
                case "P03":
                    {
                        GrossPay = 18665.00;
                        break;
                    }
                case "SPO1":
                    {
                        GrossPay = 21711.00;
                        break;
                    }
                case "SPO2":
                    {
                        GrossPay = 23513.00;
                        break;
                    }
                case "SPO3":
                    {
                        GrossPay = 25394.00;
                        break;
                    }
                case "SPO4":
                    {
                        GrossPay = 27495.00;
                        break;
                    }
                case "INSP":
                    {
                        GrossPay = 32341.00;
                        break;
                    }
                case "SINSP":
                    {
                        GrossPay = 35312.00;
                        break;
                    }
                case "CINSP":
                    {
                        GrossPay = 37313.00;
                        break;
                    }
                case "SUPT":
                    {
                        GrossPay = 40248.00;
                        break;
                    }
                    


                default:
                    break;
            }
        }

        //Getting the LongPay where LongPay is not a property, a user can set
        //public double GetLongPay()
        //{
        //    return LongPay;
        //}

        ////Getting the GrossPay where GrossPay is not a property, a user can set
        //public double GetGrossPay()
        //{
        //    return GrossPay;
        //}

        private void SetTotalDeductions()
        {
            Sgti = Deductions.GetSGTI(GrossPay);
            Tax = Deductions.GetTax(GrossPay);
            PhilHealth = Deductions.GetPhilHealth(GrossPay);
            EquityPlan = Deductions.GetEquityPlan(GrossPay);
           // double TotalDeductions = GetSGTI(GrossPay) + GetPhilHealth(GrossPay) + GetTax(GrossPay) + GetEquityPlan(GrossPay);

            //return TotalDeductions;
    
        }
        private void SetTotalSalary()
        {    
             //old code
            //double TotalSalary = 0;
            //TotalSalary = GrossPay + LongPay + hazardPay + Allowances.GetTotalAllowances(GrossPay) - Deductions.GetTotalDeductions(GrossPay);

            //new code
            double TotalSalary = 0;
            TotalSalary = GrossPay + LongPay - Deductions.GetTotalDeductions(GrossPay);
    


        }

        public double TotalSalary
        {
            get
            {
                double TotalSalary = 0;
                TotalSalary = GrossPay + LongPay - Deductions.GetTotalDeductions(GrossPay);
                return TotalSalary;
            }
            
        }
        
        

        
       

        //public double GetHazardPay()
        //{
        //    hazardPay = 240;
        //    return hazardPay;
        //}

        //public double GetEquityPlan()
        //{

        //    return equityplan;
        //}

        //public double GetSGTI()
        //{
        //    return sgti;
        //}

        //public double GetTax()
        //{
        //    return tax;
        //}

        //public double GetPhilHealth()
        //{
        //    return philHealth;
        //}

      
        //private void SetAllowances()
        //{
        //    clothing = Allowances.GetClothing(GrossPay);
        //    quarterAllowance = Allowances.GetQuarterAllowance(GrossPay);
        //    laundryAllowance = Allowances.GetLaundryAllowance(GrossPay);
        //    pera = Allowances.GetPera(GrossPay);
        //    hazardPay = Allowances.GetHazardPay(GrossPay);
        //}
        //public double GetClothing()
        //{
        //    double clothing = 200;
        //    return clothing;
        //}
        //public double GetQuarterAllowance()
        //{
        //    double quarterAllowance = 200;
        //    return quarterAllowance;
        //}
        //public double GetLaundryAllowance()
        //{
        //    double laundryAllowance = 30;
        //    return laundryAllowance;
        //}
        //public double GetPera()
        //{
        //    double pera = 2000;
        //    return pera;
        //}




    }

}
