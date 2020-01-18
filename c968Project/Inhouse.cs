using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c968Project
{
    class Inhouse : Part
    {
        public int MachineId { get; set; }
        public Inhouse(int partId, int inStock, int min, int max, string name, double price, int machineId) : base (partId, inStock, min, max, name, price)
        {
            PartId = partId;
            InStock = inStock;
            Min = min;
            Max = max;
            Name = name;
            Price = price;
            MachineId = machineId;
        }
    }
}