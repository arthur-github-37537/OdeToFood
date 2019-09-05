using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFood.Pages.HelloWorld
{
    public class HelloWorldModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Hello World; Lekker creatief! Ga een eind fietsen ofzo.";
        }
    }
}