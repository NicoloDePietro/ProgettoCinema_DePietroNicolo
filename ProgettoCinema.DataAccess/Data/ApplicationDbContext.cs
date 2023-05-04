using ProgettoCinema.Models;
using Microsoft.EntityFrameworkCore;

namespace ProgettoCinema.DataAccess.Data;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Utente> Utenti { get; set; } = null!;
    //public DbSet<Film> Films { get; set; }    //DA VEDERE L'ORDINE IN CUI METTERLI
    //public DbSet<Posto> Posti { get; set; }
    //public DbSet<Sala> Sale { get; set; }
    //public DbSet<Spettacolo> Spettacoli { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}