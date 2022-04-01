using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI{
    public class DrinkFactory{
        public ISoftdrink returnInstance;

        public ISoftdrink getSoftdrink(String softdrinkType){

            //selects the users choice of drink
            switch(softdrinkType){
                case("coke"):
                returnInstance = new Coke();
                break;
                case("pepsi"):
                returnInstance = new Pepsi();
                break;
                case("cream soda"):
                returnInstance = new Creamsoda();
                break;
                
            }

            return returnInstance;
        }
    }
}