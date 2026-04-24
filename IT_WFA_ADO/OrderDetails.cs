namespace IT_WFA_ADO
{
    public class OrderDetails
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        public decimal Discount { get; set; }

        public OrderDetails(string productName, decimal price, short quantity, decimal discount)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"{ProductName} - {Price} - {Quantity} - {Discount}";
        }
    }
}
