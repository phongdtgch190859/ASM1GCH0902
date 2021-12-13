using System;
using System.Collections.Generic;
namespace Payroll
{
    public class Admin
    {
        public List<User> Users { get; set; }
        // private List<Employee> employees { get; set; }
        
        public Admin()
        {
            Users = new List<User>();

            
            // employees = new List<Employee>();
        }
        public void PrintAll()
        {
            Console.WriteLine(" ______________________________");
            Console.WriteLine("|ID   name    phone   positon  |");
            Console.WriteLine(" ------------------------------");
            foreach ( Employee e in Users )
            {
                Console.Write("|{0}   {1}     {2}     {3} |",
                e.ID,e.Name,e.Phone,e.Positon,e.infoToPay);
                Console.WriteLine();
            }
            Console.WriteLine(" ------------------------------");

        }
        public void AddUser()
        {
            Console.Write("Enter user name: ");
            string username = Console.ReadLine();
            Console.Write("Enter user password: ");
            string password = Console.ReadLine();
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee phone: ");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee positon: ");
            string position = Console.ReadLine();
            InfoToPay  infoToPay;
            if(position == "HR" || position.ToLower() == "manager") 
            {
                infoToPay = new InfoManager();
                infoToPay.Buid();
            }else
            {
                infoToPay = new InfoEmployee();
                infoToPay.Buid();
            }
            User p = new Employee(username,password,name,phone,position,infoToPay);
            Users.Add(p);
            Console.WriteLine();
        
        }
        public void DeleteUser(int id)
        {
            foreach( Employee u in Users)
            {
                if(u.ID == id) Users.RemoveAt(id);
                else Console.WriteLine("id not found");
            }
        }
        public void EditUser(int id)
        {
            foreach( Employee u in Users)
            {
                if(u.ID == id)
                {
                    Console.Write("Enter user name: ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter user password: ");
                    string password = Console.ReadLine();
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter employee phone: ");
                    int phone = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter employee positon: ");
                    string position = Console.ReadLine();
                    InfoToPay  infoToPay;
                    if(position == "HR" || position.ToLower() == "manager") 
                    {
                        infoToPay = new InfoManager();
                    }else
                    {
                        infoToPay = new InfoEmployee();
                    }
                    u.UserName = userName;
                    u.Password = password;
                    u.Phone = phone;
                    u.Positon = position;
                    u.infoToPay = infoToPay;
                } 
                else Console.WriteLine("id not found");
            }
            
        }
        public void Search(int id)
        {
            foreach( User u in Users)
            {
                if(u.ID == id) Console.WriteLine(u);
                else Console.WriteLine("id not found");
            }
        }



    }
}