using Microsoft.EntityFrameworkCore;

namespace GCOM2_Test.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { 
    
    }
    //public virtual DbSet<ClientClass> DisplayRecords { get; set; }
}
