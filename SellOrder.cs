using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3352_Assignment_2
{
    public class SellOrder : Order
    {
        //  Variables - orderDateTime is unused but specified in the diagram
        private string oderDateTime;
        private int orderSize;
        private double orderPrice;

        public SellOrder()
        {
            orderPrice = 0;
            orderSize = 0;
        }

        public SellOrder(double price, int size)
        {
            setPrice(price);
            setSize(size);
        }

        //  Set price
        public void setPrice(double price)
        {
            orderPrice = price;
        }

        //  Get price
        public double getPrice()
        {
            return orderPrice;
        }

        //  Set size
        public void setSize(int size)
        {
            orderSize = size;
        }

        //  Get size
        public int getSize()
        {
            return orderSize;
        }
    }
}
