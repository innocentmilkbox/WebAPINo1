using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsOrderAPI.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string ImgSource { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

    }
}
