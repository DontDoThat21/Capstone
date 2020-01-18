using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c968Project
{
    class Outsourced : Part
    {
        string CompanyName { get; set; }
        public Outsourced(int partId, int inStock, int min, int max, string name, double price, string companyName) : base(partId, inStock, min, max, name, price)
        {
            PartId = partId;
            InStock = inStock;
            Min = min;
            Max = max;
            Name = name;
            Price = price;
            CompanyName = companyName;
        }
    }
}
