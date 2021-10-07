using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTasks.Models
{
    public class Engineer:Employeee
    {
               
            
        public override double Tax(double TotalSalary)
        {
            double TaxSalary=0;

            if (TotalSalary <= 500)
            {
                TaxSalary = TotalSalary * 0.025;
            }
            else if (TotalSalary > 500 && TotalSalary < 750)
            {
                TaxSalary = TotalSalary * 0.05;
            }
            else if (TotalSalary >= 750)
            {
                TaxSalary = TotalSalary * 0.075;
            }
            
            double NetSalary = TotalSalary - TaxSalary;
            return NetSalary;
        }
        public override double SocialSecurity(double NetSalary)
        {
            double SocialSecurtiy = 0;
            if (Gender == "Male")
            {
                if (NetSalary > 260 && NetSalary < 500)
                {
                    SocialSecurtiy = NetSalary - 15;
                }
                else if (NetSalary > 500)
                {
                    SocialSecurtiy = NetSalary - 35;
                }
            }

            else if (Gender == "Female")
            {
                if (NetSalary < 260 && NetSalary < 500)
                {
                    SocialSecurtiy = NetSalary - 32;
                }
                else if (NetSalary > 500)
                {
                    SocialSecurtiy = NetSalary - 51;
                }
            }
            double NewNetSalary = NetSalary- SocialSecurtiy;
            return NewNetSalary;
        }
    }
    }

