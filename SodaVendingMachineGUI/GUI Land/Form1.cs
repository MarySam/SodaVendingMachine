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

// Exercise: 7
// Author:  Sam, Mary

namespace GUI_Land
{
    public partial class Form1 : Form
    {
        CanRack rack = new CanRack();

        CoinBox mainCoinBox = new CoinBox(new List<Coin> {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

        CoinBox insertedCoin = new CoinBox();

        PurchasePrice myPrice = new PurchasePrice(0.5M);

        //This is the constructor 
        public Form1()
        {
            InitializeComponent();

            insertmoney.Text = string.Format("Please insert {0:C}", myPrice.PriceDecimal);
            updateServiceViews();
            updateVendViews();
        }

        private void halfdollar_Click(object sender, EventArgs e)
        {
            insertedCoin.Deposit(Coin.HALFDOLLARCOIN);
            updateVendViews();
        }

        private void quarter_Click(object sender, EventArgs e)
        {
            insertedCoin.Deposit(Coin.QUARTERCOIN);
            updateVendViews();
        }

        private void dime_Click(object sender, EventArgs e)
        {
            insertedCoin.Deposit(Coin.DIMECOIN);
            updateVendViews();
        }

        private void nickel_Click(object sender, EventArgs e)
        {
            insertedCoin.Deposit(Coin.NICKELCOIN);
            updateVendViews();
        }

        private void Coinreturn_Click(object sender, EventArgs e)
        {

            decimal change = insertedCoin.ValueOf;
            insertedCoin.Withdraw(change);
            updateVendViews();
            MessageBox.Show("Your change is $" + change.ToString());
        }

        private void ejectcoke_Click(object sender, EventArgs e)
        {
            if (insertedCoin.ValueOf >= myPrice.PriceDecimal)
            {
                rack.RemoveACanOf(Flavor.REGULAR);
                insertedCoin.Transfer(mainCoinBox, myPrice.PriceDecimal, false);
                total.Text = string.Format("Total: {0:C}", insertedCoin.ValueOf);
                MessageBox.Show("Enjoy your soda!");
                ejectcoke.Enabled = !rack.IsEmpty(Flavor.REGULAR);
            }
            else
            {
                MessageBox.Show("Please insert the required amount");
            }

            updateVendViews();
        }

        private void ejectorange_Click(object sender, EventArgs e)
        {
            if (insertedCoin.ValueOf >= myPrice.PriceDecimal)
            {
                rack.RemoveACanOf(Flavor.ORANGE);
                insertedCoin.Transfer(mainCoinBox, myPrice.PriceDecimal, false);
                total.Text = string.Format("Total: {0:C}", insertedCoin.ValueOf);
                MessageBox.Show("Enjoy your soda!");
                ejectorange.Enabled = !rack.IsEmpty(Flavor.ORANGE);
            }
            else
            {
                MessageBox.Show("Please insert the required amount");
            }

            updateVendViews();
        }

        private void ejectlemon_Click(object sender, EventArgs e)
        {
            if (insertedCoin.ValueOf >= myPrice.PriceDecimal)
            {
                rack.RemoveACanOf(Flavor.LEMON);
                insertedCoin.Transfer(mainCoinBox, myPrice.PriceDecimal, false);
                total.Text = string.Format("Total: {0:C}", insertedCoin.ValueOf);
                MessageBox.Show("Enjoy your soda!");
                ejectlemon.Enabled = !rack.IsEmpty(Flavor.LEMON);
            }
            else
            {
                MessageBox.Show("Please insert the required amount");
            }

            updateVendViews();
        }

        private void constructCoinBoxDisplay(ListView CoinBoxDisplay, CoinBox CoinBoxToDisplay)
        {
            CoinBoxDisplay.Items.Clear();
            List<Coin.Denomination> reverseCoinList = new List<Coin.Denomination>(Coin.AllDenominations);
            reverseCoinList.Reverse();

            foreach (Coin.Denomination coinDenomination in reverseCoinList)
            {
                int coinCount = CoinBoxToDisplay.coinCount(coinDenomination);
                decimal coinsValue = coinCount * Coin.ValueOfCoin(coinDenomination);
                ListViewItem coinRow = new ListViewItem(coinDenomination.ToString());
                coinRow.SubItems.Add(coinCount.ToString());
                coinRow.SubItems.Add(string.Format("{0:c}", coinsValue));
                CoinBoxDisplay.Items.Add(coinRow);
            }

            ListViewItem totalRow = new ListViewItem("Total");
            totalRow.SubItems.Add(string.Empty);
            totalRow.SubItems.Add(string.Format("{0:c}",
                CoinBoxToDisplay.ValueOf));
            CoinBoxDisplay.Items.Add(totalRow);
        }

        private void updateListView()
        {
            listView1.Items.Clear();

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                ListViewItem lv1 = new ListViewItem(aFlavor.ToString());
                lv1.SubItems.Add(rack[aFlavor].ToString());
                listView1.Items.Add(lv1);
            }
        }

        private void updateVendViews()
        {
            total.Text = string.Format("Total: {0:C}", insertedCoin.ValueOf);
        }

        private void updateServiceViews()
        {
            updateListView();
            constructCoinBoxDisplay(maincoinlistview, mainCoinBox);
            constructCoinBoxDisplay(insertedcoinbox, insertedCoin);
        }

        private void tab_Click(object sender, EventArgs e)
        {
            updateServiceViews();
        }

        private void Vend_Click(object sender, EventArgs e)
        {
            updateServiceViews();
            updateVendViews();
        }

        private void FillTheCanRacks_Click(object sender, EventArgs e)
        {
            rack.FillTheCanRack();
            updateServiceViews();
        }

        private void emptymaincoinbox_Click(object sender, EventArgs e)
        {
            mainCoinBox.Withdraw(mainCoinBox.ValueOf);
            updateServiceViews();
        }

        private void emptyinsertedcoinbox_Click(object sender, EventArgs e)
        {
            insertedCoin.Withdraw(insertedCoin.ValueOf);
            updateServiceViews();
        }

        private void servicenotebutton_Click(object sender, EventArgs e)
        {
            Form2 serviceContainer = new Form2();
            serviceContainer.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

