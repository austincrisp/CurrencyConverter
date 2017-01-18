using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class BTC : Money
    {
        protected double usdToBTCRate = 0.001148;
        protected double eurToBTCRate = 0.001221;
        protected double jpyToBTCRate = 0.00001;

        public BTC(double _amount, string _symbol) : base(_amount, _symbol)
        {
        }

        public override double ToBTC()
        {
            if (symbol == "$")
                return amount * usdToBTCRate;
            else if (symbol == "€")
                return amount * eurToBTCRate;
            else
                return amount * jpyToBTCRate;
        }
    }
}