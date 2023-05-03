using ProgettoCinema.Models;
using Microsoft.EntityFrameworkCore;

namespace ProgettoCinema.Data;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Utente> Utenti { get; set; } = null!;
}