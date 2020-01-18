using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968Project
{
    public partial class UsingProductForm : Form
    {
        public UsingProductForm()
        {
            InitializeComponent();
            DrawTheRows();
        }

        private void CnclBtn_Click(object sender, EventArgs e) // Cancel out of form, return and reinstance mainform.
        {
            this.Close();
            MainScreenForm msf = new MainScreenForm();
            msf.DrawTheRows();
            msf.Visible = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveToList();
        }

        private void SaveToList()
        {
            if (MainScreenForm.modifyClicked == true)
            {
                MainScreenForm.indexRow = int.Parse(upfIdBox.Text);
                Inventory.products[MainScreenForm.indexRow].ProductID = Inventory.products.Count;
                Inventory.products[MainScreenForm.indexRow].InStock = int.Parse(invBox.Text);
                Inventory.products[MainScreenForm.indexRow].Min = int.Parse(minBox.Text);
                Inventory.products[MainScreenForm.indexRow].Max = int.Parse(maxBox.Text);
                Inventory.products[MainScreenForm.indexRow].Name = nameBox.Text;
                Inventory.products[MainScreenForm.indexRow].Price = double.Parse(priceBox.Text);
                //DrawTheRows(); // Is this needed?
                Reassociation(MainScreenForm.indexRow); // HERE IS WHERE IT SPINS FOREVER! HERE IS WHERE IT SPINS FOREVER! HERE IS WHERE IT SPINS FOREVER!
                foreach (DataGridViewRow row in DGVBot.Rows)
                {
                    Associator associator = new Associator(int.Parse(row.Cells[0].Value.ToString()), int.Parse(upfIdBox.Text)); // Problem.
                    //Associator.ConnectionList.Add(associator);
                }
                // add this to associatedParts
                Product.AddAssociatedPart(Inventory.allParts[DGVTop.CurrentRow.Index]); // Should call the method to add the part.
                this.Close();
                MainScreenForm msf = new MainScreenForm();
                msf.DrawTheRows();
                msf.Show();

                MainScreenForm.modifyClicked = false;
            }
            else
            {
                upfIdBox.Text = Inventory.products.Count.ToString();
                string s = this.nameBox.Text;
                int inv = int.Parse(invBox.Text);
                double d = double.Parse(priceBox.Text);
                int max = int.Parse(maxBox.Text);
                int min = int.Parse(minBox.Text);
                foreach (DataGridViewRow row in DGVBot.Rows)
                {
                    Associator associator = new Associator(int.Parse(row.Cells[0].Value.ToString()), Inventory.products.Count);
                    if (Inventory.allParts[row.Index].GetType().ToString() == "c968Project.Inhouse")
                    {
                        // do inhouse
                    }
                    else if (Inventory.allParts[row.Index].GetType().ToString() == "c968Project.Outsourced")
                    {
                        // do outsourced
                    }
                }
                Product product = new Product(Inventory.products.Count, inv, max, min, s, d);
                //Inventory.AddProduct(product);
                Inventory.products.Add(product);
                upfIdBox.Text = Inventory.products.Count.ToString(); // Update the ID after saving.
                this.Close();
                MainScreenForm msf = new MainScreenForm();
                msf.DrawTheRows();
                msf.Show();
            }
        }
        private void DrawTheRows()
        {
            DGVTop.Rows.Clear();
            int i = 0;
            foreach (Part parts in Inventory.allParts)
            {
                while (i < Inventory.allParts.Count)
                {
                    DGVTop.Rows.Add(i, Inventory.allParts[i].Name, Inventory.allParts[i].InStock, Inventory.allParts[i].Price);
                    i++;
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ListNameSearch(MainScreenForm.workingWithProd);
        }
        private void ListNameSearch(bool checkListTypeToChange) // Should be implemented just fine.
        {
            if (checkListTypeToChange == true) // Check if were working with a product type.
            {
                // instance variables
                int Counter = 0;
                DGVTop.Rows.Clear();

                foreach (Part part in Inventory.allParts)
                {
                    if (part.Name.Contains(searchBox.Text))
                    {
                        DGVTop.Rows.Add(part.PartId, part.Name, part.InStock, part.Price);
                        Counter++;
                        if (DGVTop.Rows.Count == 0) // Don't allow user to delete a row that doesnt exist.
                        {
                            // do nothing
                        }
                    }
                    else if (searchBox.Text == "")
                    {
                        DGVTop.Rows.Clear();
                        DrawTheRows();
                        Counter = DGVTop.Rows.Count;
                    }
                    else if (!part.Name.Contains(searchBox.Text) && DGVTop.Rows.Count > 0)
                    {
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)// Copy from dgvtop to dgvbot
        {
            var targetRow = (DataGridViewRow)DGVTop.CurrentRow.Clone();
            foreach (DataGridViewCell cell in DGVTop.CurrentRow.Cells)
            {
                targetRow.Cells[cell.ColumnIndex].Value = cell.Value;
            }
            DGVBot.Rows.Add(targetRow);
            saveBtn.Enabled = true;
        }

        private void DGVTop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainScreenForm.indexRow = DGVTop.CurrentRow.Index;
        }

        public void DrawAssociated()
        {
            foreach (Associator association in Associator.ConnectionList)
            {
                MessageBox.Show($"{association.ProdId.ToString()} is the asoc's prod id. {upfIdBox.Text.ToString()} is the corresponding text box.");
                if (association.ProdId.ToString() == upfIdBox.Text.ToString())
                {
                    foreach (DataGridViewRow row in DGVTop.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == association.PartId.ToString())
                        {
                            DGVBot.Rows.Add(row.Index, Inventory.allParts[row.Index].Name, Inventory.allParts[row.Index].InStock, Inventory.allParts[row.Index].Price);
                        }
                        //DGVBot.Rows.Add(row.Index, Inventory.allParts[row.Index].Name, Inventory.allParts[row.Index].InStock, Inventory.allParts[row.Index].Price);
                    }
                }
                else
                {
                    MessageBox.Show("assocition skipped");
                }
            }
        }
        private void Reassociation(int id) // Extremely overcomplicated way of removing duplicates from a list. HEY IT WORKS THOUGH. AND IT SUPER DYNAM- no not really. Works tho. Uses very little memory ok, cut me some slack.
        {
            if (id == int.Parse(upfIdBox.Text.ToString()))
            {
                int i = 0;
                List<int> intList = new List<int>();

                foreach (Associator assoc in Associator.ConnectionList)
                {
                    if (assoc.ProdId == int.Parse(upfIdBox.Text.ToString()))
                    {
                        intList.Add(i);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                while (intList.Count > 0)
                {
                    MessageBox.Show("mesg 5"); // Too large Too largeToo largeToo largeToo largeToo largeToo largeToo largeToo largeToo largeToo largeToo largeToo largeToo largeToo large
                    MessageBox.Show(intList.Max().ToString());
                    Associator.ConnectionList.RemoveAt(intList.Max());
                    intList.RemoveAt(intList.Count - 1);
                    i--;
                    MessageBox.Show("mesg 6");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Associator.ConnectionList.Count.ToString();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteAssociatedPart(DGVBot.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("Please stop trying to delete what simply doesn't exist. Or I'm calling the authorities.");
            }
        }
        public void DeleteAssociatedPart(int id) // Row index always corresponds w/ part id. Works well.
        {
            DialogResult dialogAnswer = MessageBox.Show("Are you SURE you want to delete this entry?", "Confirm Deletion.", MessageBoxButtons.YesNo);
            if (dialogAnswer == DialogResult.Yes)
            {
                if (Associator.ConnectionList.Count > 0)
                {
                    List<int> intList = new List<int>();
                    foreach (Associator association in Associator.ConnectionList)
                    {
                        intList.Add(id);
                        DGVBot.Rows.RemoveAt(id);
                    }
                    foreach (int idTemp in intList)
                    {
                        Associator.ConnectionList.RemoveAt(idTemp);
                    }
                }
                else
                {
                    DGVBot.Rows.RemoveAt(id);
                }
            }
            else if (dialogAnswer == DialogResult.No)
            {
                MessageBox.Show("Fine, it's spared. For now.");
            }
        }
    }
}