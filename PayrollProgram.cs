using System;
using System.Collections.Generic;
using System.IO;

namespace Payroll
{
    class PayrollProgram 
    {
       private AdminMenu menu;
       private List<User> users;
       private HRMenu hr;
       private AccountantMenu acc;
       public PayrollProgram()
       {
            users = new List<User>();
            menu = new AdminMenu();
            menu.Run();
            users = menu.admin.Users;
            if(users.Count>0)
            {
                foreach(Employee u in users)
                {
                    bool check = false;
                    while (!check)
                    {
                        Console.Clear();
                        
                        Console.WriteLine();
                        Console.WriteLine("Login");
                        check = u.Login();
                    }
                    if(u.Positon.ToUpper() == "HR")
                    {
                        hr = new HRMenu(users);
                        hr.Run();
                        users = hr.hr.employees;
                    }else if(u.Positon.ToLower() == "accountant")
                    {
                        acc = new AccountantMenu(hr.hr.employees);
                        acc.Run();
                        users =  acc.acc.users;
                    }else 
                    {
                        Console.WriteLine();
                        u.PrintSalary(); 
                    }
                }
           }
       }
       protected  void DoTask(List<User> users)
       { 
           
           
           
       }
       protected void PrintMenu()
       {
           Console.WriteLine("ádasdasd");
       }

      
    }
}
