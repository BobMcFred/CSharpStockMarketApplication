using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3352_Assignment_2
{
    public abstract class StockMarket   //  Abstract class for subject
    {

        abstract public void Register(StockMarketDisplay o);
        abstract public void unRegister(StockMarketDisplay o);
        abstract public void Notify();

    }
}
