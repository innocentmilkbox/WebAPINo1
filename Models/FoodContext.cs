using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsOrderAPI.Models
{
    public class FoodContext:DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options)
        {

        }
        public DbSet<FoodItem> FoodItems { get; set; }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>().HasData(SeedFoodData());
        }
        
        public List<FoodItem> SeedFoodData()
        {
            var Itemz = new List<FoodItem>();
            using (StreamReader rd = new StreamReader("SeedData/seedz.json"))
            {
                string datajson = rd.ReadToEnd();
                Itemz = JsonConvert.DeserializeObject<List<FoodItem>>(datajson);
            }            
            return Itemz;
        }
        */
    }
}
