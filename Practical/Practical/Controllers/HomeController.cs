using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practical.Models;

namespace Practical.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository repository;
        public HomeController(IEmployeeRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View();
    }
}
