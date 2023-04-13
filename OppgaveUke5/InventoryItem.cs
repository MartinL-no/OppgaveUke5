namespace OppgaveUke5
{
    public abstract class InventoryItem
    {
        protected string Name;
        protected uint Quantity;
        protected double Price;

        protected InventoryItem(string name, uint quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}