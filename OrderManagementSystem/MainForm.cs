using OrderManagementSystem.Tools;
using OrderManagementSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWatch sw = new StopWatch();
            sw.MdiParent = this;
            sw.Show();

                
        }

        private void myTextEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTextEditor mte = new MyTextEditor();
            //mte.MdiParent = this;
            mte.Show();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUsers adu = new AddUsers();
            adu.MdiParent = this;
            adu.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            mu.MdiParent = this;
            mu.Show();
        }

        private void dateAndIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateAndID dateAndID = new DateAndID();
            dateAndID.MdiParent = this;
            dateAndID.Show();
        }
    }
}
