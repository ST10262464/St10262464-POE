namespace AgriEnergyConnectWebApp.Models
{
    public class Product
    {
        // Adapted from Microsoft
        // https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

        public int ProductId { get; set; }   // Primary key
        public int FarmerId { get; set; }  // Foreign key to Farmer

        public string Name { get; set; }   // Product name
        public string Category { get; set; }   // Product category
        public DateTime ProductionDate { get; set; } // Date of production

        public Farmer Farmer { get; set; }    // Navigation to Farmer
    }
}
