using System;
namespace Payroll
{
    public class InfoEmployee : InfoToPay
    {
        
        public override Multiplier GetMultiplier()
        {
            return new EmployeeMutiplier();
        }
    
    }
}
