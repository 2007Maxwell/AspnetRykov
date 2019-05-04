using AspnetRykov.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetRykov.API.Data
{
    public class DataContext : DbContext
 {    
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Value> Values { get;set;}
}
}