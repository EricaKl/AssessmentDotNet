using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentDotNet
{
    public  class OnContractBasis: Developer
    {

        public int Duration;
        public double charges;
        List<OnContractBasis> list = new List<OnContractBasis>();
      
        public OnContractBasis() 
        { 
            Duration = 0;
            charges = 0;
        }

        public void Get()
        {
            base.Get();
            try
            {
                Console.WriteLine("Enter Duration of Developer (In Days)");
                Duration = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Charges per day");
                charges = double.Parse(Console.ReadLine());

                list.Add(new OnContractBasis
                {
                    Id = Id,
                    JoiningDate = JoiningDate,
                    DeveloperName = DeveloperName,
                    Duration = Duration,
                    charges = charges
                });

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }

        public void Display()
        {
            base.Display();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"Duration is {list[i].Duration}");
                    Console.WriteLine($"charges are {list[i].charges}");
                    Console.WriteLine($"Total Charges are {list[i].Duration * list[i].charges}");
                }
            }
            catch (Exception ex) { Console.WriteLine( ex.Message); }

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
                    Console.WriteLine("Not Exists... ");
                }
            }
            catch(Exception ex)
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
                    Console.WriteLine("Not Exists in ContractBasis....");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
           
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
                    Console.WriteLine("Not Exists....");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }


    }
}
