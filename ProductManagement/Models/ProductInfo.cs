namespace ProductManagement.Models
{
    public class ProductInfo
    {
         
        public int Product_Id { get; set; }
        public int Category_Id { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrices { get; set; }
        public DateTime CreationDate { get; set; }
        
    }

}
