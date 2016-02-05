using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 5.1, 5.2, 5.3, 5.4
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    class CoinBox
    {
        private List<Coin> box;

        public CoinBox()
        {
            this.box = new List<Coin>();
        }

        public CoinBox(List<Coin> SeedMoney)
        {
            this.box = SeedMoney;
        }

        //Put a coin in the coin box
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
        }

        //Take a coin of the specified denomination out of the box
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            var coins = from coin in this.box
                        where coin.CoinEnumeral == ACoinDenomination
                        select coin;

            Boolean result = false;
            if (coins.Count()>0)
            {
                result = this.box.Remove(coins.First());
                        }
            return result;
        }

        public int HalfDollarCount
        {
            get
            {
                var halfdollars = from coin in this.box
                                  where coin.CoinEnumeral == Coin.Denomination.HALFDOLLAR
                                  select coin;
                return halfdollars.ToList().Count;
            }
        }

        public int QuarterCount
        {
            get
            {
                var quarters = from coin in this.box
                               where coin.CoinEnumeral == Coin.Denomination.QUARTER
                               select coin;
                return quarters.ToList().Count;
            }
        }

        public int DimeCount
        {
            get
            {
                var dimes = from coin in this.box
                            where coin.CoinEnumeral == Coin.Denomination.DIME
                            select coin;
                return dimes.ToList().Count;
            }
        }

        public int NickelCount
        {
            get
            {
                var nickels = from coin in this.box
                              where coin.CoinEnumeral == Coin.Denomination.NICKEL
                              select coin;
                return nickels.ToList().Count;
            }
        }

        public int SlugCount
        {
            get
            {
                var slugs = from coin in this.box
                            where coin.CoinEnumeral == Coin.Denomination.SLUG
                            select coin;

                return slugs.ToList().Count;
            }
        }

        public decimal ValueOf
        {
            get
            {
                decimal result =
                    HalfDollarCount * (decimal)Coin.Denomination.HALFDOLLAR / 100M +
                    QuarterCount * (decimal)Coin.Denomination.QUARTER / 100M +
                    DimeCount * (decimal)Coin.Denomination.DIME / 100M +
                    NickelCount * (decimal)Coin.Denomination.NICKEL / 100M;
                return result;

            }

            //get
            //{
            //    Decimal total = 0;
            //    for (int i = 0; i < this.box.Length; i++)
            //    {
            //        total = total + this.box[i].ValueOf;
            //    }
            //    return total;
            //}

        }

    }

}



