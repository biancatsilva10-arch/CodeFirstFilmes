using CodeFirstFilmes.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstFilmes.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Diretores> Diretores => Set<Diretores>();
    public DbSet<Filme> Filmes => Set<Filme>();
    public DbSet<Genero> Generos => Set<Genero>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Diretores>()
            .HasMany(d => d.Filmes)
            .WithOne(g => g.Diretores)
            .HasForeignKey(g => g.DiretoresId);

        modelBuilder.Entity<Filme>()
            .HasMany(g => g.Generos)
            .WithMany(g => g.Filmes);
    }
}