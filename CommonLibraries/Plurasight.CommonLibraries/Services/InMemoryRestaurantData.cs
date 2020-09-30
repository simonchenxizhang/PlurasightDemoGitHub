using Plurasight.CommonLibraries.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Plurasight.CommonLibraries.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant> {
            new Restaurant{ Id = 1, Name = "Simon's Pizza", Cuisine = CuisineType.Italian},
            new Restaurant{ Id = 2, Name = "Monster Currey", Cuisine = CuisineType.Indian},
            new Restaurant{ Id = 3, Name = "Spicy Joint", Cuisine = CuisineType.Chinese},
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing != null) 
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = existing.Cuisine;
            }
        }
    }
}
