using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary
{
    public class DishContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().HasData(SeedTestData());
        }
        public List<Dish> SeedTestData()
        {
            var dish = new List<Dish>();
            using (StreamReader r = new StreamReader(@"MOCK_DATA(1).json"))
            {
                string json = r.ReadToEnd();
                dish = JsonConvert.DeserializeObject<List<Dish>>(json);
            }
            return dish;    
        }
       
    }
}
