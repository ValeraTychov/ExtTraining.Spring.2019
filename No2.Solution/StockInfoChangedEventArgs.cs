using System;

namespace No2.Solution
{
    public class StockInfoChangedEventArgs : EventArgs
    {
        public StockInfoChangedEventArgs(int usd, int euro)
        {
            USD = usd;
            Euro = euro;
        }

        public int USD { get; set; }
        public int Euro { get; set; }
    }
}