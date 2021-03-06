// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Data.Entities;

namespace PizzaBox.Data.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    [Migration("20210425191041_UpdatePresetPizza")]
    partial class UpdatePresetPizza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Data.Entities.Crust", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Crusts");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("StoreID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimePlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StoreID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Pizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CrustID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("PresetPizzaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CrustID");

                    b.HasIndex("OrderID");

                    b.HasIndex("PresetPizzaID");

                    b.HasIndex("SizeID");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.PresetPizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.ToTable("PresetPizzas");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Size", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Store", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Topping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.Property<int>("PizzasID")
                        .HasColumnType("int");

                    b.Property<int>("ToppingsID")
                        .HasColumnType("int");

                    b.HasKey("PizzasID", "ToppingsID");

                    b.HasIndex("ToppingsID");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("PresetPizzaTopping", b =>
                {
                    b.Property<int>("PresetPizzasID")
                        .HasColumnType("int");

                    b.Property<int>("ToppingsID")
                        .HasColumnType("int");

                    b.HasKey("PresetPizzasID", "ToppingsID");

                    b.HasIndex("ToppingsID");

                    b.ToTable("PresetPizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Order", b =>
                {
                    b.HasOne("PizzaBox.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("PizzaBox.Data.Entities.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreID");

                    b.Navigation("Customer");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Data.Entities.Crust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustID");

                    b.HasOne("PizzaBox.Data.Entities.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Data.Entities.PresetPizza", "PresetPizza")
                        .WithMany()
                        .HasForeignKey("PresetPizzaID");

                    b.HasOne("PizzaBox.Data.Entities.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID");

                    b.Navigation("Crust");

                    b.Navigation("Order");

                    b.Navigation("PresetPizza");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Data.Entities.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Data.Entities.Topping", null)
                        .WithMany()
                        .HasForeignKey("ToppingsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PresetPizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Data.Entities.PresetPizza", null)
                        .WithMany()
                        .HasForeignKey("PresetPizzasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Data.Entities.Topping", null)
                        .WithMany()
                        .HasForeignKey("ToppingsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaBox.Data.Entities.Order", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
