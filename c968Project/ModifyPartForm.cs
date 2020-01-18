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
    public partial class ModifyPartForm : MainScreenForm
    {
        public ModifyPartForm()
        {
            //InitializeComponent();
            //textBox1.Text = Inventory.products[indexRow].PartId.ToString();
        }

        private void CancelCloseModify_Button(object sender, EventArgs e)
        {
            this.Visible = false;
        }

    }
}
