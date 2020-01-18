using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c968Project
{
    static class Inventory
    {
        static public List<Part> allParts = new List<Part>();
        static public List<Product> products = new List<Product>();
        static Inventory()
        {
        }
        public static void AddProduct(Product product)
        {
            products.Add(product);
        }
        static bool RemoveProduct(int listIndexNum)
        {
            return (listIndexNum < allParts.Count); // very incorrect.
        }
        static Part LookupProduct(int listIndexNum)
        {
            return null;
        }
        static void UpdateProduct(int x, Part product)
        {
            // "save" the details given from text fields in app as a product object in the list.
        }
        static void AddPart(Part part)
        {
            // should probably make a new part obj as existing part data then "save" it???
        }
        static bool DeletePart(Part part)
        {
            return true; // Not even close.
        }
        static Part LookupPart(int x)
        {
            return null;
        }
        static void UpdatePart(int x, Part part)
        {
            // "save" the details given from text fields in app as a product object in the list.
        }
    }
}
