﻿// <auto-generated />
using Leashar.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Leashar.Infrastructure.Data.Migrations.App
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240603160332_InitialAppMigration")]
    partial class InitialAppMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Leashar.Domain.Users.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Leashar.Domain.Users.UserEntity", b =>
                {
                    b.OwnsOne("Leashar.Domain.Common.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<string>("UserEntityId")
                                .HasColumnType("varchar(50)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("varchar(100)")
                                .HasColumnName("Email");

                            b1.HasKey("UserEntityId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserEntityId");
                        });

                    b.OwnsOne("Leashar.Domain.Common.ValueObjects.UserName", "UserName", b1 =>
                        {
                            b1.Property<string>("UserEntityId")
                                .HasColumnType("varchar(50)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("varchar(100)")
                                .HasColumnName("UserName");

                            b1.HasKey("UserEntityId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserEntityId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("UserName")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
