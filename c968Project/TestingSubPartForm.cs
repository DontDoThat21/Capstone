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
    public partial class TestingSubPartForm : Form
    {
        public TestingSubPartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // inhuse
        {
            MakeOutSourcedPart();
        }
        private void MakeOutSourcedPart()
        {
            Inhouse inhouse = new Inhouse(int.Parse(inH1.Text), int.Parse(inH2.Text), int.Parse(inH3.Text), int.Parse(inH4.Text),inH5.Text,double.Parse(inH6.Text), int.Parse(inH7.Text));
            os1.Text = inhouse.PartId.ToString();
            os2.Text = inhouse.InStock.ToString();
            os3.Text = inhouse.Max.ToString();
            os4.Text = inhouse.Min.ToString();
            os5.Text = inhouse.Name;
            os6.Text = inhouse.Price.ToString();
            os7.Text = inhouse.MachineId.ToString();
        }
    }
}
