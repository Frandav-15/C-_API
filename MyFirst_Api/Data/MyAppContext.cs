using Microsoft.EntityFrameworkCore;
using MyFirst_Api.Models;

namespace MyFirst_Api.Data
{
    public class MyAppContext : DbContext
    {

        
        
    public MyAppContext(DbContextOptions<MyAppContext> options): base(options){}
        


        public DbSet<Employed> employeds { get; set; }

    }
}
