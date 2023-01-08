using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyDataBaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyDataBaseContext(DbContextOptions<MyDataBaseContext> options) : base(options) { }
        // protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
