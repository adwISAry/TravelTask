using Microsoft.AspNetCore.Mvc;
using TravelTask.Context;

namespace TravelTask.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ProductController : Controller
    {
        ApplicationDbContext _db {  get; } 
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        
        
      
    }
}
