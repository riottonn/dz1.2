using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1._2
{
    public class Converter
    {
        public decimal UsdRate { get; set; }
        public decimal EurRate { get; set; }

        public Converter(decimal usdRate, decimal eurRate)
        {
            UsdRate = usdRate;
            EurRate = eurRate;
        }
        public decimal FromUAHtoUSD(decimal uah)
        {
            return uah / UsdRate;
        }

        public decimal FromUAHtoEUR(decimal uah)
        {
            return uah / EurRate;
        }
        public decimal FromUSDtoUAH(decimal usd)
        {
            return usd * UsdRate;
        }

        public decimal FromEURtoUAH(decimal eur)
        {
            return eur * EurRate;
        }
    }
}
