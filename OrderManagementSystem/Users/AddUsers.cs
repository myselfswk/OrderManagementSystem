using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderManagementSystem.Users
{
    public partial class AddUsers : Form
    {
        SqlConnection conn;
        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=OrderManagementSystem;Integrated Security=True");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "INSERT INTO [RegisterUser] (name, password, confirmpass, email) values (" + txtname.Text + "," + txtPassword.Text + "," + txtConfirmPass.Text + ", " + txtEmail.Text + ")";
                sqlCommand.Connection = conn;

                conn.Open();
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("User Enter Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRegViaStoreP_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=OrderManagementSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("AddAssetUser");

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("name", txtname.Text);
            sqlCommand.Parameters.AddWithValue("password", txtPassword.Text);
            sqlCommand.Parameters.AddWithValue("confirmpass", txtConfirmPass.Text);
            sqlCommand.Parameters.AddWithValue("email", txtEmail.Text);
            sqlCommand.Parameters.Add("userId", SqlDbType.Int).Direction = ParameterDirection.Output;

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();

            int newId = (int)sqlCommand.Parameters["userId"].Value;
        }
    }
}
