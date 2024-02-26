using Newtonsoft.Json.Linq;
using ReastaurantAPI.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ReastaurantAPI
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbcontext _dbContext;

        public RestaurantSeeder(RestaurantDbcontext dbContext)
        {
            _dbContext = dbContext;
            
        }
        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Description = "KFC (short for Kentucky Fried Chicken) is an American fast food restaurant chain headquartered in Louisville, Kentucky, that specializes in fried chicken.",
                    Category = "Fast Food",
                    HasDelivery = true,
                    ContactEmail = "contact@kfc.com",
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Nashville Hot Chicken",
                            Price = 10.30M,
                        },
                        new Dish()
                        {
                            Name = "Chicken Nuggets",
                            Price = 5.30M,
                        },
                    },
                    Address = new Address()
                    {
                        City =  "Wrocław",
                        Street = "Świdnicka 13 ",
                        PostalCode = "50-066"
                    }

                },
                new Restaurant()
                {
                    Name = "McDonald",
                    Description = "McDonald's Corporation is an American multinational fast food chain, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.",
                    Category = "Fast Food",
                    HasDelivery = true,
                    ContactEmail = "contact@mcd.com",
                    Dishes = new List<Dish>
                    {
                        new Dish()
                        {
                            Name = "Big Mac",
                            Price = 15.50M,
                        },
                        new Dish()
                        {
                            Name = "Cheessburger",
                            Price = 2.10M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Wrocław",
                        Street = "Rynek 30",
                        PostalCode = "50-102"
                    }
                }
            };
            return restaurants;
        }
    }
}
