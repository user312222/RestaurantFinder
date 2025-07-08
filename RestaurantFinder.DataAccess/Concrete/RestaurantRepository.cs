using Microsoft.VisualBasic;
using RestaurantFinder.DataAccess.Abstract;
using RestaurantFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFinder.DataAccess.Concrete
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public Restaurant CreateRestaurant(Restaurant restaurant)
        {
            using (var RestaurantDbContext = new RestaurantDbContext())
            {
                RestaurantDbContext.Restaurants.Add(restaurant);
                RestaurantDbContext.SaveChanges();
                return restaurant;
            }
        }

        public void DeleteRestaurant(int id)
        {
            using (var RestaurantDbContext = new RestaurantDbContext())
            {
                var restaurantToDelete = GetRestaurantById(id); 
                if (restaurantToDelete != null)
                {
                    RestaurantDbContext.Restaurants.Remove(restaurantToDelete);
                    RestaurantDbContext.SaveChanges();
                }
            }
        }

        public List<Restaurant> GetAllRestaurants()
        {
            using (var RestaurantDbContext = new RestaurantDbContext())
            {
                return RestaurantDbContext.Restaurants.ToList();
            }
        }

        public Restaurant GetRestaurantById(int id)
        {
            using (var RestaurantDbContext = new RestaurantDbContext())
            {
                return RestaurantDbContext.Restaurants.Find(id);
            }
        }

        public Restaurant UpdateRestaurant(Restaurant restaurant)
        {
            using (var RestaurantDbContext = new RestaurantDbContext())
            {
                var existingRestaurant = GetRestaurantById(restaurant.Id);
                if (existingRestaurant != null)
                {
                    RestaurantDbContext.Restaurants.Update(restaurant);
                    RestaurantDbContext.SaveChanges();
                }
                return restaurant;
            }
        }
    }
}
