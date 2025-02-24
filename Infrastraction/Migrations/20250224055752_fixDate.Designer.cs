﻿// <auto-generated />
using System;
using Infrastraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastraction.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250224055752_fixDate")]
    partial class fixDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasComment("Идентификатор");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата создания");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("integer")
                        .HasComment("Номер заказа");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uuid")
                        .HasComment("Id статуса");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата обновления");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasComment("Id пользователя");

                    b.HasKey("Id")
                        .HasName("Order_pkey");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", t =>
                        {
                            t.HasComment("Заказы пользователя");
                        });
                });

            modelBuilder.Entity("Domain.Entities.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasComment("Идентификатор");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата создания");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid")
                        .HasComment("Id заказа");

                    b.Property<int>("RowNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата обновления");

                    b.HasKey("Id")
                        .HasName("OrderItem_pkey");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems", t =>
                        {
                            t.HasComment("Товары в заказе");
                        });
                });

            modelBuilder.Entity("Domain.Entities.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasComment("Идентификатор");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата создания");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasComment("Удален ли статус");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("Название статуса");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата обновления");

                    b.HasKey("Id")
                        .HasName("Status_pkey");

                    b.ToTable("Statuses", t =>
                        {
                            t.HasComment("Статусы заказов");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-1111-1111-1111-111111111111"),
                            CreateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            Name = "New",
                            UpdateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = new Guid("22222222-2222-2222-2222-222222222222"),
                            CreateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            Name = "Delivering",
                            UpdateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = new Guid("33333333-3333-3333-3333-333333333333"),
                            CreateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            Name = "Canceled",
                            UpdateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = new Guid("44444444-4444-4444-4444-444444444444"),
                            CreateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            Name = "Delivered",
                            UpdateDate = new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasComment("Идентификатор");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата создания");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("Почта пользователя");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("Имя пользователя");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("Дата обновления");

                    b.HasKey("Id")
                        .HasName("User_pkey");

                    b.ToTable("Users", t =>
                        {
                            t.HasComment("Статусы заказов");
                        });
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.HasOne("Domain.Entities.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_Status");

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_OrderItem_Order");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Domain.Entities.Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
