using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreatTrade.Controllers
{
    public class VisualizarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}