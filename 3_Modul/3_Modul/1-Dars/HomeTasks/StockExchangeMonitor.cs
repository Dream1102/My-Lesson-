using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars.HomeTasks
{
    public class StockExchangeMonitor
    {
        public delegate void Pricechange(int price);

        public Pricechange PricechangeHandler { get; set; }

        public void Start()
        {
            while(true)
            {
                int bankOfAmericaprice =(new Random()).Next(100);

                PricechangeHandler(bankOfAmericaprice);
                Thread.Sleep(2000);
            }
        }

    }
}
