using RestaurantFinder.Business.Abstract;
using RestaurantFinder.DataAccess.Abstract;
using RestaurantFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFinder.Business.Concrete
{
    public class RestaurantManager : IRestaurantService
    {
        private IRestaurantRepository _restaurantRepository;

        public RestaurantManager(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public Restaurant CreateRestaurant(Restaurant restaurant)
        {
            return _restaurantRepository.CreateRestaurant(restaurant);
        }

        public void DeleteRestaurant(int id)
        {
            _restaurantRepository.DeleteRestaurant(id);
        }

        public List<Restaurant> GetAllRestaurants()
        {

            return _restaurantRepository.GetAllRestaurants();
        }

        public Restaurant GetRestaurantById(int id)
        {
            if (id > 0)
            {
            return _restaurantRepository.GetRestaurantById(id);
            }
            throw new Exception("Invalid restaurant ID.");
        }

        public Restaurant UpdateRestaurant(Restaurant restaurant)
        {
            return _restaurantRepository.UpdateRestaurant(restaurant); 
        }
    }
}
