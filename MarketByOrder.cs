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
    public partial class MarketByOrder : Form, StockMarketDisplay
    {

        string companyName;
        ToolStripMenuItem menuItem;

        List<BuyOrder> buyList;
        List<SellOrder> sellList;

        public MarketByOrder(string name, ToolStripMenuItem item)
        {
            InitializeComponent();  //  Initialize
            companyName = name;
            menuItem = item;
            buyList = new List<BuyOrder>();
            sellList = new List<SellOrder>();
        }

        void StockMarketDisplay.Update(RealTimeData s)
        {
            for (int i = 0; i < 10; i++)
            {
                dataGridView1[0, i].Value = ""; //  Clear grid
                dataGridView1[1, i].Value = "";
                dataGridView1[2, i].Value = "";
                dataGridView1[3, i].Value = "";
            }

            buyList = s.getBuyOrders(companyName);  //  get order lists
            sellList = s.getSellOrders(companyName);

            int buyLimit = 10;

            if (buyList.Count() < buyLimit) //  Only show up to 10 orders
            {
                buyLimit = buyList.Count();
            }

            int sellLimit = 10;

            if (sellList.Count() < sellLimit) //  Only show up to 10 orders
            {
                sellLimit = sellList.Count();
            }

            for (int i = 0; i < buyLimit; i++)
            {
                dataGridView1[0, i].Value = buyList[i].getSize();   //  Display info
                dataGridView1[1, i].Value = buyList[i].getPrice();
            }

            for (int i = 0; i < sellLimit; i++)
            {
                dataGridView1[2, i].Value = sellList[i].getPrice();   //  Display info
                dataGridView1[3, i].Value = sellList[i].getSize();
            }
        }

        private void MarketByOrder_Load(object sender, EventArgs e)
        {
            this.Text = "Market Depth By Order (" + companyName + ")";  //  Form text
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("","","","");    //  Empty grid
            }
        }

        private void MarketByOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuItem.Enabled = true;    //  Enable menu item to be opened again
            Form1 parent = (Form1)MdiParent;
            parent.unRegister(this);    //  Unregister this observer
        }
    }
}
