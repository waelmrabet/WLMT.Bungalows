using Core.Models;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyDataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Bungalow> Bungalows { get; set; }
        public DbSet<Convenience> Convenience { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<ReservationState> ReservationStates { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }

        public MyDataBaseContext(DbContextOptions<MyDataBaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region applying TPT inheritance strategie

            modelBuilder.ApplyConfiguration(new OwnerConfiguration());
            modelBuilder.ApplyConfiguration(new TenantConfiguration());
            modelBuilder.ApplyConfiguration(new CommercialConfiguration());            
            modelBuilder.ApplyConfiguration(new RoleMenuConfigurations());

            #endregion

            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

        }
    }
}
