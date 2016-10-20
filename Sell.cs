using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE3352_Assignment_2
{
    public partial class Sell : Form
    {

        string[] companyNames;
        RealTimeData s;
        ToolStripMenuItem menuItem;

        public Sell(RealTimeData s, ToolStripMenuItem item)
        {
            InitializeComponent();
            this.s = s;
            companyNames = s.getCompanyNames();
            menuItem = item;
        }

        //  Close form and enable the menu item in the parent form
        private void button2_Click(object sender, EventArgs e)
        {
            menuItem.Enabled = true;
            this.Close();
        }

        //  Add items to the combobox
        private void Sell_Load(object sender, EventArgs e)
        {
            cmbShares.Items.AddRange(companyNames);
        }

        //  Validate inputs, create a SellOrder, notify observers, and clear inputs
        private void submit_Click(object sender, EventArgs e)
        {
            double price;
            int size;

            if (cmbShares.SelectedItem == null || double.TryParse(txtPrice.Text, out price) == false || int.TryParse(txtNum.Text, out size) == false)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            string name = cmbShares.SelectedItem.ToString();

            s.addSellOrder(name, price, size);
            s.Notify();
            txtPrice.Clear();
            txtNum.Clear();
        }
    }
}
