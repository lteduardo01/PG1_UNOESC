namespace _0104.Models
{
    public class Product
    {
        public string ProductName { get; set;}
        public string Description { get; set;}
        public float CurrentPrice { get; set;}
        public bool Validate()
        {
        return true;
        }
        public Product Retrieve()
        {
        return new Product();   
        }
        public void Save(Product product)
        {
            
        }
    
    
    
    
    
    }
}