using ProgettoCinema.Models;
using Microsoft.EntityFrameworkCore;

namespace ProgettoCinema.DataAccess.Data;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Utente> Utenti { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}