using BlazorWebAppAuthentication.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppAuthentication.Data {
    public class AppDbContext: DbContext {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { 
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
        
    }
}
