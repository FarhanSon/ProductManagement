namespace ProductManagement.Models
{
    public class CategoryInfo
    {
        public int Category_Id { get; set; }
        public string CategoryTitle { get; set; }
        public decimal CategoryPrize { get; set; }
        public DateTime CreationDate { get; set; }

        public int TotalRowCount { get; set; }
    }

    public class CategoryInfoModel
    { 
      private List<CategoryInfo> _categories=new List<CategoryInfo>();

        public List<CategoryInfo> CategoriesList
        { 
            get {  return _categories; } 
            set { _categories = value; }
        
        }
    }
}
