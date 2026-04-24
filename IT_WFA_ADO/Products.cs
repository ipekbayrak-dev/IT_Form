namespace IT_WFA_ADO
{
    public class Products
    {
        public Products(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => $"{Id} - {Name} - {Price:C}";
        
    }
}
