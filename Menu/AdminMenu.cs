using System;
using System.Collections.Generic;
namespace Payroll
{
    public class AdminMenu : Menu
    {
        public Admin admin { get; set; }
        public AdminMenu( )
        {
            
            admin = new Admin();
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: admin.AddUser();    break;
                case 2:
                {
                    Console.Write("Enter id to delete: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    admin.DeleteUser(id);
                    break;
                } 
                case 3:
                {
                    Console.Write("Enter id to search: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    admin.Search(id); 
                    break;
                } 
                case 4: 
                {
                    Console.Write("Enter id to search: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    admin.EditUser(id);   
                    break;
                }
                case 5: admin.PrintAll();   break;
                case 0: admin.Logout(); break;
                default: Console.WriteLine("Invalid option please try again"); break;
            }
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("Admin Menu");
            System.Console.WriteLine("1. Add user.");
            System.Console.WriteLine("2. Delete user.");
            System.Console.WriteLine("3. Search user");
            System.Console.WriteLine("4. Edit user.");
            System.Console.WriteLine("5. Show all user.");
            System.Console.WriteLine("0. Logout.");
        }
    }
}