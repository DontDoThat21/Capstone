using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968Project
{
    public class Part

    {
        // Beginning of Part's instance variables
        public int PartId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; } // All instance/instantiated variables constructed with Part object class.

        public Part(int partId, int inStock, int min, int max, string name, double price) // int partId, int inStock, int min, int max, string name, double price
        {
            PartId = partId;
            InStock = inStock;
            Min = min;
            Max = max;
            Name = name;
            Price = price;
        }
    }
}