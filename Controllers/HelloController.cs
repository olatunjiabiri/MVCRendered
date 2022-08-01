using Microsoft.AspNetCore.Mvc;
using MVCRendered.Models;

namespace MVCRendered.Controllers
{
    public class HelloController : Controller
    {
        private static List<CatViewModel> cats = new List<CatViewModel>();
        public IActionResult Index()
        {         
                        
            return View(cats);
        }

        public IActionResult CreateNewCat() 
        {
            var catVm = new CatViewModel();
            return View(catVm);
        }

        public IActionResult CreateCat(CatViewModel catViewModel) 
        {
            cats.Add(catViewModel);
            return RedirectToAction(nameof(CreateNewCat));

            //return RedirectToAction(nameof(Index));
            //return View("Index");
        }
    }
}
