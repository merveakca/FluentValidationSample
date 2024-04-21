using Microsoft.EntityFrameworkCore;

namespace FluentValidationSample.Models.ORM;

public class AkademiIstanbulContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-D84DF12\\SQLEXPRESS01;Database=AkademiIstanbul;Trusted_Connection=True;trustservercertificate=true");
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<University> Universities { get; set; }
}
