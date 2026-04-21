namespace RESTfulapieticaret.Data.Models
{
    public class Product
    {


        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        // المفتاح الأجنبي (Foreign Key) لربط المنتج بقسم معين
        public int CategoryId { get; set; }

        // خاصية التنقل (Navigation Property) للوصول لبيانات القسم بسهولة
        public Category Category { get; set; }


    }
}
