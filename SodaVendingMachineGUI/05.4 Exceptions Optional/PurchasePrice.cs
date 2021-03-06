﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._4_Exceptions_Optional
{
    //  This class represents the purchase price of something.
    //  In our software project, we will use it to represent the price of
    //  one can of soda.
    class PurchasePrice
    {
        decimal price = 0M;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            price = 0M; 
        }
        // This constructor allows a new purchase price to be set by the user
        [Obsolete("Use the decimal version of this constructor instead",false)]
        public PurchasePrice(int initialPrice)
        {
            price = ((decimal)initialPrice) / 100M;
        }

        public PurchasePrice(decimal initialPrice)
        {
            price = initialPrice;
        }
        //  This property gets and sets the value the purchase price.
        [Obsolete("Use the decimal version of this property instead",false)]
        public int Price
        {
            get
            {
                return (int)(price * 100);
            }
        }

        //  This property gets and sets the value the purchase price.        
        public decimal PriceDecimal
        {
            get
            {
                return price;
            }
        }
    } //end PurchasePrice

}