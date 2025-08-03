using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MyFirst_Api.Models;

namespace MyFirst_Api.Data
{
    public class MyAppContext : DbContext
    {

        
        
    public MyAppContext(DbContextOptions<MyAppContext> options): base(options){}
        


        public DbSet<Employed> employeds { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
