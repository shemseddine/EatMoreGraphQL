using EatMore.API.Models;
using System;
using System.Linq;

namespace EatMore.API
{
    public class DataSeed
    {
        public static void Run(AppContext db)
        {
            if (!db.Restaurants.Any())
            {
                db.Restaurants.Add(
                    new Restaurant
                    {
                        Id = Guid.NewGuid(),
                        Name = "Boba",
                        Menus = new[]
                    {
                        new Menu
                        {
                            Id = Guid.NewGuid(),
                            Name = "Drinks",
                            MenuItems = new[]
                            {
                                new MenuItem
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Cola",
                                    Description = "Our home made cola",
                                    Price = 3.5m,
                                    SuitableForVegetarian = true
                                }
                            }
                        }
                    }
                });
                db.SaveChanges();
            }
        }
    }
}
