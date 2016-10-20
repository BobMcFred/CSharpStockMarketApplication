using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3352_Assignment_2
{
    public interface StockMarketDisplay //  Interface for observers
    {
        void Update(RealTimeData s);
    }
}
