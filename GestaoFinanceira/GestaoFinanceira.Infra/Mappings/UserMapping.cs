using GestaoFinanceira.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoFinanceira.Infra.Mappings;

public class UserMapping : IEntityTypeConfiguration<User>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Usuario");

        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .IsRequired();

        builder
            .Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder
            .Property(x => x.Email)
            .HasMaxLength(50)
            .IsRequired();
    }

    #endregion Public Methods
}