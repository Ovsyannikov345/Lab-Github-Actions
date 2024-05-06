namespace DiscountSystem
{
    public class Order
    {
        public ClientType ClientType { get; private set; }

        public int ItemsCount { get; private set; }

        public int TotalPrice { get; private set; }

        public Order(ClientType clientType, int itemsCount, int totalPrice)
        {
            ClientType = clientType;
            ItemsCount = itemsCount;
            TotalPrice = totalPrice;
        }
    }
}
