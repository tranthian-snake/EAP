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
        public int PageSize = 4;
        public ViewResult Index(int productPage = 1) => View(repository.Employees
                    .OrderBy(p => p.Id)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize));
    }
}
