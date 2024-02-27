using Microsoft.AspNetCore.Mvc;
using ReastaurantAPI.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ReastaurantAPI.Controllers
{
    [Route("api/restaurant")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantDbcontext _dbContext;
        public RestaurantController(RestaurantDbcontext dbcontext)
        {
            _dbContext = dbcontext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> GetAall()
        {
            var restaurants = _dbContext
                .Restaurants
                .ToList();
            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        public ActionResult<Restaurant> Get([FromRoute]int id)
        {
            var restaurant = _dbContext
                .Restaurants
                .FirstOrDefault(r => r.Id == id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return Ok(restaurant);
        }
    }
}
