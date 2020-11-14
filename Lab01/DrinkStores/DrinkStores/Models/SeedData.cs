using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace DrinkStores.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService <StoreDbContext> ();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                     new Product
                     {
                         Name = "Milk 100%",
                         Description = "Good Housekeeping:Goat Milk Nutrition - Health Benefits of Goat Milk",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/health-benefits-of-goat-milk-1586900792.jpg?crop=0.668xw:1.00xh;0.259xw,0&resize=480:*",
                         Price = 45.32m,
                         Discount = 2.5,
                         Status = "stocking"
                     },
                     new Product
                     {
                         Name = "Coca cola",
                         Description = "Nước ngọt Coca Cola 320ml",
                         Img = "https://cdn.tgdd.vn/Products/Images/2443/76451/bhx/nuoc-ngot-coca-cola-330ml-201912091400292591.jpg",
                         Price = 25.80m,
                         Discount = 1.0,
                         Status = "stocking"
                     },
                     new Product
                     {
                         Name = "Orange juice",
                         Description = "Fresh Squeezed Orange Juice",
                         Img = "https://www.earthfoodandfire.com/wp-content/uploads/2018/04/Homemade-Orange-Juice.jpg",
                         Price = 48.90m,
                         Discount = 5.0,
                         Status = "out of stock"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
