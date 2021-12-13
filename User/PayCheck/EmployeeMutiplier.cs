using System;
namespace Payroll
{
    public class EmployeeMutiplier : Multiplier
    {
        public EmployeeMutiplier()
        {
            TaxRate = 0.1;
            BonusRate = 15000;
            CoefficientsSalary = 5;

        }
        public override void PrintRate()
        {
            Console.Write( CoefficientsSalary + "        " + TaxRate + "         " + BonusRate + "         ");
        }

    }
    
}