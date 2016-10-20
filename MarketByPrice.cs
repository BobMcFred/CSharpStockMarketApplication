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
    public partial class MarketByPrice : Form, StockMarketDisplay
    {

        string companyName;
        ToolStripMenuItem menuItem;

        List<BuyOrder> buyList;
        List<SellOrder> sellList;

        public MarketByPrice(string name, ToolStripMenuItem item)
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
                dataGridView1[4, i].Value = "";
                dataGridView1[5, i].Value = "";
            }

            buyList = s.getBuyOrders(companyName);  //  get order lists
            sellList = s.getSellOrders(companyName);

            int rowCount = 0;   //  Variables for orders
            int volume = 0;
            double price = 0;
            int amount = 0;

            if (buyList.Count() != 0)   //  If not empty, get the first order
            {
                volume = buyList[0].getSize();
                price = buyList[0].getPrice();
                amount = 1;
                dataGridView1[0, rowCount].Value = amount;
                dataGridView1[1, rowCount].Value = volume;
                dataGridView1[2, rowCount].Value = price;
            }

            for (int i = 1; i < buyList.Count(); i++)   //  Go through all orders
            {
                if (rowCount == 9)  //  Only 10 rows
                {
                    break;
                }
                else if (buyList[i].getPrice() == price)    //  Same price, add volume and increment amount
                {
                    volume += buyList[i].getSize();
                    amount++;
                }
                else  //    Not same price, get new values for new row
                {
                    price = buyList[i].getPrice();
                    volume = buyList[i].getSize();
                    amount = 1;
                    rowCount++;
                }

                dataGridView1[0, rowCount].Value = amount;  //  Display rows
                dataGridView1[1, rowCount].Value = volume;
                dataGridView1[2, rowCount].Value = price;
            }


            rowCount = 0;   //  Reset variables
            volume = 0;
            price = 0;
            amount = 0;

            if (sellList.Count() != 0)   //  If not empty, get the first order
            {
                volume = sellList[0].getSize();
                price = sellList[0].getPrice();
                amount = 1;
                dataGridView1[5, rowCount].Value = amount;
                dataGridView1[4, rowCount].Value = volume;
                dataGridView1[3, rowCount].Value = price;
            }

            for (int i = 1; i < sellList.Count(); i++)   //  Go through all orders
            {
                if (rowCount == 9)  //  Only 10 rows
                {
                    break;
                }
                else if (sellList[i].getPrice() == price)    //  Same price, add volume and increment amount
                {
                    volume += sellList[i].getSize();
                    amount++;
                }
                else  //    Not same price, get new values for new row
                {
                    price = sellList[i].getPrice();
                    volume = sellList[i].getSize();
                    amount = 1;
                    rowCount++;
                }

                dataGridView1[5, rowCount].Value = amount;  //  Display rows
                dataGridView1[4, rowCount].Value = volume;
                dataGridView1[3, rowCount].Value = price;
            }
        }

        private void MarketByPrice_Load(object sender, EventArgs e)
        {
            this.Text = "Market Depth By Price (" + companyName + ")";  //  Form text
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("", "", "", "", "", "");    //  Empty grid
            }
        }

        private void MarketByPrice_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuItem.Enabled = true;    //  Enable menu item to be opened again
            Form1 parent = (Form1)MdiParent;
            parent.unRegister(this);    //  Unregister this observer
        }
    }
}
