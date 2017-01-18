using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class USD : Money
    {
        public double eurToUSDRate = 1.06319;
        public double jpyToUSDRate = 0.00873787;
        public double btcToUSDRate = 872.11;

        public USD(double _amount, string _symbol) : base(_amount, _symbol)
        {
        }

        public override double ToUSD()
        {
            // amount * dictionary[symbol]
            if (symbol == "€")
                return amount * eurToUSDRate;
            else if (symbol == "¥")
                return amount * jpyToUSDRate;
            else
                return amount * btcToUSDRate;
        }
    }
}