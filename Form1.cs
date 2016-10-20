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
    public partial class Form1 : Form
    {
        //  Variables including the subject in the Observer Model
        RealTimeData s;
        List<ToolStripMenuItem> orderList, priceList;
        string[] companyNames;

        public Form1()
        {
            InitializeComponent();
            s = new RealTimeData(this); //  Initialize subject
            orderList = new List<ToolStripMenuItem>();  //  Dynamic menu items
            priceList = new List<ToolStripMenuItem>();
            companyNames = s.getCompanyNames();
            for (int i = 0; i < companyNames.Length; i++)
            {
                orderList.Add(new ToolStripMenuItem(companyNames[i]));
                priceList.Add(new ToolStripMenuItem(companyNames[i]));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < companyNames.Length; i++)
            {
                orderList[i].Click += new System.EventHandler(marketByOrderToolStripMenuItem_Click);    //  Event handlers for dynamic menu items
                priceList[i].Click += new System.EventHandler(marketByPriceToolStripMenuItem_Click);
                marketByOrderToolStripMenuItem.DropDownItems.Insert(i, orderList[i]);   //  Insert menu items
                marketByPriceToolStripMenuItem.DropDownItems.Insert(i, priceList[i]);
            }
            watchToolStripMenuItem.Visible = false; //  Not visible until market is open
            ordersToolStripMenuItem.Visible = false;
        }

        //  Open market and make menu items visible
        private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            watchToolStripMenuItem.Visible = true;
            ordersToolStripMenuItem.Visible = true;
            beginTradingToolStripMenuItem.Enabled = false;
            stopTradingToolStripMenuItem.Enabled = true;
            marketToolStripMenuItem.Text = "Market <<Open>>";

        }

        //  exit
        private void stopTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            Bid childBid = new Bid(s, menuItem);    //  Create form and pass menu item
            childBid.MdiParent = this;
            childBid.Visible = true;
            bidToolStripMenuItem.Enabled = false;   //  Disable menu item so multiple cannot be opened at the same time
        }

        private void askToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            Sell childSell = new Sell(s, menuItem);    //  Create form and pass menu item
            childSell.MdiParent = this;
            childSell.Visible = true;
            askToolStripMenuItem.Enabled = false;   //  Disable menu item so multiple cannot be opened at the same time
        }

        //  Cascade
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //  Tile horizontally
        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //  Tile vertically
        private void verticalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void marketByOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string company = menuItem.Text;

            MarketByOrder childOrder = new MarketByOrder(company, menuItem);    //  Create form and pass menu item and company name
            childOrder.MdiParent = this;
            childOrder.Visible = true;
            menuItem.Enabled = false;   //  Disable menu item so multiple cannot be opened at the same time

            s.Register(childOrder); //  Register observer
            s.Notify(); //  Notify all observers
        }

        private void marketByPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string company = menuItem.Text;

            MarketByPrice childPrice = new MarketByPrice(company, menuItem);    //  Create form and pass menu item and company name
            childPrice.MdiParent = this;
            childPrice.Visible = true;
            menuItem.Enabled = false;   //  Disable menu item so multiple cannot be opened at the same time

            s.Register(childPrice); //  Register observer
            s.Notify();
        }

        // Unregister observer
        public void unRegister(StockMarketDisplay o)
        {
            s.unRegister(o);    //  Unregisters with subject
        }

        //  Get subject
        public RealTimeData getData()
        {
            return s;
        }

        private void stockStateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            StockStateSummary childSummary = new StockStateSummary(menuItem, companyNames.Length);    //  Create form and pass menu item and amount of companies
            childSummary.MdiParent = this;
            childSummary.Visible = true;
            stockStateSummaryToolStripMenuItem.Enabled = false;   //  Disable menu item so multiple cannot be opened at the same time

            s.Register(childSummary); //  Register observer
            s.Notify(); //  Notify all observers
        }
    }
}
