namespace GUI_Land
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Regular",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Orange",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lemon",
            "3"}, -1);
            this.insertmoney = new System.Windows.Forms.Label();
            this.exactchange = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.Coke = new System.Windows.Forms.PictureBox();
            this.Orange = new System.Windows.Forms.PictureBox();
            this.Lemon = new System.Windows.Forms.PictureBox();
            this.Coinreturn = new System.Windows.Forms.Button();
            this.ejectcoke = new System.Windows.Forms.Button();
            this.ejectorange = new System.Windows.Forms.Button();
            this.ejectlemon = new System.Windows.Forms.Button();
            this.halfdollar = new System.Windows.Forms.Button();
            this.quarter = new System.Windows.Forms.Button();
            this.dime = new System.Windows.Forms.Button();
            this.nickel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emptyinsertedcoinbox = new System.Windows.Forms.Button();
            this.insertedcoinbox = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emptymaincoinbox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maincoinlistview = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FillTheCanRacks = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Coke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lemon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertmoney
            // 
            this.insertmoney.AutoSize = true;
            this.insertmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertmoney.Location = new System.Drawing.Point(504, 6);
            this.insertmoney.Name = "insertmoney";
            this.insertmoney.Size = new System.Drawing.Size(165, 20);
            this.insertmoney.TabIndex = 0;
            this.insertmoney.Text = "Please insert 50 cents";
            // 
            // exactchange
            // 
            this.exactchange.AutoSize = true;
            this.exactchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactchange.Location = new System.Drawing.Point(39, 726);
            this.exactchange.Name = "exactchange";
            this.exactchange.Size = new System.Drawing.Size(158, 16);
            this.exactchange.TabIndex = 1;
            this.exactchange.Text = "Exact change is required.";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(1002, 665);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(51, 24);
            this.total.TabIndex = 2;
            this.total.Text = "Total";
            // 
            // Coke
            // 
            this.Coke.ErrorImage = null;
            this.Coke.Image = ((System.Drawing.Image)(resources.GetObject("Coke.Image")));
            this.Coke.InitialImage = null;
            this.Coke.Location = new System.Drawing.Point(33, 52);
            this.Coke.Name = "Coke";
            this.Coke.Size = new System.Drawing.Size(298, 503);
            this.Coke.TabIndex = 3;
            this.Coke.TabStop = false;
            // 
            // Orange
            // 
            this.Orange.Image = ((System.Drawing.Image)(resources.GetObject("Orange.Image")));
            this.Orange.Location = new System.Drawing.Point(442, 52);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(265, 503);
            this.Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Orange.TabIndex = 4;
            this.Orange.TabStop = false;
            // 
            // Lemon
            // 
            this.Lemon.Image = ((System.Drawing.Image)(resources.GetObject("Lemon.Image")));
            this.Lemon.Location = new System.Drawing.Point(792, 52);
            this.Lemon.Name = "Lemon";
            this.Lemon.Size = new System.Drawing.Size(275, 503);
            this.Lemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Lemon.TabIndex = 5;
            this.Lemon.TabStop = false;
            // 
            // Coinreturn
            // 
            this.Coinreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coinreturn.Location = new System.Drawing.Point(827, 717);
            this.Coinreturn.Name = "Coinreturn";
            this.Coinreturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Coinreturn.Size = new System.Drawing.Size(108, 33);
            this.Coinreturn.TabIndex = 6;
            this.Coinreturn.Text = "Coin Return";
            this.Coinreturn.UseVisualStyleBackColor = true;
            this.Coinreturn.Click += new System.EventHandler(this.Coinreturn_Click);
            // 
            // ejectcoke
            // 
            this.ejectcoke.Location = new System.Drawing.Point(197, 598);
            this.ejectcoke.Name = "ejectcoke";
            this.ejectcoke.Size = new System.Drawing.Size(75, 23);
            this.ejectcoke.TabIndex = 7;
            this.ejectcoke.Text = "Dispense";
            this.ejectcoke.UseVisualStyleBackColor = true;
            this.ejectcoke.Click += new System.EventHandler(this.ejectcoke_Click);
            // 
            // ejectorange
            // 
            this.ejectorange.Location = new System.Drawing.Point(588, 598);
            this.ejectorange.Name = "ejectorange";
            this.ejectorange.Size = new System.Drawing.Size(75, 23);
            this.ejectorange.TabIndex = 8;
            this.ejectorange.Text = "Dispense";
            this.ejectorange.UseVisualStyleBackColor = true;
            this.ejectorange.Click += new System.EventHandler(this.ejectorange_Click);
            // 
            // ejectlemon
            // 
            this.ejectlemon.Location = new System.Drawing.Point(949, 598);
            this.ejectlemon.Name = "ejectlemon";
            this.ejectlemon.Size = new System.Drawing.Size(75, 23);
            this.ejectlemon.TabIndex = 9;
            this.ejectlemon.Text = "Dispense";
            this.ejectlemon.UseVisualStyleBackColor = true;
            this.ejectlemon.Click += new System.EventHandler(this.ejectlemon_Click);
            // 
            // halfdollar
            // 
            this.halfdollar.Location = new System.Drawing.Point(64, 653);
            this.halfdollar.Name = "halfdollar";
            this.halfdollar.Size = new System.Drawing.Size(75, 23);
            this.halfdollar.TabIndex = 10;
            this.halfdollar.Text = "HalfDollar";
            this.halfdollar.UseVisualStyleBackColor = true;
            this.halfdollar.Click += new System.EventHandler(this.halfdollar_Click);
            // 
            // quarter
            // 
            this.quarter.Location = new System.Drawing.Point(174, 653);
            this.quarter.Name = "quarter";
            this.quarter.Size = new System.Drawing.Size(75, 23);
            this.quarter.TabIndex = 11;
            this.quarter.Text = "Quarter";
            this.quarter.UseVisualStyleBackColor = true;
            this.quarter.Click += new System.EventHandler(this.quarter_Click);
            // 
            // dime
            // 
            this.dime.Location = new System.Drawing.Point(283, 653);
            this.dime.Name = "dime";
            this.dime.Size = new System.Drawing.Size(75, 23);
            this.dime.TabIndex = 12;
            this.dime.Text = "Dime";
            this.dime.UseVisualStyleBackColor = true;
            this.dime.Click += new System.EventHandler(this.dime_Click);
            // 
            // nickel
            // 
            this.nickel.Location = new System.Drawing.Point(408, 653);
            this.nickel.Name = "nickel";
            this.nickel.Size = new System.Drawing.Size(75, 23);
            this.nickel.TabIndex = 13;
            this.nickel.Text = "Nickel";
            this.nickel.UseVisualStyleBackColor = true;
            this.nickel.Click += new System.EventHandler(this.nickel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1187, 785);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.Click += new System.EventHandler(this.Vend_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Coke);
            this.tabPage1.Controls.Add(this.insertmoney);
            this.tabPage1.Controls.Add(this.nickel);
            this.tabPage1.Controls.Add(this.Orange);
            this.tabPage1.Controls.Add(this.dime);
            this.tabPage1.Controls.Add(this.Lemon);
            this.tabPage1.Controls.Add(this.quarter);
            this.tabPage1.Controls.Add(this.ejectcoke);
            this.tabPage1.Controls.Add(this.halfdollar);
            this.tabPage1.Controls.Add(this.exactchange);
            this.tabPage1.Controls.Add(this.ejectlemon);
            this.tabPage1.Controls.Add(this.total);
            this.tabPage1.Controls.Add(this.ejectorange);
            this.tabPage1.Controls.Add(this.Coinreturn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1179, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vend";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1179, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.emptyinsertedcoinbox);
            this.groupBox2.Controls.Add(this.insertedcoinbox);
            this.groupBox2.Controls.Add(this.emptymaincoinbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.maincoinlistview);
            this.groupBox2.Location = new System.Drawing.Point(550, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CoinBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inserted Coin Box";
            // 
            // emptyinsertedcoinbox
            // 
            this.emptyinsertedcoinbox.Location = new System.Drawing.Point(407, 275);
            this.emptyinsertedcoinbox.Name = "emptyinsertedcoinbox";
            this.emptyinsertedcoinbox.Size = new System.Drawing.Size(122, 184);
            this.emptyinsertedcoinbox.TabIndex = 4;
            this.emptyinsertedcoinbox.Text = "Empty Inserted Coin Box";
            this.emptyinsertedcoinbox.UseVisualStyleBackColor = true;
            this.emptyinsertedcoinbox.Click += new System.EventHandler(this.emptyinsertedcoinbox_Click);
            // 
            // insertedcoinbox
            // 
            this.insertedcoinbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.insertedcoinbox.GridLines = true;
            this.insertedcoinbox.Location = new System.Drawing.Point(35, 275);
            this.insertedcoinbox.Name = "insertedcoinbox";
            this.insertedcoinbox.Size = new System.Drawing.Size(184, 184);
            this.insertedcoinbox.TabIndex = 3;
            this.insertedcoinbox.UseCompatibleStateImageBehavior = false;
            this.insertedcoinbox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Coins";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Number";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            // 
            // emptymaincoinbox
            // 
            this.emptymaincoinbox.Location = new System.Drawing.Point(407, 36);
            this.emptymaincoinbox.Name = "emptymaincoinbox";
            this.emptymaincoinbox.Size = new System.Drawing.Size(122, 177);
            this.emptymaincoinbox.TabIndex = 2;
            this.emptymaincoinbox.Text = "Empty Main Coin Box";
            this.emptymaincoinbox.UseVisualStyleBackColor = true;
            this.emptymaincoinbox.Click += new System.EventHandler(this.emptymaincoinbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Coin Box";
            // 
            // maincoinlistview
            // 
            this.maincoinlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.maincoinlistview.GridLines = true;
            this.maincoinlistview.Location = new System.Drawing.Point(35, 36);
            this.maincoinlistview.Name = "maincoinlistview";
            this.maincoinlistview.Size = new System.Drawing.Size(184, 177);
            this.maincoinlistview.TabIndex = 0;
            this.maincoinlistview.UseCompatibleStateImageBehavior = false;
            this.maincoinlistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Coins";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Number";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FillTheCanRacks);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(35, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Can Racks";
            // 
            // FillTheCanRacks
            // 
            this.FillTheCanRacks.Location = new System.Drawing.Point(64, 145);
            this.FillTheCanRacks.Name = "FillTheCanRacks";
            this.FillTheCanRacks.Size = new System.Drawing.Size(159, 54);
            this.FillTheCanRacks.TabIndex = 1;
            this.FillTheCanRacks.Text = "Fill The Can Racks";
            this.FillTheCanRacks.UseVisualStyleBackColor = true;
            this.FillTheCanRacks.Click += new System.EventHandler(this.FillTheCanRacks_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(64, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(159, 106);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Flavor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number of Cans Left";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 829);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Welcome to the .NET Soda Machine! ";
            ((System.ComponentModel.ISupportInitialize)(this.Coke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lemon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label insertmoney;
        private System.Windows.Forms.Label exactchange;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.PictureBox Coke;
        private System.Windows.Forms.PictureBox Orange;
        private System.Windows.Forms.PictureBox Lemon;
        private System.Windows.Forms.Button Coinreturn;
        private System.Windows.Forms.Button ejectcoke;
        private System.Windows.Forms.Button ejectorange;
        private System.Windows.Forms.Button ejectlemon;
        private System.Windows.Forms.Button halfdollar;
        private System.Windows.Forms.Button quarter;
        private System.Windows.Forms.Button dime;
        private System.Windows.Forms.Button nickel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button FillTheCanRacks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button emptymaincoinbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView maincoinlistview;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button emptyinsertedcoinbox;
        private System.Windows.Forms.ListView insertedcoinbox;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label2;
    }
}

