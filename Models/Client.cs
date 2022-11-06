namespace Herbet_Ioana_Claudia_Lab2.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
