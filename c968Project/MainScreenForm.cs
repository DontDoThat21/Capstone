using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace c968Project
{
    public partial class MainScreenForm : Form
    {
        public static int indexRow = 0; // Current selected row grid index. Used across many classes.
        public static int ifSelector;
        public static bool modifyClicked = false;
        public static bool workingWithProd = false;

        public MainScreenForm()
        {
            if(indexRow==-1)
            {
                InitializeComponent();
                DrawTheRows();
                indexRow = 0;
            }
            else
            {
                InitializeComponent();
                this.DGVParts.ClearSelection();
                this.DGVProducts.ClearSelection();
            }
        }
        private void Exit_Button(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectRowHandler(object sender, DataGridViewCellEventArgs e) // Updates static index of currently selected row.
        {
            try
            {
                if (DGVParts.Focused)
                {
                    indexRow = DGVParts.CurrentRow.Index; // previously - indexRow = DGVParts.CurrentCell.RowIndex;
                }
                else if (DGVProducts.Focused)
                {
                    indexRow = DGVProducts.CurrentRow.Index; // previously - indexRow = DGVProducts.CurrentCell.RowIndex;
                }
            }
            catch (System.NullReferenceException)
            {
                // Do nothing, irrelevant. Only occurs when user clicks a collumn when/where no data is present.
            }
        }

        private void MdfyBtnPart_Click(object sender, EventArgs e)
        {
            workingWithProd = false;
            MdfyBtn(workingWithProd);
        }

        private void MdfyBtnProd_Click(object sender, EventArgs e)
        {
            workingWithProd = true;
            if (DGVProducts.Rows.Count > 0)
            {
                indexRow = DGVProducts.CurrentRow.Index;
            }
            MdfyBtn(workingWithProd);
        }

        private void MdfyBtn(bool checkListTypeToChange)
        {
            if (workingWithProd == false)//Determine type of list to work, add, etc on. False is part form.
            {
                this.Hide();
                UsingPartForm mSF = new UsingPartForm();
                mSF.label1.Text = "Modify Part";
                mSF.idBox.BackColor = Color.White;
                mSF.idBox.Enabled = false;

                if (Inventory.allParts.Count == 0) // Modify form w/ default values
                {
                    mSF.Show();
                }
                //else if (Inventory.allParts.Count < MainScreenForm.indexRow) // Though it really shouldn't, if the indexRow manages to be greater than total just show default.
                //{
                //    mSF.Show();
                //}
                else
                {
                    mSF.idBox.Text = Inventory.allParts[indexRow].PartId.ToString();
                    mSF.nameBox.Text = Inventory.allParts[indexRow].Name;
                    mSF.invBox.Text = Inventory.allParts[indexRow].InStock.ToString();
                    mSF.priceBox.Text = Inventory.allParts[indexRow].Price.ToString();
                    mSF.maxBox.Text = Inventory.allParts[indexRow].Max.ToString();
                    mSF.minBox.Text = Inventory.allParts[indexRow].Min.ToString();

                    if(Inventory.allParts[indexRow].GetType().ToString().Equals("c968Project.Inhouse"))
                    {
                        //Inhouse.MachineId();
                    }
                    else if(Inventory.allParts[indexRow].GetType().ToString().Equals("c968Project.Outsourced"))
                    {
                        //mSF.machNcompBox = company name;
                    }
                    modifyClicked = true;

                    mSF.Show();
                }

            }
            else if (workingWithProd == true)//Determine type of list to work, add, etc on. True is prod form.
            {
                try
                {
                    indexRow = DGVProducts.CurrentRow.Index;
                }
                catch
                {
                }

                if (DGVProducts.Rows.Count > 0)
                {

                }
                else
                {
                    // MessageBox.Show("No Rows Selected to Modify!");
                }
                this.Hide();
                UsingProductForm UPF = new UsingProductForm();

                UPF.upfIdBox.BackColor = Color.White;
                UPF.upfIdBox.Enabled = false;
                UPF.label1.Text = "Modify Product";
                UPF.saveBtn.Enabled = true;

                if (Inventory.products.Count == 0) // Modify form w/ default values
                {
                    UPF.Show();
                }
                else
                {
                    UPF.upfIdBox.Text = indexRow.ToString(); //Inventory.products[indexRow].ProductID.ToString();
                    UPF.nameBox.Text = Inventory.products[indexRow].Name;
                    UPF.invBox.Text = Inventory.products[indexRow].InStock.ToString();
                    UPF.priceBox.Text = Inventory.products[indexRow].Price.ToString();
                    UPF.maxBox.Text = Inventory.products[indexRow].Max.ToString();
                    UPF.minBox.Text = Inventory.products[indexRow].Min.ToString();
                    modifyClicked = true;

                    // implement the draw call here.
                    UPF.Show();
                    UPF.DrawAssociated();
                }
            }
        }

        private void AddToListInitializer() // Initializes appropriate forms
        {
            if (workingWithProd == true)//Determine type of list to work, add, etc on. False is part form.
            {
                UsingProductForm addToProductForm = new UsingProductForm();
                addToProductForm.label1.Text = "Add Product";
                addToProductForm.Show();
                addToProductForm.upfIdBox.Text = Inventory.products.Count.ToString(); // ?
                addToProductForm.nameBox.Text = "";
                addToProductForm.invBox.Text = "";
                addToProductForm.priceBox.Text = "";
                addToProductForm.maxBox.Text = "";
                addToProductForm.minBox.Text = "";
                // Calls other form, overwrites default values to lower visual clutter.
            }
            else if (workingWithProd == false)
            {
                UsingPartForm addToPartForm = new UsingPartForm();
                addToPartForm.label1.Text = "Add Part";
                addToPartForm.Show();
                addToPartForm.idBox.Text = "Auto Gen - Disabled";
                addToPartForm.nameBox.Text = "";
                addToPartForm.invBox.Text = "";
                addToPartForm.priceBox.Text = "";
                addToPartForm.maxBox.Text = "";
                addToPartForm.machNcompBox.Text = "";
                addToPartForm.minBox.Text = "";
                // Calls other form, overwrites default values to lower visual clutter.
            }
            this.Hide();
        }

        private void PartBtnAdd_Click(object sender, EventArgs e)
        {
            workingWithProd = false;
            AddToListInitializer();
        }

        private void ProdBtnAdd_Click(object sender, EventArgs e)
        {
            workingWithProd = true;
            if(DGVProducts.Rows.Count>0)
            {
                indexRow = DGVProducts.CurrentRow.Index;
            }
            AddToListInitializer();

        }

        private void DeletePartBtn_Click(object sender, EventArgs e)
        {
            workingWithProd = false;
            DeleteFromList(workingWithProd);
        }

        private void DeleteProdBtn_Click(object sender, EventArgs e)
        {
            workingWithProd = true;
            if (DGVProducts.Rows.Count > 0)
            {
                indexRow = DGVProducts.CurrentRow.Index;
            }
            DeleteFromList(workingWithProd);
        }
        private void DeleteFromList(bool checkListTypeToChange)
        {
            if (workingWithProd == false)
            {
                if (Inventory.allParts.Count != 0) // Confirms the actual delete attempt is valid.
                {
                    DialogResult dialogAnswer = MessageBox.Show("Really delete? No refunds!", "Confirm Deletion.", MessageBoxButtons.YesNo);
                    if (dialogAnswer == DialogResult.Yes)
                    {
                        Inventory.allParts.RemoveAt(indexRow);
                        DGVParts.Rows.RemoveAt(indexRow);
                        DGVParts.Rows.Clear();
                        DGVProducts.Rows.Clear();
                        this.DrawTheRows();
                        DGVParts.ClearSelection();
                    }
                    else if (dialogAnswer == DialogResult.No)
                    {
                        // do nothing
                    }
                }
            }
            else if (workingWithProd == true)
            {
                try
                {
                    indexRow = DGVProducts.CurrentRow.Index;
                }
                catch
                {
                    MessageBox.Show("How dare you try to delete what doesn't exist!");
                }
                if (Inventory.products.Count != 0) // Confirms the actual delete attempt is valid.
                {
                    DialogResult dialogAnswer = MessageBox.Show("Are you SURE you want to delete this entry?", "Confirm Deletion.", MessageBoxButtons.YesNo);
                    if (dialogAnswer == DialogResult.Yes)
                    {
                        Inventory.products.RemoveAt(indexRow);
                        DGVProducts.Rows.RemoveAt(indexRow);
                        DGVProducts.Rows.Clear();
                        DGVParts.Rows.Clear();
                        this.DrawTheRows();
                        DGVProducts.ClearSelection();
                    }
                    else if (dialogAnswer == DialogResult.No)
                    {
                        // do nothing
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot delete that of which does not exist. Wait.. what?");
            }
        }
        public void DrawTheRows()
        {
            {
                int i = 0;
                foreach (Product prod in Inventory.products)
                {
                    while (i < Inventory.products.Count)
                    {
                        DGVProducts.Rows.Add(i, Inventory.products[i].Name, Inventory.products[i].InStock, Inventory.products[i].Price);
                        i++;
                    }
                }
            }
            {
                int i = 0;
                foreach (Part part in Inventory.allParts)
                {
                    while (i < Inventory.allParts.Count)
                    {
                        DGVParts.Rows.Add(i, Inventory.allParts[i].Name, Inventory.allParts[i].InStock, Inventory.allParts[i].Price);
                        i++;
                    }
                }
            }
        }

        private void ProdBtnSearch_Click(object sender, EventArgs e)
        {
            workingWithProd = true;
            ListNameSearch(workingWithProd);
        }

        private void PartBtnSearch_Click(object sender, EventArgs e)
        {
            workingWithProd = false;
            ListNameSearch(workingWithProd);
        }

        private void ListNameSearch(bool checkListTypeToChange) // Consider adding a try catch for ArgumentOutOfRangeException ENTIRE METHOD
        {
            if (checkListTypeToChange == true) // Check if were working with a product type.
            {
                // instance variables
                int Counter = 0;
                DGVProducts.Rows.Clear();

                foreach (Product prod in Inventory.products)
                {
                    if (prod.Name.Contains(prodSearchTextBox.Text))
                    {
                        DGVProducts.Rows.Add(Counter, prod.Name, prod.InStock, prod.Price); // used to be prod.ProductID
                        Counter++;
                        if (DGVProducts.Rows.Count == 0) // Don't allow user to delete a row that doesnt exist.
                        {
                            // do nothing
                        }
                    }
                    else if (prodSearchTextBox.Text == "")
                    {
                        DGVProducts.Rows.Clear();
                        DrawTheRows();
                        Counter = DGVProducts.Rows.Count;
                    }
                    else if(!prod.Name.Contains(prodSearchTextBox.Text) && DGVProducts.Rows.Count > 0)
                    {
                    }
                }
            }
            else if (checkListTypeToChange == false) // Check if were working with a part type.
            {
                // instance variables
                int Counter = 0;
                DGVParts.Rows.Clear();

                foreach (Part part in Inventory.allParts)
                {
                    if (part.Name.Contains(partSearchTextBox.Text))
                    {
                        DGVParts.Rows.Add(Counter, part.Name, part.InStock, part.Price);
                        Counter++;
                        if (DGVParts.Rows.Count == 0)// Don't allow user to delete a row that doesnt exist.
                        {
                            // do nothing
                        }
                    }
                    else if (partSearchTextBox.Text == "")
                    {
                        DGVParts.Rows.Clear();
                        DrawTheRows();
                        Counter = DGVParts.Rows.Count;
                    }
                    else if (!part.Name.Contains(partSearchTextBox.Text) && DGVParts.Rows.Count > 0)
                    {
                    }
                }
            }
        }
    }
}

// do nothing! Continue forward, strong warrior. +1 str. Why are you still reading this. The earth is flat! Santa is actually black! The moon is a fake projection manufactured by NASA! Water will kill you. Alex Jones is 100% correct on everything, period. Trump is good for the economy (wait that one is real..). WHY ARE YOU STILL READING THIS, GO AWAY. 14 words deus vult!