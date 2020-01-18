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
    public partial class UsingPartForm : Form
    {
        static public int prodIdCounter = 0;
        static public int partIdCounter = 0;
        public bool partSubType; // true = Inhouse sub type, false is outsourced.
        public UsingPartForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e) // Exit child form
        {
            MainScreenForm msF = new MainScreenForm();
            msF.Show();
            msF.DrawTheRows();
            this.Close();
        }
        public void Save_Click(object sender, EventArgs e) // Logic to 'save' the input data into one of the arrays. MAKE AN IF TO DETERMINE WHICH LIST WE USE
        {
            SaveToList(MainScreenForm.workingWithProd);
        }
        public void SaveToList(bool checkListTypeToChange)
        {
            if (checkListTypeToChange == false) // Left DGV is allParts
            {
                if (inHouseRadio.Checked == true)
                {
                    if (MainScreenForm.modifyClicked == true)
                    {
                        idBox.Text = Inventory.allParts[MainScreenForm.indexRow].PartId.ToString();
                        Inventory.allParts[MainScreenForm.indexRow].InStock = int.Parse(invBox.Text);
                        Inventory.allParts[MainScreenForm.indexRow].Min = int.Parse(minBox.Text);
                        Inventory.allParts[MainScreenForm.indexRow].Max = int.Parse(invBox.Text.ToString());
                        Inventory.allParts[MainScreenForm.indexRow].Name = nameBox.Text;
                        Inventory.allParts[MainScreenForm.indexRow].Price = double.Parse(priceBox.Text.ToString());
                        this.Close();
                        MainScreenForm mSF = new MainScreenForm();
                        mSF.DrawTheRows();
                        mSF.Show();

                        MainScreenForm.modifyClicked = false; // Without this global var the user can easily crash the program if they're clever.
                    }
                    else if (MainScreenForm.modifyClicked == false)
                    {
                        idBox.Text = Inventory.allParts.Count.ToString();
                        string name = this.nameBox.Text;
                        int inv = int.Parse(invBox.Text);
                        double price = double.Parse(priceBox.Text);
                        int min = int.Parse(maxBox.Text);
                        int max = int.Parse(minBox.Text);
                        int machId = int.Parse(machNcompBox.Text);
                        Inhouse inhouse = new Inhouse(Inventory.allParts.Count, inv, min, max, name, price, machId);
                        Inventory.allParts.Add(inhouse);
                        this.Close();
                        MainScreenForm msF1 = new MainScreenForm();
                        msF1.DrawTheRows();
                        msF1.Show();
                        prodIdCounter++; // This is intentional.
                    }
                }
                else if (inHouseRadio.Checked == false)
                {
                    if (MainScreenForm.modifyClicked == true)
                    {
                        Inventory.allParts[MainScreenForm.indexRow].InStock = int.Parse(invBox.Text);
                        Inventory.allParts[MainScreenForm.indexRow].Min = int.Parse(minBox.Text);
                        Inventory.allParts[MainScreenForm.indexRow].Max = int.Parse(invBox.Text.ToString());
                        Inventory.allParts[MainScreenForm.indexRow].Name = nameBox.Text;
                        Inventory.allParts[MainScreenForm.indexRow].Price = double.Parse(priceBox.Text.ToString());
                        this.Close();
                        MainScreenForm mSF = new MainScreenForm();
                        mSF.DrawTheRows();
                        mSF.Show();
                        MainScreenForm.modifyClicked = false;
                    }
                    else if (MainScreenForm.modifyClicked == false)
                    {
                        idBox.Text = Inventory.allParts.Count.ToString();
                        string name = this.nameBox.Text;
                        int inv = int.Parse(invBox.Text);
                        double price = double.Parse(priceBox.Text);
                        int min = int.Parse(maxBox.Text);
                        int max = int.Parse(minBox.Text);
                        string compName = machNcompBox.Text;
                        Outsourced outsourced = new Outsourced(Inventory.allParts.Count, inv, min, max, name, price, compName);
                        Inventory.allParts.Add(outsourced);
                        this.Close();
                        MainScreenForm msF1 = new MainScreenForm();
                        msF1.DrawTheRows();
                        msF1.Show();
                        partIdCounter++;
                    }
                }
                //END OF THE PART FORM SAVING CHECKS
                //
                //BEGINNING OF THE PRODUCT FORM CHECKS

                else if (checkListTypeToChange == true)
                {
                    if (inHouseRadio.Checked == false) // Must be a Outsourced type
                    {
                        if (MainScreenForm.modifyClicked == true)
                        {
                            Inventory.allParts[MainScreenForm.indexRow].InStock = int.Parse(invBox.Text);
                            Inventory.allParts[MainScreenForm.indexRow].Min = int.Parse(minBox.Text);
                            Inventory.allParts[MainScreenForm.indexRow].Max = int.Parse(invBox.Text.ToString());
                            Inventory.allParts[MainScreenForm.indexRow].Name = nameBox.Text;
                            Inventory.allParts[MainScreenForm.indexRow].Price = double.Parse(priceBox.Text.ToString());
                            this.Close();
                            MainScreenForm mSF = new MainScreenForm();
                            mSF.DrawTheRows();
                            mSF.Show();

                            MainScreenForm.modifyClicked = false;
                        }
                        else
                        {
                            idBox.Text = partIdCounter.ToString();
                            string name = this.nameBox.Text;
                            int inv = int.Parse(invBox.Text);
                            double price = double.Parse(priceBox.Text);
                            int min = int.Parse(maxBox.Text);
                            int max = int.Parse(minBox.Text);
                            string compName = machNcompBox.Text;
                            Outsourced outsourced = new Outsourced(partIdCounter, inv, min, max, name, price, compName);
                            Inventory.allParts.Add(outsourced);
                            this.Close();
                            MainScreenForm msF1 = new MainScreenForm();
                            msF1.DrawTheRows();
                            msF1.Show();
                            partIdCounter++;
                        }
                    }
                }
            }
        }
        public void OutSrcd_CheckedChanged(object sender, EventArgs e)
        {
            if(outsourcedRadio.Checked)
            {
                machNcompLabel.Text = "Company Name";
                machNcompBox.Text = machNcompBox.Text; // This is important, so the try exception wrong type works.
                //MessageBox.Show("outsource chedked");
            }
            else if(inHouseRadio.Checked)
            {
                machNcompLabel.Text = "Machine ID";
                machNcompBox.Text = machNcompBox.Text;
                //MessageBox.Show("in house chedk chedked");
            }
        }
    }
}
