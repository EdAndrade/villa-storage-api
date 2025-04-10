using MagicVilla_VillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id=1,
                    Name="Royal Villa",
                    Details="Lorem ipsum idolor sit amet massa auctor tincidunt",
                    ImageUrl="",
                    Occupancy=5,
                    Rate=200,
                    Sqft=550,
                    Amenity="",
                    CreatedDate= new DateTime(2025, 4, 10, 8, 42, 35, 30, DateTimeKind.Local)
                }
             );
        }
    }
}
