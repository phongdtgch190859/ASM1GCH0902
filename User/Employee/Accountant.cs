using System;
using System.Collections.Generic;
namespace Payroll
{
    public class Accountant :Employee
    {
        public List<User> users { get; set; }
      
        public Accountant(string userName, string passWord, string name, int phone, string positon, InfoToPay info, List<User> e) : base (userName, passWord, name, phone, positon,info)
        {
            infoToPay = new InfoEmployee();
            if(e.Count > 0 ) users = e; 
            else Console.WriteLine("Input employees' ifo");
            
        }
        public void CaulateSalary()
        {
            foreach( Employee e in users)
            {
                int overtimeSalary = e.infoToPay.OvertimeHours*e.infoToPay.multiplier.BonusRate;
                int basic = 26*e.infoToPay.multiplier.CoefficientsSalary*e.infoToPay.BasicSlary;
                e.Salary = (int)((basic + overtimeSalary)*e.infoToPay.multiplier.TaxRate);

            }
        }
        public void  EditRate()
        {   
        
            PrintAllIfo();
            Console.Write(" enter id to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach( Employee e in users)
            {
              
                
                if ( e.ID == id )
                {
                    
                    while(true)
                    {
                        PrintMenu();
                        int choice = GetChoice();
                        users[id] = DoTask(choice,e);
                        if(choice == 0) break;
                       
                    }

                    break;
                    
                }

            }

        }

        private Employee DoTask(int choice, Employee e)
        {
            switch (choice)
            {
            case 1:
            {
                Console.Write("Enter new coefficient salary to edit: ");
                int newRate = Convert.ToInt32(Console.ReadLine());
                e.infoToPay.multiplier.CoefficientsSalary = newRate;
                break;
            }
            case 2:
            {
                Console.Write("Enter new tax rate to edit: ");
                double newRate = Convert.ToDouble(Console.ReadLine());
                e.infoToPay.multiplier.TaxRate = newRate;
                break;
            }
            case 3:
            {
                Console.Write("Enter new bonus rate to edit: ");
                int newRate = Convert.ToInt32(Console.ReadLine());
                e.infoToPay.multiplier.BonusRate = newRate;
                break; 
            }
            case 0: Console.WriteLine("exit successfuly"); break;  
            default:  Console.WriteLine("Wrrong choice please try agian"); break;         
            }
            return e;
             
        }

        public void PrintAllIfo()
        {
            Console.WriteLine(" ____________________________________________________________________________");
            Console.WriteLine("|ID     Name     Days  Overtime  CoefficientsSalary  TaxRate BonusRate Salary|");
            Console.WriteLine(" ----------------------------------------------------------------------------");
            foreach( Employee e in users)
            {
               e.PrintIfo();
               Console.WriteLine();
            }
            Console.WriteLine(" ----------------------------------------------------------------------------");
        }
        public void PrintMenu()
        {
            Console.WriteLine("Option 1: Edit Coefficients Salary ");
            Console.WriteLine("Option 2: Edit Tax Rate ");
            Console.WriteLine("Option 3: Edit Bonus Rate ");
            Console.WriteLine("Option 0: Exit");
            
        }
        public int GetChoice()
        {
            Console.Write("enter chocie: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }


    }   
}