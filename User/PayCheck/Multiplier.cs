using System;
namespace Payroll
{
    public abstract class Multiplier
    {

        public double TaxRate { get; set; }
        public int BonusRate { get; set; }
        public int CoefficientsSalary { get; set; }

        public abstract void PrintRate();
     
        
       
    }

}