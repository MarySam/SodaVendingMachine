using _06._0_Console_As_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Exercise: 6.1 and 6.2
// Author:  Sam, Mary

namespace GUI_Land
{
    public partial class Form1 : Form
    {
        CanRack rack = new CanRack();

        CoinBox myCoin = new CoinBox();

        PurchasePrice myPrice = new PurchasePrice(0.5M);

        //This is the constructor 
        public Form1()
        {
            InitializeComponent();

            insertmoney.Text = string.Format("Please insert {0:C}", myPrice.PriceDecimal);
        }

        private void halfdollar_Click(object sender, EventArgs e)
        {
            myCoin.Deposit(Coin.HALFDOLLARCOIN);
            total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
        }

        private void quarter_Click(object sender, EventArgs e)
        {
            myCoin.Deposit(Coin.QUARTERCOIN);
            total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
        }

        private void dime_Click(object sender, EventArgs e)
        {
            myCoin.Deposit(Coin.DIMECOIN);
            total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
        }

        private void nickel_Click(object sender, EventArgs e)
        {
            myCoin.Deposit(Coin.NICKELCOIN);
            total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
        }

        private void Coinreturn_Click(object sender, EventArgs e)
        {

            decimal change = myCoin.ValueOf;
            myCoin.Withdraw(change);
            total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
            MessageBox.Show("Your change is $" + change.ToString());
        }

        private void ejectcoke_Click(object sender, EventArgs e)
        {
            if (myCoin.ValueOf >= myPrice.PriceDecimal)
            {
                rack.RemoveACanOf(Flavor.REGULAR);
                myCoin.Withdraw(myPrice.PriceDecimal);
                total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
                MessageBox.Show("Enjoy your soda!");
                ejectcoke.Enabled = !rack.IsEmpty(Flavor.REGULAR);
            }
            else
            {
                MessageBox.Show("Please insert the required amount");
            }
            
        }

        private void ejectorange_Click(object sender, EventArgs e)
        {
            if (myCoin.ValueOf >= myPrice.PriceDecimal)
            {
                rack.RemoveACanOf(Flavor.ORANGE);
                myCoin.Withdraw(myPrice.PriceDecimal);
                total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
                MessageBox.Show("Enjoy your soda!");
                ejectorange.Enabled = !rack.IsEmpty(Flavor.ORANGE);
            }
            else
            {
                MessageBox.Show("Please insert the required amount");
            }
        }

        private void ejectlemon_Click(object sender, EventArgs e)
        {
            if (myCoin.ValueOf >= myPrice.PriceDecimal)
            {
                rack.RemoveACanOf(Flavor.LEMON);
                myCoin.Withdraw(myPrice.PriceDecimal);
                total.Text = string.Format("Total: {0:C}", myCoin.ValueOf);
                MessageBox.Show("Enjoy your soda!");
                ejectlemon.Enabled = !rack.IsEmpty(Flavor.LEMON);
            }
            else
            {
                MessageBox.Show("Please insert the required amount");
            }
        }
    }
}

