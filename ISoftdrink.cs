using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


public interface ISoftdrink

//blueprint for creating the user's drink
{

string getFlavour();
bool getPreference();

}