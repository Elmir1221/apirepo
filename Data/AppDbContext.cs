using FiorelloApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorelloApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>()
            //    .Property(s => s.Title)
            //    .HasColumnName("Title")
            //    .HasDefaultValue(0)
            //    .IsRequired(false);


            modelBuilder.Entity<Slider>().HasData(
            new Slider
            {
                Id=1,
                Name = "nsamw",
                Description = "ssssss",
                Title = "title"
            },
            new Slider
            {
                Id = 2,
                Name = "nsamw2",
                Description = "ssssss2",
                Title = "title2"
            },
            new Slider
            {
                
                Id = 3,
                Name = "nsamw3",
                Description = "ssssss3",
                Title = "title3"
            }
            );
            base.OnModelCreating(modelBuilder);

        }
    }
}
