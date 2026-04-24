namespace IT_WFA_ADO
{
    public class Orders
    {
        public Orders(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Date:d}";
        }
    }
}
