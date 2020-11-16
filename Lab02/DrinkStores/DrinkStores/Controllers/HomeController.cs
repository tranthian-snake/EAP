using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrinkStores.Models;
using DrinkStores.Models.ViewModels;

namespace DrinkStores.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View();
        public int PageSize = 4;
        public ViewResult Index(int productPage = 1)
            => View(new ProductListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.Id)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPErPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}
