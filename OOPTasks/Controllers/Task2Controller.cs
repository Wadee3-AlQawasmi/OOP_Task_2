using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTasks.Models;

namespace OOPTasks.Controllers
{
    public class Task2Controller : Controller
    {
        public IActionResult Index()
        {   
            return View("Task2View");
        }

        public IActionResult Action()
        {

            var List = Request.Form["List"];
            if (List == "Doctor")
            {
                Doctor Doc = new Doctor();
                Doc._F_Name = Request.Form["TxtFirst"];
                Doc._L_Name = Request.Form["TxtLast"];
                Doc._Salary = Convert.ToDouble(Request.Form["TxtSalary"]);
                Doc._Gender = Request.Form["gender"];
                Doc._Deduction= Convert.ToDouble(Request.Form["TxtDuduction"]);
                Doc._Insentive = Convert.ToDouble(Request.Form["TxtInsentive"]);
                
                if (Doc.Check()==true)
                {
                    double TotalSalary = Doc.CalcSalary();
                    double NetSalary = Doc.Tax(TotalSalary);
                    if (NetSalary >= 260)
                    {
                        double NewNetSalary = Doc.SocialSecurity(NetSalary);
                        string Msg = Doc.Print(NewNetSalary, TotalSalary);
                        ViewData["Msg"] = Msg;
                    }
                    else if(NetSalary<260)
                    {
                        ViewData["Msg"] = Doc.Print(TotalSalary);
                    }
                }
                else 
                {
                    ViewData["Msg"] = Doc.Print();
                }

                

            }
            else if(List== "Teacher")
            {
                Teacher Tec = new Teacher();
                Tec._F_Name = Request.Form["TxtFirst"];
                Tec._L_Name = Request.Form["TxtLast"];
                Tec._Salary = Convert.ToDouble(Request.Form["TxtSalary"]);
                Tec._Gender = Request.Form["gender"];
                Tec._Deduction = Convert.ToDouble(Request.Form["TxtDuduction"]);
                Tec._Insentive = Convert.ToDouble(Request.Form["TxtInsentive"]);

                if (Tec.Check() == true)
                {
                    double TotalSalary = Tec.CalcSalary();
                    double NetSalary = Tec.Tax(TotalSalary);
                    if (NetSalary >= 260)
                    {
                        double NewNetSalary = Tec.SocialSecurity(NetSalary);
                        string Msg = Tec.Print(NewNetSalary, TotalSalary);
                        ViewData["Msg"] = Msg;
                    }
                    else if (NetSalary < 260)
                    {
                        ViewData["Msg"] = Tec.Print(TotalSalary);
                    }
                }
                else
                {
                    ViewData["Msg"] = Tec.Print();
                }

            }

            else if (List == "Engineer")
            {
                Engineer Eng = new Engineer();
                Eng._F_Name = Request.Form["TxtFirst"];
                Eng._L_Name = Request.Form["TxtLast"];
                Eng._Salary = Convert.ToDouble(Request.Form["TxtSalary"]);
                Eng._Gender = Request.Form["gender"];
                Eng._Deduction = Convert.ToDouble(Request.Form["TxtDuduction"]);
                Eng._Insentive = Convert.ToDouble(Request.Form["TxtInsentive"]);

                if (Eng.Check() == true)
                {
                    double TotalSalary = Eng.CalcSalary();
                    double NetSalary = Eng.Tax(TotalSalary);
                    if (NetSalary >= 260)
                    {
                        double NewNetSalary = Eng.SocialSecurity(NetSalary);
                        string Msg = Eng.Print(NewNetSalary, TotalSalary);
                        ViewData["Msg"] = Msg;
                    }
                    else if (NetSalary < 260)
                    {
                        ViewData["Msg"] = Eng.Print(TotalSalary);
                    }
                }
                else
                {
                    ViewData["Msg"] = Eng.Print();
                }

            }

            return View("Task2View");

        }
    }
}
