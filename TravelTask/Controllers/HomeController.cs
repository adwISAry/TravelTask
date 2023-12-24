using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelTask.Context;
using TravelTask.Models;
using Microsoft.EntityFrameworkCore;
using TravelTask.ViewModels;
using TravelTask.Areas.Admin.ViewModels;
using TravelTask.ViewModels.HomeIndexVM;

namespace TravelTask.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context { get; }

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeIndex();
            model.Products = (await _context.Products.ToListAsync()).Select(a => new AdminProductListItemVM()
            {
                Id = a.Id,
                Name = a.Name,
                Price = a.Price,
                ImageUrl = a.ImageUrl,
            });
            return View(model);
        }

    }
}







