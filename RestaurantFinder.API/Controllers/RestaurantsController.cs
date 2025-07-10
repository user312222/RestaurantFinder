using Microsoft.AspNetCore.Mvc;
using RestaurantFinder.Business.Abstract;
using RestaurantFinder.Entities;

namespace RestaurantFinder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private IRestaurantService _restaurantService;
        public RestaurantsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet("{id}")]
        public Restaurant Get(int id )
        {
            return _restaurantService.GetRestaurantById(id);
        }

        [HttpGet]
            public List<Restaurant> Get()
            {
                return _restaurantService.GetAllRestaurants();
        }
        [HttpPost] 
        public Restaurant Post([FromBody] Restaurant restaurant)
        {
            return _restaurantService.CreateRestaurant(restaurant);
        }
        [HttpPut]
        public Restaurant Put([FromBody] Restaurant restaurant)
        {
            return _restaurantService.UpdateRestaurant(restaurant);
        }
        [HttpDelete("{id}")] 
        public void Delete(int id)
        {
            _restaurantService.DeleteRestaurant(id);
        }


    }
}
