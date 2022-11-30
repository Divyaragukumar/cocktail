using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cocktailapi.Models;

public partial class CockdbContext : DbContext
{
    public CockdbContext()
    {
    }

    public CockdbContext(DbContextOptions<CockdbContext> options)
        : base(options)
    {
    }
      
    public virtual DbSet<Cocktail> Cocktails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cocktail>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Cocktail__C1F8DC390DC2987C");

            entity.Property(e => e.Cid).HasColumnName("CId");
            entity.Property(e => e.CocktailName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Glass)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Images)
                .HasMaxLength(2083)
                .IsUnicode(false);
            entity.Property(e => e.Info)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ingredients)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Instructions).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
