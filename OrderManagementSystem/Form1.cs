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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string userName = txtUserName.Text;

            string password = txtUserPassword.Text;

            if (txtUserName.Text == "")
                errorProvider1.SetError(txtUserName, "Name is Missing");
            else
            {
                if (txtUserPassword.Text == "")
                    errorProvider1.SetError(txtUserPassword, "Password is Missing");
                else
                {
                    if (userName == "IU" && password == "IU")
                    {
                        //MessageBox.Show("Valid User Name and Password");
                        MainForm mf = new MainForm();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("InValid User Name OR Password");
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserPassword.Text = txtUserName.Text = "";
        }
    }
}
