using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;

namespace CampingApp.Infrastructure.data
{
    public static class DbSeeding
    {
        public static void SeedDatabase(CampingDbContext dbContext)
        {
            SeedCategoryIfNotExist(dbContext);
            SeedProductIfNotExist(dbContext);
            SeedUserIfNotExist(dbContext);
        }

        private static void SeedUserIfNotExist(CampingDbContext dbContext) // varsayılan bir admini sunum icin olusturdum.
        {
            if (!dbContext.Users.Any())
            {
                var users = new List<User>()
                {
                    new() { UserName = "gani", Email = "gani@gmail.com", Password = "123", Role = "Admin" }
                };
                dbContext.Users.AddRange(users);
                dbContext.SaveChanges();
            }
        }

        private static void SeedCategoryIfNotExist(CampingDbContext dbContext)
        {
            if (!dbContext.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new() { CategoryName = "Çadırlar",CategoryDescription = "Çadırlar Ve Gölgelikler" },
                    new() { CategoryName = "Mutfak", CategoryDescription = "Kamp Mutfak Araçları" },
                    new() { CategoryName = "Uyku", CategoryDescription = "Kamp Uyku Ekipmanları" },
                    new() { CategoryName = "Lamba", CategoryDescription = "Kamp Aydınlatma Ekipmanları" }
                };
                dbContext.Categories.AddRange(categories);
                dbContext.SaveChanges();
            }
        }

        private static void SeedProductIfNotExist(CampingDbContext dbContext)
        {
            if (!dbContext.Products.Any())
            {
                var products = new List<Product>()
                {
                    new()
                    {
                        ProductName = "Aprenaz 4.1", ProductCategoryID = 1,
                        ProductImageUrl =
                            "https://contents.mediadecathlon.com/p1749711/k$9ffdc2b29978c4d079ad0f620d315b42/sq/8562098.jpg?format=auto&f=320x320",
                        ProductPrice = 5000
                    },
                    new()
                    {
                        ProductName = "Aprenaz 5.1", ProductCategoryID = 1,
                        ProductImageUrl =
                            "https://contents.mediadecathlon.com/p2425700/k$bd8d38a8b9d2502c20c3a5d6b99f2178/sq/8755590.jpg?format=auto&f=320x320",
                        ProductPrice = 3000
                    },
                    new()
                    {
                        ProductName = "Aprenaz 1.1", ProductCategoryID = 1,
                        ProductImageUrl =
                            "https://contents.mediadecathlon.com/p2376651/k$b870360d2f4d17881bf132a7c689d13b/sq/8576111.jpg?format=auto&f=320x320",
                        ProductPrice = 2500
                    },
                    new()
                    {
                        ProductName = "MH150", ProductCategoryID = 1,
                        ProductImageUrl =
                            "https://contents.mediadecathlon.com/p2218691/k$5ecf447b877a99a6f94f10f052c7f6f2/sq/8734425.jpg?format=auto&f=320x320",
                        ProductPrice = 2200
                    },
                    new()
                    {
                        ProductName = "MH500", ProductCategoryID = 2,
                        ProductImageUrl =
                            "https://contents.mediadecathlon.com/p1701383/k$b079f4773ab59e136b17da8e9132d234/sq/8492728.jpg?format=auto&f=320x320",
                        ProductPrice = 900
                    },
                    new()
                    {
                        ProductName = "Termos", ProductCategoryID = 2,
                        ProductImageUrl =
                            "https://contents.mediadecathlon.com/p2203059/k$373f04ace8143ff1e65fd146d6afc34e/sq/8734555.jpg?format=auto&f=320x320",
                        ProductPrice = 450
                    },
                    new()
                    { 
                        ProductName = "Çaydanlık", ProductCategoryID = 2,
                        ProductImageUrl =
                            "https://contents.mediadecathlon.com/p1334726/k$2959748a98e6bd5d6771e314e677a054/sq/8504347.jpg?format=auto&f=320x320",
                        ProductPrice = 350
                    }
                };
                dbContext.Products.AddRange(products);
                dbContext.SaveChanges();
            }
        }
    }
}
