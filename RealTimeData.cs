using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3352_Assignment_2
{
    public class RealTimeData : StockMarket
    {

        List<StockMarketDisplay> displayList = new List<StockMarketDisplay>();  //  List of observers
        List<Company> companyList = new List<Company>();    //  List of companies
        Form1 form;

        public RealTimeData(Form1 form)
        {
            companyList.Add(new Company("Microsoft Corporation", "MSFT", 46.13));   //  Hard coded companies
            companyList.Add(new Company("Apple Inc.", "AAPL", 105.22));
            companyList.Add(new Company("Facebook Inc.", "FB", 80.67));
            this.form = form;
        }

        override public void Register(StockMarketDisplay o)
        {
            displayList.Add(o); //  Register Observer
        }

        override public void unRegister(StockMarketDisplay o)
        {
            displayList.Remove(o);  //  Remove observer
        }

        override public void Notify()
        {
            for (int i = 0; i < displayList.Count(); i++)
            {
                displayList[i].Update(this);    //  Notify observers
            }
        }

        //  Get array of company names
        public string[] getCompanyNames()
        {
            string[] names = new string[companyList.Count()];
            for (int i = 0; i < companyList.Count(); i++)
            {
                names[i] = companyList[i].ToString();
            }
            return names;
        }

        //  Add buy order to a company
        public void addBuyOrder(string company, double price, int size)
        {
            for (int i = 0; i < companyList.Count(); i++)
            {
                if (companyList[i].ToString() == company)
                {
                    companyList[i].addBuyOrder(price, size);
                    break;
                }
            }
        }

        //  Add a sell order to a company
        public void addSellOrder(string company, double price, int size)
        {
            for (int i = 0; i < companyList.Count(); i++)
            {
                if (companyList[i].ToString() == company)
                {
                    companyList[i].addSellOrder(price, size);
                    break;
                }
            }
        }

        //  Get list of orders
        public List<BuyOrder> getBuyOrders(string company)
        {
            List<BuyOrder> buyOrders = new List<BuyOrder>();
            for (int i = 0; i < companyList.Count(); i++)
            {
                if (companyList[i].ToString() == company)
                {
                    buyOrders = companyList[i].getBuyOrders();
                }
            }
            return buyOrders;
        }

        //  Get list of orders
        public List<SellOrder> getSellOrders(string company)
        {
            List<SellOrder> sellOrders = new List<SellOrder>();
            for (int i = 0; i < companyList.Count(); i++)
            {
                if (companyList[i].ToString() == company)
                {
                    sellOrders = companyList[i].getSellOrders();
                }
            }
            return sellOrders;
        }

        //  Get list of companies
        public List<Company> getCompanyList()
        {
            return companyList;
        }
    }
}
