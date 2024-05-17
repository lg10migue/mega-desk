using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megaDesk
{
    internal class DeskQuote
    {
        public double _quote { get; }
        public string _customerName { get; }
        public string _productionTime { get; }
        public DateTime _quoteDate { get; }

        private Desk _desk;
     
        private Dictionary<Desk.Material, int> materialPrices = new()
        {
            [Desk.Material.Pine] = 50,
            [Desk.Material.Laminate] = 100,
            [Desk.Material.Veneer] = 125,
            [Desk.Material.Oak] = 200,
            [Desk.Material.Rosewood] = 300
        };

        public DeskQuote(string customerName, Desk desk, string productionTime, DateTime quoteDate)
        {
            _customerName = customerName;
            _desk = desk;
            _productionTime = productionTime;
            _quoteDate = quoteDate;
            _quote = calculateQuote();
        }

        int calculateQuote()
        {
            int quote = 200;

            quote += materialPrices[_desk._material];
            quote += _desk._drawerCount * 50;
            quote += _desk._size - 1000;

            if (_productionTime == "3 Days")
            {
                if (_desk._size < 1000)
                {
                    quote += 60;
                }
                else if (_desk._size <= 2000)
                {
                    quote += 70;
                }
                else
                {
                    quote += 80;
                }
            }
            else if (_productionTime == "5 Days")
            {
                if (_desk._size < 1000)
                {
                   quote += 40;
                }
                else if (_desk._size <= 2000)
                {
                    quote += 50;
                }
                else
                {
                    quote += 60;
                }
            }
            else if (_productionTime == "7 Days")
            {
                if (_desk._size < 1000)
                {
                    quote += 30;
                }
                else if (_desk._size <= 2000)
                {
                    quote += 35;
                }
                else
                {
                    quote += 40;
                }
            }

            return quote;
        }
    }
}
