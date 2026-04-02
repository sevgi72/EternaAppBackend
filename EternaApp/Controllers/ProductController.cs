using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Controllers
{
    public class ProductController(EternaAppDbContext context) : Controller
    {
        public IActionResult Index()
        {
            ProductVm productVm = new ProductVm
            {
                Categories = context.Categories.ToList(),
                Product = context.Products
                .Include(i => i.ProductImages)
                .ToList()
            };
            return View(productVm);
        }


        public IActionResult Detail(int id)
        {
            var product = context.Products
                .Include(i => i.ProductImages)
                .Include(i => i.Category)
                .FirstOrDefault(i => i.Id == id);
            if (product == null)
            {
                return View(NotFound());
            }
            return View(product);
        }
    }
}
