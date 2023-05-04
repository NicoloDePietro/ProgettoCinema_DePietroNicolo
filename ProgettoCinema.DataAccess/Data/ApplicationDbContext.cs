using ProgettoCinema.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ProgettoCinema.DataAccess.Data;
public class ApplicationDbContext : IdentityDbContext<IdentityUser>

{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Utente> Utenti { get; set; } = null!;
    //public DbSet<Film> Films { get; set; } = null!;   //DA VEDERE L'ORDINE IN CUI METTERLI
    //public DbSet<Spettacolo> Spettacoli { get; set; } = null!;
    //public DbSet<Sala> Sale { get; set; } = null!;
    //public DbSet<Posto> Posti { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}