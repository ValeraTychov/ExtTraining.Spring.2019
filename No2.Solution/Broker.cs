using System;

namespace No2.Solution
{
    public class Broker
    {
        private IStock stock;

        public string Name { get; set; }

        public Broker(string name, IStock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.StockInfoChanged += Stock_StockInfoChanged;
        }

        public void Stock_StockInfoChanged(object sender, StockInfoChangedEventArgs stockInfo)
        {
            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void StopTrade()
        {
            stock.StockInfoChanged -= Stock_StockInfoChanged;
            stock = null;
        }
    }
}
