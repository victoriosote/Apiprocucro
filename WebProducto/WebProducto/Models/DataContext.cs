namespace WebProducto.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<WebProducto.Models.Product> Products { get; set; }
    }
}