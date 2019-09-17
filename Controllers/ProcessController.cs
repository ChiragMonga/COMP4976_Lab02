using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcFire.Controllers
{
<<<<<<< HEAD
    public class ProcessController : Controller
=======
public class ProcessController : Controller
>>>>>>> 1bc98d329d74dceb5cfef8c6f661f34191b16056
    {
        public IActionResult Index()
        {
            Process[] p = Process.GetProcesses();
            //ViewData["processes"] = p;
            ViewBag.processes = p;
            return View();
        }

        public IActionResult Welcome()
        {
            Process[] p = Process.GetProcesses();
            return View(p);
        }

        public IActionResult Display(int id)
        {
            Process p = Process.GetProcessById(id);
            return View(p);
        }
    }
}
