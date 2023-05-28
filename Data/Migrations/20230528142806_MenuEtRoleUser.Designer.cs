﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyDataBaseContext))]
    [Migration("20230528142806_MenuEtRoleUser")]
    partial class MenuEtRoleUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BungalowConvenience", b =>
                {
                    b.Property<int>("BungalowsId")
                        .HasColumnType("int");

                    b.Property<int>("ConveniencesId")
                        .HasColumnType("int");

                    b.HasKey("BungalowsId", "ConveniencesId");

                    b.HasIndex("ConveniencesId");

                    b.ToTable("BungalowConvenience");
                });

            modelBuilder.Entity("Core.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("IndicationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qontry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Core.Models.Bungalow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("CommercialId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<float>("PricePerNight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CommercialId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Bungalows");
                });

            modelBuilder.Entity("Core.Models.Convenience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Convenience");
                });

            modelBuilder.Entity("Core.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AriaControls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataTarget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconLibelle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdAriaControls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsParent")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuAriaLibelle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentMenuId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Core.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("BungalowId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BungalowId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Core.Models.Reservation", b =>
                {
                    b.Property<int>("TenantInfoId")
                        .HasColumnType("int");

                    b.Property<int>("BungalowId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NumberOfNights")
                        .HasColumnType("real");

                    b.Property<int>("ReservationStateId")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TenantInfoId", "BungalowId", "StartDate", "EndDate");

                    b.HasIndex("BungalowId");

                    b.HasIndex("ReservationStateId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Core.Models.ReservationState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReservationStates");
                });

            modelBuilder.Entity("Core.Models.ResevationDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReservationBungalowId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReservationEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReservationStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReservationTenantInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationTenantInfoId", "ReservationBungalowId", "ReservationStartDate", "ReservationEndDate");

                    b.ToTable("ResevationDay");
                });

            modelBuilder.Entity("Core.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Activated")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Core.Models.RoleMenu", b =>
                {
                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Activated")
                        .HasColumnType("bit");

                    b.HasKey("MenuId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleMenus");
                });

            modelBuilder.Entity("Core.Models.TenantInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TenantInfo");
                });

            modelBuilder.Entity("Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Activated")
                        .HasColumnType("bit");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CryptedPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Models.Commercial", b =>
                {
                    b.HasBaseType("Core.Models.User");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Commercials");
                });

            modelBuilder.Entity("Core.Models.Owner", b =>
                {
                    b.HasBaseType("Core.Models.User");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Core.Models.Tenant", b =>
                {
                    b.HasBaseType("Core.Models.User");

                    b.Property<int?>("TenantInfoId")
                        .HasColumnType("int");

                    b.HasIndex("TenantInfoId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("BungalowConvenience", b =>
                {
                    b.HasOne("Core.Models.Bungalow", null)
                        .WithMany()
                        .HasForeignKey("BungalowsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Convenience", null)
                        .WithMany()
                        .HasForeignKey("ConveniencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Models.Bungalow", b =>
                {
                    b.HasOne("Core.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Commercial", "Commercial")
                        .WithMany("Bungalows")
                        .HasForeignKey("CommercialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Owner", "Owner")
                        .WithMany("Bungalows")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Commercial");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Core.Models.Photo", b =>
                {
                    b.HasOne("Core.Models.Bungalow", null)
                        .WithMany("Photos")
                        .HasForeignKey("BungalowId");
                });

            modelBuilder.Entity("Core.Models.Reservation", b =>
                {
                    b.HasOne("Core.Models.Bungalow", "Bungalow")
                        .WithMany("Reservations")
                        .HasForeignKey("BungalowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.ReservationState", "ReservationState")
                        .WithMany()
                        .HasForeignKey("ReservationStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.TenantInfo", "TenantInfo")
                        .WithMany("Reservations")
                        .HasForeignKey("TenantInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bungalow");

                    b.Navigation("ReservationState");

                    b.Navigation("TenantInfo");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Models.ResevationDay", b =>
                {
                    b.HasOne("Core.Models.Reservation", "Reservation")
                        .WithMany("GetResevationDays")
                        .HasForeignKey("ReservationTenantInfoId", "ReservationBungalowId", "ReservationStartDate", "ReservationEndDate");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Core.Models.RoleMenu", b =>
                {
                    b.HasOne("Core.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Role", "Role")
                        .WithMany("RoleMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Core.Models.Commercial", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Core.Models.Commercial", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Models.Owner", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Core.Models.Owner", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Models.Tenant", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Core.Models.Tenant", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Core.Models.TenantInfo", "TenantInfo")
                        .WithMany()
                        .HasForeignKey("TenantInfoId");

                    b.Navigation("TenantInfo");
                });

            modelBuilder.Entity("Core.Models.Bungalow", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Core.Models.Reservation", b =>
                {
                    b.Navigation("GetResevationDays");
                });

            modelBuilder.Entity("Core.Models.Role", b =>
                {
                    b.Navigation("RoleMenus");
                });

            modelBuilder.Entity("Core.Models.TenantInfo", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Core.Models.Commercial", b =>
                {
                    b.Navigation("Bungalows");
                });

            modelBuilder.Entity("Core.Models.Owner", b =>
                {
                    b.Navigation("Bungalows");
                });
#pragma warning restore 612, 618
        }
    }
}
