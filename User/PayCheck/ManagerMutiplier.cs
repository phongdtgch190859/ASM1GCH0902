using System;
namespace Payroll
{
    public class ManagerMutiplier : Multiplier
    {
        public ManagerMutiplier()
        {
            TaxRate = 0.2;
            BonusRate = 30;
            CoefficientsSalary = 10;
        }


        public override void PrintRate()
        {
            Console.Write( CoefficientsSalary + "        " + TaxRate + "         " + BonusRate + "         ");
        }
    }
}