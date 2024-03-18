﻿// <auto-generated />
using System;
using BudzetDomowy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BudzetDomowy.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240318134421_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BudzetDomowy.Models.Budget", b =>
                {
                    b.Property<int>("BudgetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BudgetId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BudgetId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Expenditure", b =>
                {
                    b.Property<int>("ExpenditureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenditureId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BudgetId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ExpenditureId");

                    b.HasIndex("BudgetId");

                    b.HasIndex("UserId");

                    b.ToTable("Expenditures");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Income", b =>
                {
                    b.Property<int>("IncomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncomeId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BudgetId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("IncomeId");

                    b.HasIndex("BudgetId");

                    b.HasIndex("UserId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BudgetId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("BudgetId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionId"));

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BudzetDomowy.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BudzetDomowy.Models.UserBudget", b =>
                {
                    b.Property<int>("UserBudgetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserBudgetId"));

                    b.Property<int>("BudgetId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserBudgetId");

                    b.HasIndex("BudgetId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBudgets");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Expenditure", b =>
                {
                    b.HasOne("BudzetDomowy.Models.Budget", "Budget")
                        .WithMany("Expenditures")
                        .HasForeignKey("BudgetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudzetDomowy.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Budget");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Income", b =>
                {
                    b.HasOne("BudzetDomowy.Models.Budget", "Budget")
                        .WithMany("Incomes")
                        .HasForeignKey("BudgetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudzetDomowy.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Budget");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Payment", b =>
                {
                    b.HasOne("BudzetDomowy.Models.Budget", "Budget")
                        .WithMany("Payments")
                        .HasForeignKey("BudgetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudzetDomowy.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Budget");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BudzetDomowy.Models.UserBudget", b =>
                {
                    b.HasOne("BudzetDomowy.Models.Budget", "Budget")
                        .WithMany("UserBudgets")
                        .HasForeignKey("BudgetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudzetDomowy.Models.Permission", "Permission")
                        .WithMany("UserBudgets")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudzetDomowy.Models.Role", "Role")
                        .WithMany("UserBudgets")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudzetDomowy.Models.User", "User")
                        .WithMany("UserBudgets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Budget");

                    b.Navigation("Permission");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Budget", b =>
                {
                    b.Navigation("Expenditures");

                    b.Navigation("Incomes");

                    b.Navigation("Payments");

                    b.Navigation("UserBudgets");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Permission", b =>
                {
                    b.Navigation("UserBudgets");
                });

            modelBuilder.Entity("BudzetDomowy.Models.Role", b =>
                {
                    b.Navigation("UserBudgets");
                });

            modelBuilder.Entity("BudzetDomowy.Models.User", b =>
                {
                    b.Navigation("UserBudgets");
                });
#pragma warning restore 612, 618
        }
    }
}
