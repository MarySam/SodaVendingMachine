using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Land
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string NotepadText
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void cycleThruToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
