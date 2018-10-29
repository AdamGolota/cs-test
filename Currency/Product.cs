using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency
{
    class Product
    {


        private float priceUSD;
        private int amount;

        static float UAHCurrency = 28;


        public Product()
        {
            priceUSD = 0;
            amount = 0;
        }

        public float PriceUSD
        {
            get
            {
                return priceUSD;
            }
            set
            {
                if (value < 0)
                {
                    throw new ValueNotPositiveException();
                }
                priceUSD = value;
            }
        }
        public float PriceUAH
        {
            get
            {
                return priceUSD * UAHCurrency;
            }
            set
            {
                if (value < 0)
                {
                    throw new ValueNotPositiveException();
                }
                priceUSD = value / UAHCurrency;
            }
        }
        public float CostUSD { get => PriceUSD * amount; }
        public float CostUAH { get => PriceUAH * amount; }
        public int Amount
        {
            get => amount;
            set
            {
                if (value < 0)
                {
                    throw new ValueNotPositiveException();
                }
                amount = value;
            }
        }

    }
}
