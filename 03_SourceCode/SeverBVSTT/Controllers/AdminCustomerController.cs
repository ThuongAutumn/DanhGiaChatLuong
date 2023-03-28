using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeverBVSTT.Controllers
{
    public class AdminCustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult dm_danhgia()
        {
            return View();
        }
    }
}
