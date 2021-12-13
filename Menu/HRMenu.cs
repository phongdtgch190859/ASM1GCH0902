using System;
using System.Collections.Generic;
namespace Payroll
{
    public class HRMenu : Menu
    {
        public HR hr{ get; set; }
        public HRMenu(List<User> e )
        {
            InfoToPay p = new InfoManager();
            p.Buid();
            hr = new HR("phong","112312","phong",1231231,"manager",p,e);
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1:  hr.Timekeeping();   break;
                case 2:  hr.Edit();          break;
                case 3:  hr.PrinAll();       break;
                case 0:  hr.Logout();        break;
                default: Console.WriteLine("Invalid option please try again"); break;
            }
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("      HR Menu");
            System.Console.WriteLine("1. Timekeeping.");
            System.Console.WriteLine("2. Edit employee's ifo.");
            System.Console.WriteLine("3. Show all employee's ifo.");
            System.Console.WriteLine("0. Logout.");
        }
    }
}