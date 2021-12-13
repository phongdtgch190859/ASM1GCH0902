using System;
using System.Collections.Generic;
namespace Payroll
{
    public class Employee : User
    { 
 
        public string Name { get; set; }

        public int Phone { get; set; }
        public int Salary { get; set; }
        public InfoToPay infoToPay { get; set; }
        public string Positon { get; set; }

        public Employee(string userName, string passWord, string name, int phone, string positon, InfoToPay info)
        {
            UserName = userName;
            Password = passWord;
            Name = name;
            Phone = phone;
            Positon = positon;
            infoToPay = info;
        }
 
        public void PrintSalary()
        {
            Console.WriteLine("Name: " + Name  + " , salary: " + Salary);
        }
        public void PrintIfo()
        {
            Console.Write("|{0}   {1}    {2}    {3}     ",ID,Name,infoToPay.WrokedDays, infoToPay.OvertimeHours);
            infoToPay.multiplier.PrintRate();
            Console.Write("        " + Salary + " |");
        }

    

    }
}