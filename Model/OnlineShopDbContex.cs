using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model.Dtos;

namespace Model
{
    public class OnlineShopDbContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5N0A12H;Initial Catalog=OnlineShop;Integrated Security=True; Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
