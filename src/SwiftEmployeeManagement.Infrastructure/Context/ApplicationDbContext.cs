using Microsoft.EntityFrameworkCore;

namespace SwiftEmployeeManagement.Infrastructure.Context;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}