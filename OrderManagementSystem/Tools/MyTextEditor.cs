using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementSystem
{
    public partial class MyTextEditor : Form
    {
        public MyTextEditor()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }

        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
                this.Hide();
            else {
                if (MessageBox.Show("Do you want to Save ?", " Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    saveFileDialog1.Title = "Save text Files";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Java files (*.java)|*.txt|All files (*.*)|*.*";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        richTextBox1.Text = "";
                        this.Hide();
                    }
                    else
                    {
                        richTextBox1.Text = "";
                        this.Hide();
                    }
                }
                else {
                    richTextBox1.Text = "";
                    this.Hide();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Java files (*.java)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text =  File.ReadAllText(openFileDialog1.FileName);
            }
        }
    }
}
