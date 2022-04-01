using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class Coke : ISoftdrink
{

    //returns the flavour of the drink
    public string getFlavour()
    {
        return "coke";
    }

    //finds out if the drink is diet or not
    public bool getPreference()
    {
        return true;
    }

}