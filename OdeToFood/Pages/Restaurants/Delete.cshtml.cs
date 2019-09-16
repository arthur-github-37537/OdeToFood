using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core; // Contains Restaurant class
using OdeToFood.Data; // Contains code for connection to database

namespace OdeToFood.Pages.Restaurants
{
    public class DeleteModel : PageModel
    {
        // Restaurants contained in database
        private readonly IRestaurantData restaurantData;
        // particular Restaurant
        public Restaurant Restaurant { get; set; }

        // constructor gets all restaurants
        public DeleteModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        // Execute this code when the page loads
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        // Execute this code when the user confirms the delete
        public IActionResult OnPost(int restaurantId)
        {
            var restaurant = restaurantData.Delete(restaurantId);
            restaurantData.Commit();

            if(restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{restaurant.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}