using RestaurantFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFinder.Business.Abstract
{
    public interface IRestaurantService
    {

        List<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(int id);
        Restaurant CreateRestaurant(Restaurant restaurant);
        Restaurant UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int id);
    }
}
