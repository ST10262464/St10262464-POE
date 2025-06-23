using AgriEnergyConnectWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnectWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }


        // Adapted from Microsoft
        // https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-9.0
        // Show login page
        public IActionResult Login() => View();

        // Handle login form submission
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Try farmer login
            var farmer = _context.Farmers.FirstOrDefault(f => f.Email == email && f.PasswordHash == password);
            if (farmer != null)
            {
                HttpContext.Session.SetInt32("FarmerId", farmer.FarmerId);
                HttpContext.Session.SetString("UserRole", "Farmer");    
                return RedirectToAction("Index", "Home");
            }

            // Try employee login
            var employee = _context.Employees.FirstOrDefault(e => e.Email == email && e.PasswordHash == password);
            if (employee != null)
            {
                HttpContext.Session.SetInt32("EmployeeId", employee.EmployeeId);
                HttpContext.Session.SetString("UserRole", "Employee");  
                return RedirectToAction("Index", "Home");
            }

            // Invalid credentials
            ViewBag.Error = "Invalid login";
            return View();
        }

    }
}

