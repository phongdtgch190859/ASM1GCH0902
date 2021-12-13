using System;
using System.Collections.Generic;
namespace Payroll
{
    public class AccountantMenu : Menu
    {
        public Accountant acc { get; set; }
        public AccountantMenu(List<User> e)
        {
            InfoToPay p = new InfoEmployee();
            p.Buid();
            acc = new Accountant("phong","112312","phong",1231231,"manager",p,e);
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1:  acc.CaulateSalary();   break;
                case 2:  acc.EditRate();        break;
                case 3:  acc.PrintAllIfo();     break;
                case 0:  acc.Logout(); break;
                default: Console.WriteLine("Invalid option please try again"); break;
            }
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("      Accountant Menu");
            System.Console.WriteLine("1. Caulate Salary.");
            System.Console.WriteLine("2. Edit rate.");
            System.Console.WriteLine("3. Show all employee'ifo.");
            System.Console.WriteLine("0. Logout.");
        }
    }
}