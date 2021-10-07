using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTasks.Models
{
    public abstract class Employeee
    {
        protected String F_Name;
        protected String L_Name;
        protected double Salary;
        protected double Deduction;
        protected double Insentive;
        protected String Gender;
        public String _F_Name
        {
            set { F_Name = value; }
            get { return F_Name; }
        }

        public String _L_Name
        {
            set { L_Name = value; }
            get { return L_Name; }
        }

        public double _Salary
        {
            set { Salary = value; }
            get { return Salary; }
        }

        public double _Deduction
        {
            set { Deduction = value; }
            get { return Deduction; }
        }

        public double _Insentive
        {
            set { Insentive = value; }
            get { return Insentive; }
        }

        public String _Gender
        {
            set { Gender = value; }
            get { return Gender; }
        }


        public bool Check()
        {
            if(F_Name!="" && L_Name!="" && Salary!=0 && Salary>200 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalcSalary()
        {
            Salary = Salary - Deduction + Insentive;
            return Salary;
        }

        public abstract double Tax(double TotalSalary);

        public abstract double SocialSecurity(double NetSalary);

        public string Print(double NewNewSalary , double TotalSalary)
        {
            return "Hello, You Completed The Reqistration From Successfully, Mr."+ F_Name +" "+ L_Name +"  We Will Deduct From Your Salary : "+ NewNewSalary + " JD, Your Salary After Deduct : "+ TotalSalary +" JD";
        }

        public string Print()
        {
            return "Please Enter & Fill This Info : Enter Your First Name.. , Enter Your Last Name.. , Your Salary Should More Than 200 JD";
        }

        public string Print(double TotalSalary)
        {
            return "Sorry! You Cannot Join With Us. " +
                " Tax Applied On Your Salary : "+TotalSalary +", Your Salary After Tax & Deductions : 260 JD"  ;
        }
    }
}
