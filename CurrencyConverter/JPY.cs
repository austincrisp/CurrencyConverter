using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class JPY : Money
    {
        protected double usdToJPYRate = 114.687;
        protected double eurToJPYRate = 121.764;
        protected double btcToJPYRate = 99572.02;

        public JPY(double _amount, string _symbol) : base(_amount, _symbol)
        {
        }

        public override double ToJPY()
        {
            if (symbol == "$")
                return amount * usdToJPYRate;
            else if (symbol == "€")
                return amount * eurToJPYRate;
            else
                return amount * btcToJPYRate;
        }
    }
}