﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class Computer
    {

        public int ComputerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnRecommend { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
