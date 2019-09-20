﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public Cookie(string name, string ingredient, string size, string direction, string shape, int batchSize, bool isGood)
        {
            Name = name;
            Ingredient = ingredient;
            Size = size;
            Direction = direction;
            Shape = shape;
            BatchSize = batchSize;
            IsGood = isGood;
        }

        public Cookie()
        {

        }

        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string Size { get; set; }
        public string Direction { get; set; }
        public string Shape { get; set; }
        public int BatchSize { get; set; }
        public bool IsGood { get; set; }
        public float Price { get; set; }

        public void SetPrice()
        {
            if (IsGood)
            {
                Price = 1000f;
            }
        }
    }

}
