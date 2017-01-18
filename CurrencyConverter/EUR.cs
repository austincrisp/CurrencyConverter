using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class EUR : Money
    {
        protected double usdToEURRate = 0.940570;
        protected double jpyToEURRate = 0.00821258;
        protected double btcToEURRate = 822.15;

        public EUR(double _amount, string _symbol) : base(_amount, _symbol)
        {
        }

        public override double ToEUR()
        {
            if (symbol == "$")
                return amount * usdToEURRate;
            else if (symbol == "¥")
                return amount * jpyToEURRate;
            else
                return amount * btcToEURRate;
        }
    }
}