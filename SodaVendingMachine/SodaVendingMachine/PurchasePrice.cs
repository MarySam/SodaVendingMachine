using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 2.1 and 2.2
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    class PurchasePrice
    {
        //Constructor to set the purchase price to zero.
        public PurchasePrice()
        {
            Price = 0;
        }

        //Constructor to allow the user to set the new purchase price.
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        //Property to get and set the value of the purchase price.
        public int Price { get; set; }
    }
}
