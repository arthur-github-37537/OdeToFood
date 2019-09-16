using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewComponents
{
    // A ViewComponent derives from ViewComponent base class
    public class RestaurantCountViewComponents : ViewComponent
    {
        private readonly IRestaurantData restaurantData;

        // Use a constructor to access the data
        public RestaurantCountViewComponents(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        // There is default method called Invoke.
        public IViewComponentResult Invoke()
        {
            var count = restaurantData.GetCountOfRestaurants();
            return View(count);
        }
    }
}
