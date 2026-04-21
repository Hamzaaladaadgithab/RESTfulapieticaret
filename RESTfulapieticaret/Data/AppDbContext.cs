
using Microsoft.EntityFrameworkCore;

using RESTfulapieticaret.Data.Models;

namespace RESTfulapieticaret.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        // هنا نحدد الجداول! اسم الخاصية سيكون هو اسم الجدول في قاعدة البيانات
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تحديد دقة السعر: 18 رقماً كلياً، منها 2 بعد الفاصلة
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }

    }

    }

        



    

