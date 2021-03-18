using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChekingSys.Controllers
{
    public class WorkersController1 : Controller
    {
        public IActionResult WIndex()
        {
            return View();
        }
    }
}
