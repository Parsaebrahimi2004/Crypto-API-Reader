using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETH
{
    public class PricePercentageError
    {

        public static decimal Calculate(decimal currentPrice, decimal lastPrice)
        {
            decimal percentageError = Math.Abs((currentPrice - lastPrice) / lastPrice) * 100;
            return percentageError;
        }

    }
}
