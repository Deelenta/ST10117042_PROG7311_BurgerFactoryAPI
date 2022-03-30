using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class VeggieBurger : IBurger
{
    public string getBun()
    {
        return "Wholewheat";
    }

    public string getPatty()
    {
        return "Mushroom";
    }
}
