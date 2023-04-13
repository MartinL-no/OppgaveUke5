namespace OppgaveUke5
{
    public class ElectronicItem : InventoryItem, ISellable
    {
        private string _insuranceTerm;
        private int _voltage;

        public ElectronicItem(string name, uint quantity, double price, string insuranceTerm, int voltage = 230)
            : base(name, quantity, price)
        {
            var voltages = new[] { 110, 120, 230, 240 };

            // I placed the parameter checking in the subsclass as NUnit was not picking up the exception when it was thrown in the superclass
            if (Quantity < 1 || price < 0 || !voltages.Contains(voltage))
            {
                throw new ArgumentOutOfRangeException();
            }
            _insuranceTerm = insuranceTerm;
            _voltage = voltage;
        }

        public double CalculateSalePrice()
        {
            return Price * Quantity;
        }
    }
}