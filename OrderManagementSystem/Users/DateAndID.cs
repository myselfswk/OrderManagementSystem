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
    public partial class DateAndID : Form
    {
        SqlConnection conn;
        public DateAndID()
        {
            InitializeComponent();
        }

        private void DateAndID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderManagementSystemDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.orderManagementSystemDataSet1.Product);
            // TODO: This line of code loads data into the 'orderManagementSystemDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.orderManagementSystemDataSet.Customer);

        }

        private void addNewOrder_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=OrderManagementSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("AddAssetOrder");

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("orderDate", dateTimePicker1.Value);
            sqlCommand.Parameters.AddWithValue("customerID", comboBox1.SelectedValue);
            sqlCommand.Parameters.Add("OrderId", SqlDbType.Int).Direction = ParameterDirection.Output;

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();

            int newId = (int)sqlCommand.Parameters["OrderId"].Value;

            SqlCommand sqlCommand1 = new SqlCommand("insert into [OrderDetails] values(" + newId + ", " + listBox1.SelectedValue + ", " + txtOrderQuantity.Text + ")", conn);

            conn.Open();
            sqlCommand1.ExecuteNonQuery();
            conn.Close();
        }
    }
}
