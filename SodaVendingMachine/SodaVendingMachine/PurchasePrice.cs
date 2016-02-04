using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 5.1, 5.2, 5.3, 5.4
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    class PurchasePrice
    {
        private decimal decimalPrice;

        //Constructor to set the purchase price to zero.
        public PurchasePrice()
        {
            Price = 0;
        }

        //Constructor to allow the user to set the new purchase price.
        public PurchasePrice(int initialPrice)
        {
            this.Price = initialPrice;
        }

        //Property to get and set the value of the purchase price.
        public int Price
        {
            get
            {
                return (int)(decimalPrice * 100M);
            }
            set
            {
                this.decimalPrice = value / 100M;
            }
        }

        //Property to get and set the value of the purchase price.
        public decimal DecimalPrice
        {
            get
            {
                return this.decimalPrice;
            }
            set
            {
                this.decimalPrice = value;
            }
        }
    }
}
