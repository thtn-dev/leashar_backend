using Leashar.Domain.Common.ValueObjects;
using Leashar.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leashar.Infrastructure.Data.ModelBuilders;

public static class ModelBuilderExtension
{
    public static void ApplyConfigurations(this ModelBuilder builder)
    {
        UserConfiguration(builder.Entity<UserEntity>());
    }

    private static void UserConfiguration(EntityTypeBuilder<UserEntity> entity)
    {

        entity.ToTable("Users")
            .HasKey(x => x.Id);

        entity
            .Property(x => x.Id)
            .IsRequired()
            .HasColumnType("varchar(50)");

        // email is ValueObject
        entity.OwnsOne(x => x.Email, email =>
        {
            email.Property(x => x.Value)
                .HasColumnName("Email")
                .IsRequired()
                .HasColumnType("varchar(100)");
        });

        entity.OwnsOne(x => x.UserName, userName =>
        {
            userName.Property(x => x.Value)
                .HasColumnName("UserName")
                .IsRequired()
                .HasColumnType("varchar(100)");
        });

        entity.Property(x => x.HashedPassword)
            .IsRequired()
            .HasColumnType("varchar(100)");
    }
}