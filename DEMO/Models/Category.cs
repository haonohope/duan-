namespace DEMO.Models
{
    public class Category
    {
        public long CategoryID { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable <Product>? Products { get; set; }
    }
}
