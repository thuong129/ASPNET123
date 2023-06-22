using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ASPNET123.Models;

namespace ASPNET123.Data {
        public class AppDbContext : DbContext {

        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating (ModelBuilder builder) {

            base.OnModelCreating (builder);
        }

    }

}