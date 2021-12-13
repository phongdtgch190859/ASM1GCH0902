using System;
using System.Collections.Generic;

namespace Payroll
{
    public class HR : Employee
    {
        public List<User> employees{ get; set; }
        public HR(string userName, string passWord, string name, int phone, string positon, InfoToPay info, List<User> e) : base (userName, passWord, name, phone, positon,info)
        {
            infoToPay = new InfoManager();
           if(e.Count > 0) employees = e; 
           else Console.WriteLine("Input employees' ifo");

        }

        public void PrinAll()
        {
            Console.WriteLine(" ___________________________________________________________");
            Console.WriteLine("|ID    name      phone     positon    worked_days   overtime|");
            Console.WriteLine(" -----------------------------------------------------------");
            foreach ( Employee e in employees )
            {
                Console.Write("|{0}    {1}       {2}        {3}          {4}           {5} |",
                e.ID,e.Name,e.Phone,e.Positon,e.infoToPay.WrokedDays,e.infoToPay.OvertimeHours);
                Console.WriteLine();
            }
            Console.WriteLine(" -----------------------------------------------------------");
        }
        public void Edit()
        {
            bool check = true;
            while (check)
            {
                Console.Write(" enter id to edit: ");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach ( Employee e in employees )
                {
                    if ( e.ID == id ) 
                    {
                        Console.WriteLine(" ___________________________________________________________");
                        Console.WriteLine("|ID    name      phone     positon    worked_days   overtime|");
                        Console.WriteLine(" -----------------------------------------------------------");
                        Console.WriteLine("|{0}    {1}       {2}        {3}          {4}           {5} |",
                        e.ID,e.Name,e.Phone,e.Positon,e.infoToPay.WrokedDays,e.infoToPay.OvertimeHours);
                        Console.WriteLine(" -----------------------------------------------------------");
                        while (true)
                        {
                            Console.WriteLine("Enter edit type: ");
                            string type = Console.ReadLine();
                            if(type.ToLower() == "name")
                            {
                                Console.WriteLine("Enter new employee's name: ");
                                string name = Console.ReadLine();
                                e.Name = name;
                            } else if(type.ToLower() == "phone")
                            {
                                Console.WriteLine("Enter employee phone: ");
                                int phone = Convert.ToInt32(Console.ReadLine());
                                e.Phone = phone;
                            }else if(type.ToLower() == "phone")
                            {
                                Console.WriteLine("Enter employee phone: ");
                                int phone = Convert.ToInt32(Console.ReadLine());
                                e.Phone = phone;
                            }else if(type.ToLower() == "positon")
                            {
                                Console.WriteLine("Enter employee positon: ");
                                string position = Console.ReadLine();
                                e.Positon = position;
                                InfoToPay  infoToPay;
                                if(position == "HR" || position.ToLower() == "manager") 
                                {
                                    infoToPay = new InfoManager();
                                }else
                                {
                                    infoToPay = new InfoEmployee();
                                }
                                e.infoToPay = infoToPay;

                            }else if(type == "worked_days")
                            {
                                Console.WriteLine("Enter employee worked days: ");
                                int days = Convert.ToInt32(Console.ReadLine());
                                e.infoToPay.WrokedDays = days;
                            }else if(type == "overtime")
                            {
                                Console.WriteLine("Enter employee overtime: ");
                                int hours = Convert.ToInt32(Console.ReadLine());
                                e.infoToPay.OvertimeHours = hours;
                            }
                            else if(type == "exit")
                            {
                                Console.WriteLine("exit successfuly");
                                check = false;
                                break;
                               
                            }else 
                            {
                                Console.WriteLine("Invalid type");
                                
                            }    
                        } 
                   
                    }else Console.WriteLine("Id not found");
                    
                }
            }
            
        }

        public void Timekeeping()
        {
            foreach ( Employee e in employees )
            {
                Console.WriteLine("Enter employee{0} worked days: ", ID);
                e.infoToPay.WrokedDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee{0} overtime: ", ID);
                e.infoToPay.OvertimeHours = Convert.ToInt32(Console.ReadLine());
            }
        }
      
    }
}