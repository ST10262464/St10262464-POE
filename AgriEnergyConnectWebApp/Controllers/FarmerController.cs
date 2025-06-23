using AgriEnergyConnectWebApp.Data;
using AgriEnergyConnectWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace AgriEnergyConnectWebApp.Controllers
{
    public class FarmerController : Controller
    {
        private readonly AppDbContext _context;

        public FarmerController(AppDbContext context)
        {
            _context = context;
        }

        // Show farmer's product list
        public IActionResult Index()
        {
            // Check role is Farmer
            if (HttpContext.Session.GetString("UserRole") != "Farmer")
                return RedirectToAction("AccessDenied", "Home");

            var farmerId = HttpContext.Session.GetInt32("FarmerId");
            if (farmerId == null) return RedirectToAction("Login", "Account");

            var products = _context.Products
                .Where(p => p.FarmerId == farmerId)
                .ToList();

            return View(products);
        }

        // Show form to add a product
        public IActionResult AddProduct()
        {
            
            return View();
        }


        // Adapted from Learn Entity Framework Core
        //https://www.learnentityframeworkcore.com/dbset/adding-data
        // Handle form submission to add product
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            

            var farmerId = HttpContext.Session.GetInt32("FarmerId");
            if (farmerId == null) return RedirectToAction("Login", "Account");

            product.FarmerId = farmerId.Value;
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
