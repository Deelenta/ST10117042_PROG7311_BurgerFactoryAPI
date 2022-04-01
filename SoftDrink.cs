using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI{

    public class SoftDrink
    {
        //get and set methods for the softdrink
        public string flavour{get; set;}

        public bool preference{get; set;}
    }
}