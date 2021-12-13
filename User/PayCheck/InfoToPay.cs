using System;
namespace Payroll
{
    public abstract class InfoToPay
    {
        public  int BasicSlary = 100000;
        public int WrokedDays { get; set; }
        public int OvertimeHours { get; set; }
        public Multiplier multiplier;
        public abstract Multiplier GetMultiplier(); 
    

        public void Buid()
        {
            multiplier = GetMultiplier();
        }

        
    }
    
}