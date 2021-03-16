using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChekingSys.Controllers
{
    public class WorkersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
