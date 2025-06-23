namespace AgriEnergyConnectWebApp.Models
{

    // Adapted from Microsoft
    // https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
    public class Employee
    {
        public int EmployeeId { get; set; }   // Primary key
        public string FullName { get; set; }   // Full name of employee
        public string Email { get; set; }    // Login email
        public string PasswordHash { get; set; } // Hashed password
    }
}
