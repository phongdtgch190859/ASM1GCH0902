namespace Payroll
{
    public class InfoManager : InfoToPay
    {
        public override Multiplier GetMultiplier()
        {
            return new ManagerMutiplier();
        }
    }
}
