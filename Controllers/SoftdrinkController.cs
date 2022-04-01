using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
    [ApiController, Route("[controller]")]
    public class SoftdrinkController : ControllerBase
    {
        [HttpGet]

        public List<SoftDrink> Get(string softdrinkType = "Coke")
        {
            DrinkFactory drinkFactory = new DrinkFactory(); //creates an object drinkFactory
            ISoftdrink softdrink = drinkFactory.getSoftdrink(softdrinkType); //gets the selected drink
            List<SoftDrink> returnedDrink = new List<SoftDrink>(); //creates a list returnedDrink
            returnedDrink.Add(new SoftDrink { flavour = softdrink.getFlavour(), preference = softdrink.getPreference() }); //adds the drink selected to the list

            return returnedDrink; //returns the drink requested to the user
        }
    }

    

    
}

    