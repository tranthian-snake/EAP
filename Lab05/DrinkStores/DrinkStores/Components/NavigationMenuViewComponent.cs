using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DrinkStores.Models;

namespace DrinkStores.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        //public string Invoke()
        //{
        //    return "Hello from the Mav View Component";
        //}

        public IStoreRepository repository;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
