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
            ((System.ComponentModel.ISupportInitialize)(this.Coke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lemon)).BeginInit();
            this.SuspendLayout();
            // 
            // insertmoney
            // 
            this.insertmoney.AutoSize = true;
            this.insertmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertmoney.Location = new System.Drawing.Point(510, 9);
            this.insertmoney.Name = "insertmoney";
            this.insertmoney.Size = new System.Drawing.Size(165, 20);
            this.insertmoney.TabIndex = 0;
            this.insertmoney.Text = "Please insert 50 cents";
            // 
            // exactchange
            // 
            this.exactchange.AutoSize = true;
            this.exactchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactchange.Location = new System.Drawing.Point(12, 676);
            this.exactchange.Name = "exactchange";
            this.exactchange.Size = new System.Drawing.Size(158, 16);
            this.exactchange.TabIndex = 1;
            this.exactchange.Text = "Exact change is required.";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(975, 615);
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
            this.Coke.Location = new System.Drawing.Point(52, 30);
            this.Coke.Name = "Coke";
            this.Coke.Size = new System.Drawing.Size(311, 510);
            this.Coke.TabIndex = 3;
            this.Coke.TabStop = false;
            // 
            // Orange
            // 
            this.Orange.Image = ((System.Drawing.Image)(resources.GetObject("Orange.Image")));
            this.Orange.Location = new System.Drawing.Point(441, 32);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(278, 508);
            this.Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Orange.TabIndex = 4;
            this.Orange.TabStop = false;
            // 
            // Lemon
            // 
            this.Lemon.Image = ((System.Drawing.Image)(resources.GetObject("Lemon.Image")));
            this.Lemon.Location = new System.Drawing.Point(811, 32);
            this.Lemon.Name = "Lemon";
            this.Lemon.Size = new System.Drawing.Size(277, 508);
            this.Lemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Lemon.TabIndex = 5;
            this.Lemon.TabStop = false;
            // 
            // Coinreturn
            // 
            this.Coinreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coinreturn.Location = new System.Drawing.Point(800, 667);
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
            this.ejectcoke.Location = new System.Drawing.Point(170, 548);
            this.ejectcoke.Name = "ejectcoke";
            this.ejectcoke.Size = new System.Drawing.Size(75, 23);
            this.ejectcoke.TabIndex = 7;
            this.ejectcoke.Text = "Dispense";
            this.ejectcoke.UseVisualStyleBackColor = true;
            this.ejectcoke.Click += new System.EventHandler(this.ejectcoke_Click);
            // 
            // ejectorange
            // 
            this.ejectorange.Location = new System.Drawing.Point(561, 548);
            this.ejectorange.Name = "ejectorange";
            this.ejectorange.Size = new System.Drawing.Size(75, 23);
            this.ejectorange.TabIndex = 8;
            this.ejectorange.Text = "Dispense";
            this.ejectorange.UseVisualStyleBackColor = true;
            this.ejectorange.Click += new System.EventHandler(this.ejectorange_Click);
            // 
            // ejectlemon
            // 
            this.ejectlemon.Location = new System.Drawing.Point(922, 548);
            this.ejectlemon.Name = "ejectlemon";
            this.ejectlemon.Size = new System.Drawing.Size(75, 23);
            this.ejectlemon.TabIndex = 9;
            this.ejectlemon.Text = "Dispense";
            this.ejectlemon.UseVisualStyleBackColor = true;
            this.ejectlemon.Click += new System.EventHandler(this.ejectlemon_Click);
            // 
            // halfdollar
            // 
            this.halfdollar.Location = new System.Drawing.Point(37, 603);
            this.halfdollar.Name = "halfdollar";
            this.halfdollar.Size = new System.Drawing.Size(75, 23);
            this.halfdollar.TabIndex = 10;
            this.halfdollar.Text = "HalfDollar";
            this.halfdollar.UseVisualStyleBackColor = true;
            this.halfdollar.Click += new System.EventHandler(this.halfdollar_Click);
            // 
            // quarter
            // 
            this.quarter.Location = new System.Drawing.Point(147, 603);
            this.quarter.Name = "quarter";
            this.quarter.Size = new System.Drawing.Size(75, 23);
            this.quarter.TabIndex = 11;
            this.quarter.Text = "Quarter";
            this.quarter.UseVisualStyleBackColor = true;
            this.quarter.Click += new System.EventHandler(this.quarter_Click);
            // 
            // dime
            // 
            this.dime.Location = new System.Drawing.Point(256, 603);
            this.dime.Name = "dime";
            this.dime.Size = new System.Drawing.Size(75, 23);
            this.dime.TabIndex = 12;
            this.dime.Text = "Dime";
            this.dime.UseVisualStyleBackColor = true;
            this.dime.Click += new System.EventHandler(this.dime_Click);
            // 
            // nickel
            // 
            this.nickel.Location = new System.Drawing.Point(381, 603);
            this.nickel.Name = "nickel";
            this.nickel.Size = new System.Drawing.Size(75, 23);
            this.nickel.TabIndex = 13;
            this.nickel.Text = "Nickel";
            this.nickel.UseVisualStyleBackColor = true;
            this.nickel.Click += new System.EventHandler(this.nickel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.nickel);
            this.Controls.Add(this.dime);
            this.Controls.Add(this.quarter);
            this.Controls.Add(this.halfdollar);
            this.Controls.Add(this.ejectlemon);
            this.Controls.Add(this.ejectorange);
            this.Controls.Add(this.ejectcoke);
            this.Controls.Add(this.Coinreturn);
            this.Controls.Add(this.Lemon);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Coke);
            this.Controls.Add(this.total);
            this.Controls.Add(this.exactchange);
            this.Controls.Add(this.insertmoney);
            this.Name = "Form1";
            this.Text = "Welcome to the .NET Soda Machine! ";
            ((System.ComponentModel.ISupportInitialize)(this.Coke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

