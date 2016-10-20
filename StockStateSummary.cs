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
    public partial class StockStateSummary : Form, StockMarketDisplay
    {

        ToolStripMenuItem menuItem;
        int companies;
        Bitmap positive, negative, neutral;

        public StockStateSummary(ToolStripMenuItem item, int companies) //  Initialize variables
        {
            InitializeComponent();
            menuItem = item;
            this.companies = companies;
           
            positive = new Bitmap("../../bin/up.bmp");
            negative = new Bitmap("../../bin/down.bmp");
            neutral = new Bitmap("../../bin/noChange.bmp");
        }

        void StockMarketDisplay.Update(RealTimeData s)
        {
            List<Company> companyList = s.getCompanyList(); //  Get list of companies
            for (int i = 0; i < companyList.Count(); i++)
            {
                string name = companyList[i].ToString();    //  Data for each company
                string symbol = companyList[i].getSymbol();
                double startPrice = companyList[i].getStartPrice();
                double lastPrice = companyList[i].getLastPrice();
                int volume = companyList[i].getVolume();

                double changeNet = startPrice - lastPrice;
                double changePercent = Math.Abs(changeNet) / startPrice;

                dataGridView1[0, i].Value = name;   //  Display data
                dataGridView1[1, i].Value = symbol;
                dataGridView1[2, i].Value = startPrice;

                if (lastPrice != 0) //  Dont display default data
                {
                    dataGridView1[3, i].Value = lastPrice;   //  Display data
                    dataGridView1[4, i].Value = Math.Abs(changeNet);
                    dataGridView1[6, i].Value = changePercent;

                    if (changeNet > 0)
                    {
                        dataGridView1[5, i].Value = negative;
                    }
                    else if (changeNet < 0)
                    {
                        dataGridView1[5, i].Value = positive;
                    }
                    else
                    {
                        dataGridView1[5, i].Value = neutral;
                    }
                }
                else
                {
                    dataGridView1[5, i].Value = neutral;    //  Default image when there is no data
                }
                dataGridView1[7, i].Value = volume;   //  Display data
            }
        }

        private void StockStateSummary_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < companies; i++) //  Add a row for each company
            {
                dataGridView1.Rows.Add();
            }
        }

        private void StockStateSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuItem.Enabled = true;    //  Enable menu item to be opened again
            Form1 parent = (Form1)MdiParent;
            parent.unRegister(this);    //  Unregister this observer
        }
    }
}
