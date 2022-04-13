using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.Controllers
{
    public class Movie_DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
