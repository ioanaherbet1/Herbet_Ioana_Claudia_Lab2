namespace Herbet_Ioana_Claudia_Lab2.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ClientID { get; set; }
        public int BookID { get; set; }

        public Client Client { get; set; }
        public Book Book { get; set; }
    }
}
