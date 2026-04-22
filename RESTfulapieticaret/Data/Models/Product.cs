using System.Text.Json.Serialization; // تأكد من إضافة هذا السطر في الأعلى

namespace RESTfulapieticaret.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore] // هذا هو الحل! سيمنع الدوران اللانهائي
        public Category? Category { get; set; }
    }
}