using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Money
    {
        // Initialize Variables
        public double amount;
        public string symbol;
        //Dictionary<string, double> rate = new Dictionary<string, double>();
        public string dollarSign = "$"; // key symbol, value rate
        public string euroSign   = "€";
        public string jpySign    = "¥";
        public string btcSign    = "Ƀ";

        // Default Constructor
        public Money() {  }

        public Money(double _amount, string _symbol)
        {
            amount = _amount;
            symbol = _symbol;
        }

        public virtual double ToUSD()
        {
            return 0;
        }

        public virtual double ToEUR()
        {
            return 0;
        }

        public virtual double ToJPY()
        {
            return 0;
        }

        public virtual double ToBTC()
        {
            return 0;
        }
    }
}
