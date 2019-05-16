using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public interface IStock
    {
        event EventHandler<StockInfoChangedEventArgs> StockInfoChanged;
    }
}
