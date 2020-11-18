using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Category.Any())
            {
                context.Category.AddRange(
                    new Category
                    {
                        CategoryName = "Milk"
                    },
                    new Category
                    {
                        CategoryName = "Juice"
                    }
                    );
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                     new Product
                     {
                         Name = "Milk 100%",
                         Description = "Good Housekeeping:Goat Milk Nutrition - Health Benefits of Goat Milk",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/health-benefits-of-goat-milk-1586900792.jpg?crop=0.668xw:1.00xh;0.259xw,0&resize=480:*",
                         Price = 45m,
                         Discount = 2.5,
                         Status = "stocking",
                         CategoryID = 1
                     },
                     new Product
                     {
                         Name = "Milk 100%",
                         Description = "Good Housekeeping:Goat Milk Nutrition - Health Benefits of Goat Milk",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/health-benefits-of-goat-milk-1586900792.jpg?crop=0.668xw:1.00xh;0.259xw,0&resize=480:*",
                         Price = 45,
                         Discount = 2.5,
                         Status = "stocking",
                         CategoryID = 1
                     },
                     new Product
                     {
                         Name = "Orange juice",
                         Description = "Fresh Squeezed Orange Juice",
                         Img = "https://www.earthfoodandfire.com/wp-content/uploads/2018/04/Homemade-Orange-Juice.jpg",
                         Price = 48,
                         Discount = 5.0,
                         Status = "out of stock",
                         CategoryID = 2
                     },
                     new Product
                     {
                         Name = "Orange juice",
                         Description = "Fresh Squeezed Orange Juice",
                         Img = "https://www.earthfoodandfire.com/wp-content/uploads/2018/04/Homemade-Orange-Juice.jpg",
                         Price = 48,
                         Discount = 5.0,
                         Status = "out of stock",
                         CategoryID = 2
                     },
                     new Product
                     {
                         Name = "Milk 100%",
                         Description = "Good Housekeeping:Goat Milk Nutrition - Health Benefits of Goat Milk",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/health-benefits-of-goat-milk-1586900792.jpg?crop=0.668xw:1.00xh;0.259xw,0&resize=480:*",
                         Price = 45,
                         Discount = 2.5,
                         Status = "stocking",
                         CategoryID = 1
                     }

                );
                context.SaveChanges();
            }
        }
    }
}