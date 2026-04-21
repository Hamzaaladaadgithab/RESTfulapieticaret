using System.ComponentModel.DataAnnotations;

namespace RESTfulapieticaret.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        // علاقة 1 إلى متعدد: القسم الواحد يحتوي على عدة منتجات
        public ICollection<Product> Products { get; set; } = new List<Product>();




    }
}
