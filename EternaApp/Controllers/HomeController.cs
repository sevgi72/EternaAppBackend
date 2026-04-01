using System.Diagnostics;
using EternaApp.Data;
using EternaApp.Models;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class HomeController(EternaAppDbContext context)   : Controller
    {
        public IActionResult Index()
        {
            var sliders = context.Sliders.ToList();
            var features = context.Features.ToList();
            var homeVm = new HomeVm
            {
                Sliders = sliders,
                Features=features
            };

            return View(homeVm);
        } 
    }
}
