using _0104.Models;

namespace _0104.Models
{
    public class OrderItem
    {
        public Product Product {get; set;}
        public double Quantity {get; set;}
        public double PurchasePrice {get; set;}

        
        public bool Validate()
        {
        return true;
        }
        public Customer Retrieve()
        {
        return new Customer();   
        }
        public void Save(Product product)
        {
            
        }
        
    }
}