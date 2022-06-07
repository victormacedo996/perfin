using GestaoFinanceira.Domain.Entities;
using GestaoFinanceira.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinanceira.Infra.Context;

public class GestaoFinanceiraContext : DbContext
{
    #region Public Properties

    public DbSet<User> _Users { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public GestaoFinanceiraContext(DbContextOptions<GestaoFinanceiraContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMapping());

        base.OnModelCreating(modelBuilder);
    }

    #endregion Protected Methods
}