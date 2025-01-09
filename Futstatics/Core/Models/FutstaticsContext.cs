using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Core.Models;

public partial class FutstaticsContext : DbContext
{
    public FutstaticsContext()
    {
    }

    public FutstaticsContext(DbContextOptions<FutstaticsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Jogo> Jogos { get; set; }

    public virtual DbSet<Time> Times { get; set; }

    public virtual DbSet<TimeAno> TimeAnos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Jogo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jogos__3214EC276EE379F7");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TG_TIME");
                    tb.HasTrigger("TG_TIMEANO");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Competicao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COMPETICAO");
            entity.Property(e => e.PlacarMandante).HasColumnName("PLACAR_MANDANTE");
            entity.Property(e => e.PlacarVisitante).HasColumnName("PLACAR_VISITANTE");
            entity.Property(e => e.TimeMandante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIME_MANDANTE");
            entity.Property(e => e.TimeVisitante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIME_VISITANTE");
        });

        modelBuilder.Entity<Time>(entity =>
        {
            entity.HasKey(e => e.IdTime).HasName("PK__Times__DB4DF0B52A43FB01");

            entity.HasIndex(e => e.Nome, "UQ__Times__E2AB1FF4FB36B5E3").IsUnique();

            entity.Property(e => e.IdTime).HasColumnName("ID_TIME");
            entity.Property(e => e.Cidade)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CIDADE");
            entity.Property(e => e.Estadio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADIO");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Foto)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("FOTO");
            entity.Property(e => e.Mascote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MASCOTE");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<TimeAno>(entity =>
        {
            entity.HasKey(e => new { e.Nome, e.Competicao, e.Ano }).HasName("PK__TimeAno__C6AED065CB656CC1");

            entity.ToTable("TimeAno");

            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOME");
            entity.Property(e => e.Competicao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COMPETICAO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
