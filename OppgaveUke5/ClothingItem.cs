namespace OppgaveUke5
{
    public class ClothingItem : InventoryItem, ISellable
    {
        private string _size;
        private string _colour;

        public ClothingItem(string name, uint quantity, double price, string size, string colour)
            : base(name, quantity, price)
        {
            // I placed the parameter checking in the subsclass as NUnit was not picking up the exception when it was thrown in the superclass
            if (Quantity < 1 || price < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _size = size;
            _colour = colour;
        }

        public double CalculateSalePrice()
        {
            return Price * Quantity;
        }
    }
}