using System.Text.Json.Serialization;

namespace RESTfulapieticaret.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [JsonIgnore] // أضفه هنا أيضاً
        public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}