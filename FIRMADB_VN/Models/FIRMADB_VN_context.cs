
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FIRMADB_VN.Models;

public class FIRMADB_VN_Context : DbContext
{
    public FIRMADB_VN_Context()
    {
    }
    public FIRMADB_VN_Context(DbContextOptions<FIRMADB_VN_Context> options) : base(options) { }
    public DbSet<Haru> Haru { get; set; }
    public DbSet<Töötaja> Töötaja { get; set; }
    public DbSet<LaenutatavInventar> LaenutatavInventar { get; set; }
    public DbSet<Vihjed> Vihjed { get; set; }
    public DbSet<Palved> Palved { get; set; }
    public DbSet<AmetinimetusteAjalugu> AmetinimetusteAjalugu { get; set; }
    public DbSet<Laenutus> Laenutus { get; set; }
    public DbSet<Ligipääsuluba> Ligipääsuluba { get; set; }
    public DbSet<TöötajaLapsSeos> TöötajaLapsSeos { get; set; }
    public DbSet<Laps> Laps { get; set; }
    public DbSet<Puhkused> Puhkused { get; set; }
    public DbSet<Haigusleht> Haigusleht { get; set; }
    public DbSet<Tervisekontroll> Tervisekontroll { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=127.0.0.1,1433;Initial Catalog=FIRMADB_VN;Encrypt=False;User ID=sa;Password=Tere1234");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Laenutus>()
                .HasOne(x => x.Töötaja)
                .WithMany(x => x.Laenutus)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Laenutus>()
                .HasOne(x => x.LaenutatavInventar)
                .WithMany(x => x.Laenutus)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Palved>()
                .HasOne(x => x.Haru)
                .WithMany(x => x.Palved)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Palved>()
                .HasOne(x => x.Töötaja)
                .WithMany(x => x.Palved)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<AmetinimetusteNimekiri>()
                .HasOne(x => x.Haru)
                .WithMany(x => x.AmetinimetusteNimekiri) 
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Haigusleht>()
                .HasOne(x => x.Töötaja)
                .WithMany(x => x.Haigusleht)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<LaenutatavInventar>()
                .HasOne(x => x.Haru)
                .WithMany(x => x.LaenutatavInventar)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Ligipääsuluba>()
                .HasOne(x => x.Töötaja)
                .WithMany(x => x.Ligipääsuluba)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Ligipääsuluba>()
               .HasOne(x => x.AmetinimetusteNimekiri)
               .WithMany(x => x.Ligipääsuluba)
               .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Palved>()
               .HasOne(x => x.Töötaja)
               .WithMany(x => x.Palved)
               .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Palved>()
               .HasOne(x => x.Haru)
               .WithMany(x => x.Palved)
               .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Puhkused>()
               .HasOne(x => x.Töötaja)
               .WithMany(x => x.Puhkused)
               .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Tervisekontroll>()
               .HasOne(x => x.Töötaja)
               .WithMany(x => x.Tervisekontroll)
               .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TöötajaLapsSeos>()
               .HasOne(x => x.Töötaja)
               .WithMany(x => x.TöötajaLapsSeos)
               .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TöötajaLapsSeos>()
               .HasOne(x => x.Laps)
               .WithMany(x => x.TöötajaLapsSeos)
               .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Vihjed>()
               .HasOne(x => x.Haru)
               .WithMany(x => x.Vihjed)
               .OnDelete(DeleteBehavior.Restrict);
    }

}

