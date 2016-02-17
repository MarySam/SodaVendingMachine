using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Land
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newChild = new Form3();
            //The parent is form 2.  
            newChild.MdiParent = this;
            newChild.Text = ("New Note");
            newChild.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newNote = new Form3();
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                newNote.NotepadText = sr.ReadToEnd();
                newNote.Show();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        //If a note isnt open, make sure to disable this.
        {
            if (ActiveMdiChild != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter saveFile = new StreamWriter(sfd.FileName))
                    {
                        Form3 notepadChild = (Form3)ActiveMdiChild;

                        //Write the data to the file
                        saveFile.WriteLine(notepadChild.NotepadText);
                    }
                }
                sfd.InitialDirectory = Application.StartupPath;
                MessageBox.Show(sfd.FileName);
            }
            else
            {
                MessageBox.Show("There is nothing to save");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //To close the notepad.
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature does not work");
        }
    }
}

