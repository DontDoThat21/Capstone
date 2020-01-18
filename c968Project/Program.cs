using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Generate default allParts
            Inhouse inh1 = new Inhouse(UsingPartForm.partIdCounter, 10, 3, 25, "Popsicles", 3.99, 0);
            UsingPartForm.partIdCounter++;
            Inhouse inh2 = new Inhouse(UsingPartForm.partIdCounter, 9, 5, 25, "Alaskan Bullworms", 1.99, 1);
            UsingPartForm.partIdCounter++;
            Outsourced inh3 = new Outsourced(UsingPartForm.partIdCounter, 8, 4, 20, "Blueberry Shipments", 11.99, "Blue inc.");
            UsingPartForm.partIdCounter++;
            Inventory.allParts.Add(inh1);
            Inventory.allParts.Add(inh2);
            Inventory.allParts.Add(inh3);

            MainScreenForm.indexRow = -1;
            Application.Run(new MainScreenForm());

        }
    }
}