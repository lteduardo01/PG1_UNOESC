using _0104.Models;

namespace _0104.Models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAdress { get; set; }

        public bool Validate()
        {
        return true;
        }
        public Customer Retrieve()
        {
        return new Customer();   
        }

        public void Save(Customer customer)
        {
            
        }







    }
}