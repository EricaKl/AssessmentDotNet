using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentDotNet
{
    public class MainClass
    {
        static void Main()
        {
            OnPayRollBasis payRollBasis = new OnPayRollBasis();
            OnContractBasis contractBasis = new OnContractBasis();
            char ch;
            do
            {
                int choice = 0;
                int developeradd = 0;
                Console.WriteLine("Developers' required to add (OnContractBasis/OnPayRollBasis)");
                Console.WriteLine("Choose");
                Console.WriteLine("1.OnContractBasis");
                Console.WriteLine("2.OnPayRollBasis");
                Console.WriteLine("3.Perform Linq Operations");
                choice = int.Parse(Console.ReadLine());
            
                
                switch (choice)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("How many employees' you required to add ");

                            developeradd = int.Parse(Console.ReadLine());
                            for (int i = 0; i < developeradd; i++)
                            {
                                contractBasis.Get();
                               
                              
                            }
                            Console.WriteLine("Added Employees'.........");
                            contractBasis.Display();
                            break;
                        }
                    case 2:
                        {
                          
                            Console.WriteLine("How many employees' you required to add ");

                            developeradd = int.Parse(Console.ReadLine());
                            for (int i = 0; i < developeradd; i++)
                            {
                                payRollBasis.Get();
                            }
                            Console.WriteLine("Added Employees'.........");
                            payRollBasis.Display();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("1. Display All Records");
                            Console.WriteLine("2. Display All Records where net salary is more than 20000");
                            Console.WriteLine("3. Display All Records where Developer name contains D");
                            Console.WriteLine("4. Display All Records where Joining Date is between 01/01/2020 and 01/01/2022 ");
                            Console.WriteLine("5. Display All Records where Joining Date was 12 Jan 2022 ");

                            int chooselinq;
                            Console.WriteLine("Enter your choice : ");
                            chooselinq = int.Parse(Console.ReadLine());
                            switch (chooselinq)
                            {
                                case 1:
                                    {
                                        contractBasis.Display();
                                        payRollBasis.Display();
                                        
                                        break;
                                    }
                                case 2:
                                    {
                                        payRollBasis.GetLinqBasedSal();
                                        break;
                                    }
                                case 3:
                                    {
                                        contractBasis.GetLinqBasedName();
                                        payRollBasis.GetLinqBasedName();
                                        break;
                                    }
                                case 4:
                                    {
                                        contractBasis.GetLinqBasedDate();
                                        payRollBasis.GetLinqBasedDate();
                                        break;
                                    }
                                case 5:
                                    {
                                        contractBasis.GetLinqDate();
                                        payRollBasis.GetLinqDate();
                                        break;
                                    }
                            }
                            break;
                        }
                }


                Console.WriteLine("Do you wish to run again (y/n)");
                ch = char.Parse(Console.ReadLine());

            } while (ch=='y'|| ch == 'Y');

        }  
    }
}
