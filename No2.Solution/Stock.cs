using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class Stock : IStock
    {
        public event EventHandler<StockInfoChangedEventArgs> StockInfoChanged;

        public void Market()
        {
            Random rnd = new Random(DateTime.Now.Second);
            int USD = rnd.Next(20, 40);
            int Euro = rnd.Next(30, 50);
            OnStockInfoChanged(new StockInfoChangedEventArgs(USD, Euro));
        }

        protected virtual void OnStockInfoChanged(StockInfoChangedEventArgs args)
        {
            StockInfoChanged?.Invoke(this, args);
        }
    }
}
