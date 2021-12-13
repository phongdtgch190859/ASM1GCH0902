using System;
namespace Payroll
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }
        private static int count = 0;

        public User()
        {
            UserName = "user";
            Password = "no pasword";
            ID = count++;
        }
        public User(string n, string p)
        {
            UserName = n;
            Password = p;
            ID = ++count;
        }
        public bool Login()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();
            Console.Write("Enter user password: ");
            string password = Console.ReadLine();
            if( UserName == name && Password == password)
            {
                Console.WriteLine(" Login successfuly");
                return true;
            }else 
            {
                Console.WriteLine(" Wrong user or password ");
                return false;
            }

        }
        public void Logout()
        {
            Console.WriteLine("Logout successfuly ");
        }

        public override string ToString()
        {
            return "User name: " + UserName + "Password: " + Password;
        }
    }
}