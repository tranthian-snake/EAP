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
                         Category="Milk"
                     },
                     new Product
                     {
                         Name = "Soymilk",
                         Description = "Everything you need to know about soy milk",
                         Img = "https://img1.mashed.com/img/uploads/2017/05/soy-milk.jpg",
                         Price = 45,
                         Discount = 2.5,
                         Status = "stocking",
                         Category = "Milk"
                     },
                     new Product
                     {
                         Name = "Orange juice",
                         Description = "Fresh Squeezed Orange Juice",
                         Img = "https://www.earthfoodandfire.com/wp-content/uploads/2018/04/Homemade-Orange-Juice.jpg",
                         Price = 48,
                         Discount = 5.0,
                         Status = "out of stock",
                         Category= "Juice"
                     },
                     new Product
                     {
                         Name = "Apple juice",
                         Description = "So, What's the Difference Between Apple Cider and Apple Juice?",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/apple-cider-vs-apple-juice-difference-1565205829.jpg?crop=1.00xw:0.753xh;0,0.247xh&resize=1200:*",
                         Price = 50,
                         Discount = 0,
                         Status = "stocking",
                         Category= "Juice"
                     },
                     new Product
                     {
                         Name = "Barley milk",
                         Description = "Barley milk is the latest alternative milk",
                         Img = "https://stylesatlife.com/wp-content/uploads/2018/12/Uses-of-Barley-Water-During-Pregnancy-1.jpg",
                         Price = 45,
                         Discount = 2.5,
                         Status = "stocking",
                         Category = "Milk"
                     },
                     new Product
                     {
                         Name = "Watermelon juice",
                         Description = "How to Make Our Easy Watermelon Juice Recipe",
                         Img = "https://www.tasteofhome.com/wp-content/uploads/2019/04/watermelon-juice-shutterstock_285112223.jpg",
                         Price = 48,
                         Discount = 5.0,
                         Status = "out of stock",
                         Category ="Juice"
                     },
                     new Product
                     {
                         Name = "Lemonade",
                         Description = "What is Italian Lemonade ? -Bentley's Roast Beef",
                         Img = "https://bentleysroastbeef.com/wp-content/uploads/2019/08/italian-lemonade-1400x933.jpg",
                         Price = 48,
                         Discount = 5.0,
                         Status = "stocking",
                         Category = "Juice"
                     },
                     new Product
                     {
                         Name = "Pineapple juice",
                         Description = "Pineapple Juice Recipe",
                         Img = "https://media.healthplus.vn/thumb_x650x382/Images/Uploaded/Share/2018/05/28/nuoc-dua-thanh-loc-co-the-ngay-he11527560591.PNG",
                         Price = 48,
                         Discount = 5.0,
                         Status = "stocking",
                         Category = "Juice"
                     }

                );
                context.SaveChanges();
            }
        }
    }
}