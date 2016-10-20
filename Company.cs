using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3352_Assignment_2
{
    public class Company
    {
        //  Holds a list of orders
        List<BuyOrder> buyList = new List<BuyOrder>();
        List<SellOrder> sellList = new List<SellOrder>();

        //  Variables
        private string companyName;
        private string companySymbol;
        private double lastPrice;
        private double startPrice;
        private int volume;

        public Company()
        {
            companyName = "";
            companySymbol = "";
            lastPrice = 0;
            volume = 0;
            startPrice = 0;
        }

        public Company(string name, string symbol, double startPrice)
        {
            companyName = name;
            companySymbol = symbol;
            lastPrice = 0;
            this.startPrice = startPrice;
            volume = 0;
        }

        //  Get and set methods
        public void setLastPrice(double price)
        {
            lastPrice = price;
        }

        public double getLastPrice()
        {
            return lastPrice;
        }

        public int getVolume()
        {
            return volume;
        }

        public string getSymbol()
        {
            return companySymbol;
        }

        public double getStartPrice()
        {
            return startPrice;
        }

        //  Add buy order to the list and sort the list by price
        public void addBuyOrder(double price, int size)
        {
            buyList.Add(new BuyOrder(price, size));
            buyList.Sort((x, y) => x.getPrice().CompareTo(y.getPrice()));
            buyList.Reverse();
            checkTransaction();
        }

        //  Add sell order to the list and sort the list by price
        public void addSellOrder(double price, int size)
        {
            sellList.Add(new SellOrder(price, size));
            sellList.Sort((x, y) => x.getPrice().CompareTo(y.getPrice()));
            checkTransaction();
        }

        //  Checks for possible transactions and makes them
        private void checkTransaction()
        {
            if (buyList.Count() != 0 && sellList.Count != 0)    //  Only if there are buy and sell orders
            {
                if (sellList[0].getPrice() <= buyList[0].getPrice())    //  Only if a buy order is greater than or equal to a sell order
                {
                    setLastPrice(buyList[0].getPrice());    //  Sets last price for summary observer
                    if (sellList[0].getSize() < buyList[0].getSize())   //  Buyer wants more shares than available
                    {
                        int newSize = buyList[0].getSize() - sellList[0].getSize(); //  Update amount order still needs
                        buyList[0].setSize(newSize);
                        volume += sellList[0].getSize();    //  Update volume for summary observer
                        sellList.RemoveAt(0);   //  Remove fulfulled order
                        checkTransaction(); //  Check for more possible transactions
                    }
                    else if (sellList[0].getSize() == buyList[0].getSize()) //  Buyer wants exactly the shares available
                    {
                        volume += sellList[0].getSize();    //  Update volume for summary observer
                        sellList.RemoveAt(0);   //  Remove fulfulled order
                        buyList.RemoveAt(0);   //  Remove fulfulled order
                        checkTransaction(); //  Check for more possible transactions
                    }
                    else
                    {
                        int newSize = sellList[0].getSize() - buyList[0].getSize(); //  Update amount order still needs
                        sellList[0].setSize(newSize);
                        volume += buyList[0].getSize();    //  Update volume for summary observer
                        buyList.RemoveAt(0);   //  Remove fulfulled order
                        checkTransaction(); //  Check for more possible transactions
                    }
                }
            }
        }

        //  Return companyName
        public override string ToString()
        {
            return companyName;
        }

        // Get order lists - used by observers
        public List<BuyOrder> getBuyOrders()
        {
            return buyList;
        }

        public List<SellOrder> getSellOrders()
        {
            return sellList;
        }
    }
}
