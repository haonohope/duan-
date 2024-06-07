using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(8,2)")]
        public Decimal Price { get; set; }
        public long CategoryID { get; set; }
        public Category? Category { get; set; }
        public long SuppilerID { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
