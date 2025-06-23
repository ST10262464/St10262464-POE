using AgriEnergyConnectWebApp.Data;
using AgriEnergyConnectWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace AgriEnergyConnectWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // Show dashboard with list of farmers
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserRole") != "Employee")
                return RedirectToAction("AccessDenied", "Home");

            return View(_context.Farmers.ToList());
        }

        // Show form to add a farmer
        public IActionResult AddFarmer()
        {
            

            return View();
        }



        // Adapted from Learn Entity Framework Core
        //https://www.learnentityframeworkcore.com/dbset/adding-data
        // Handle form submission to add a farmer
        [HttpPost]
        public IActionResult AddFarmer(Farmer farmer)
        {
            
            _context.Farmers.Add(farmer);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        // Show filtered list of farmer's products
        public IActionResult ViewProducts(int farmerId, string category, DateTime? from, DateTime? to)
        {
            

            var query = _context.Products.Where(p => p.FarmerId == farmerId);

            if (!string.IsNullOrEmpty(category))
                query = query.Where(p => p.Category == category);

            if (from.HasValue)
                query = query.Where(p => p.ProductionDate >= from.Value);

            if (to.HasValue)
                query = query.Where(p => p.ProductionDate <= to.Value);

            ViewBag.FarmerId = farmerId;
            return View(query.ToList());
        }
    }
}
