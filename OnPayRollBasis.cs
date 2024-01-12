using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentDotNet
{
    public class OnPayRollBasis : Developer
    {
        public string Department;
        public string Manager;
        public double NetSalary;
        public double Exp;
        public double Da;
        public double Hra;
        public double Lta;
        public double Pf;
        public double BasicSalary;
        List<OnPayRollBasis> list = new List<OnPayRollBasis>();

        public OnPayRollBasis()
        {
            Department = string.Empty;
            Manager = string.Empty;
            NetSalary = 0;
            Exp = 0; 
            Da = 0; 
            Hra = 0; 
            Lta = 0;
            Pf = 0; 
            BasicSalary = 0;

        }

        public void Get()
        {
            base.Get();
            try
            {
                Console.WriteLine("Enter Department");
                Department = Console.ReadLine();
                Console.WriteLine("Enter Manager");
                Manager = Console.ReadLine();
                Console.WriteLine("Enter Experience");
                Exp = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Basic Salary");
                BasicSalary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter LTA");
                Lta = double.Parse(Console.ReadLine());
                Da = CalcDa(Exp, BasicSalary);
                Hra = CalcHra(Exp, BasicSalary);
                Pf = CalcPf(Exp);
                NetSalary = CalcNetSalary(BasicSalary, Da, Hra, Lta, Pf);

                list.Add(new OnPayRollBasis
                {
                    Id = Id,
                    JoiningDate = JoiningDate,
                    DeveloperName = DeveloperName,
                    ProjectAssigned = ProjectAssigned,
                    Department = Department,
                    Manager = Manager,
                    Exp = Exp,
                    BasicSalary = BasicSalary,
                    Lta = Lta,
                    Da = Da,
                    Hra = Hra,
                    Pf = Pf,
                    NetSalary = NetSalary
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public double CalcDa(double Exp, double BasicSalary)
        {
            double da = 0;
            try
            {
                if (Exp > 10)
                {
                    da = (10 / 100) * BasicSalary;
                }
                else if (Exp > 7 && Exp < 10)
                {
                    da = (7 / 100) * BasicSalary;
                }
                else if (Exp > 5 && Exp < 7)
                {
                    da = (4.1 / 100) * BasicSalary;
                }
                else if (Exp < 5)
                {
                    da = (1.9 / 100) * BasicSalary;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
            return da;

        }

        public double CalcHra(double Exp, double BasicSalary)
        {
            double hra = 0;
            try
            {
                if (Exp > 10)
                {
                    hra = (8.5 / 100) * BasicSalary;
                }
                else if (Exp > 7 && Exp < 10)
                {
                    hra = (6.5 / 100) * BasicSalary;
                }
                else if (Exp > 5 && Exp < 7)
                {
                    hra = (3.8 / 100) * BasicSalary;
                }
                else if (Exp < 5)
                {
                    hra = (2.0 / 100) * BasicSalary;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            return hra;

        }

        public double CalcPf(double Exp)
        {
            double pf = 0;
            try
            {
                if (Exp > 10)
                {
                    pf = 6200;
                }
                else if (Exp > 7 && Exp < 10)
                {
                    pf = 4100;
                }
                else if (Exp > 5 && Exp < 7)
                {
                    pf = 1800;
                }
                else if (Exp < 5)
                {
                    pf = 1200;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            return pf;

        }

        public double CalcNetSalary(double BasicSalary , double Da, double Hra, double Lta,double Pf)
        {

            double NetSalary = 0;
            try
            {
                NetSalary = (BasicSalary + Da + Hra + Lta) - (Pf);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NetSalary; 
        }

        public void Display()
        {
            base.Display();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {

                    Console.WriteLine($"Department is {list[i].Department}");
                    Console.WriteLine($"Manager is {list[i].Manager}");
                    Console.WriteLine($"Experience is {list[i].Exp}");
                    Console.WriteLine($"Da is {list[i].Da}");
                    Console.WriteLine($"Hra is {list[i].Hra}");
                    Console.WriteLine($"Pf is {list[i].Pf}");
                    Console.WriteLine($"Lta is {list[i].Lta}");
                    Console.WriteLine($"Basic Salary is {list[i].BasicSalary}");
                    Console.WriteLine($"Net Salary is {list[i].NetSalary}");

                }

            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void GetLinqBasedSal()
        {
            try
            {
                var list1 = list.Where(x => x.NetSalary > 20000).ToList();
                for (int i = 0; i < list1.Count; i++)
                {
                    Console.WriteLine($"Developer Id {list1[i].Id}");
                    Console.WriteLine($"Developer Name {list1[i].DeveloperName}");
                    Console.WriteLine($"Joining Date {list1[i].JoiningDate}");
                    Console.WriteLine($"Project Assigned  {list1[i].ProjectAssigned}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public void GetLinqBasedName()
        {
            try
            {
                var list1 = list.Where(x => x.DeveloperName.Contains('D')).ToList();
                if (list1.Count > 0)
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        Console.WriteLine($"Developer Id {list1[i].Id}");
                        Console.WriteLine($"Developer Name {list1[i].DeveloperName}");
                        Console.WriteLine($"Joining Date {list1[i].JoiningDate}");
                        Console.WriteLine($"Project Assigned  {list1[i].ProjectAssigned}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Exists in PayRoll Basis....");
                }
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
           
           

        }

        public void GetLinqBasedDate()
        {
            try
            {
                DateOnly date1 = new DateOnly(2020, 01, 01);
                DateOnly date2 = new DateOnly(2022, 01, 01);
                var list1 = list.Where(x => x.JoiningDate >= date1 && x.JoiningDate <= date2).ToList();
                if (list1.Count > 0)
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        Console.WriteLine($"Developer Id {list1[i].Id}");
                        Console.WriteLine($"Developer Name {list1[i].DeveloperName}");
                        Console.WriteLine($"Joining Date {list1[i].JoiningDate}");
                        Console.WriteLine($"Project Assigned  {list1[i].ProjectAssigned}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Exists in PayRoll Basis....");
                }
            }
            catch( Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
         
        }

        public void GetLinqDate()
        {
            try
            {
                DateOnly date1 = new DateOnly(2022, 01, 12);
                var list1 = list.Where(x => x.JoiningDate == date1).ToList();
                if (list1.Count > 0)
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        Console.WriteLine($"Developer Id {list1[i].Id}");
                        Console.WriteLine($"Developer Name {list1[i].DeveloperName}");
                        Console.WriteLine($"Joining Date {list1[i].JoiningDate}");
                        Console.WriteLine($"Project Assigned  {list1[i].ProjectAssigned}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Exists in PayRoll Basis....");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }

    }
}
