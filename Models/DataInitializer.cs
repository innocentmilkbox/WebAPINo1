using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsOrderAPI.Models
{
    public class DataInitializer
    {
        public static async Task SeedData(FoodContext context)
        {
            string foodData = File.ReadAllText("SeedData/seedz.json");
            List<FoodItem> foodItems = JsonConvert.DeserializeObject<List<FoodItem>>(foodData);
            await context.FoodItems.AddRangeAsync(foodItems);
            await context.SaveChangesAsync();
        }
    }
}
