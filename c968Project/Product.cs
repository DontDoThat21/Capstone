using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968Project
{
    public class Product

    {
        public static List<Part> associatedParts = new List<Part>();
        public int ProductID { get; set; }
        public int InStock { get; set; } 
        public int Min { get; set; }
        public int Max { get; set; }
        public string Name { get; set; } 
        public double Price { get; set; } 
        
        public Product(int ProductId, int inStock, int min, int max, string name, double price)
        {
            ProductID = ProductId;
            InStock = inStock;
            Min = min;
            Max = max;
            Name = name;
            Price = price;
        }
        
        public static void AddAssociatedPart(Part part) // Done.
        {
            // probably add to one of the lists?
            associatedParts.Add(part);
        }
        bool RemoveAssociatedPart(int x) // Done.
        {
            associatedParts.RemoveAt(x);
            return false; // I have no idea why I was forced to make this method a bool. Void is more appropriate.
        }
        Part LookupAssociatedPart(int x) // Not done.
        {
            return null;
        }
    }
    public class Associator // Class so small, would rather have one file. Only used in this form to add the actual association. AKA associatedParts list.
    {
        static public List<Associator> ConnectionList = new List<Associator>(); // This list is really a tool to keep track of what part is assigned to a given product.
        public int PartId { get; set; }
        public int ProdId { get; set; } // Needed to save transaction of adding/removing associated parts.
        public Associator(int partId, int prodId)
        {
            PartId = partId;
            ProdId = prodId;
            ConnectionList.Add(this);
        }
    }
}
