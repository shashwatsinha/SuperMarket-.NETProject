using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.OleDb;
using System.Web.UI.WebControls;

namespace SupermarketProject
{
    public partial class UpdatePrices : System.Web.UI.Page
    {
        string Value;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Value = TextBox3.Text;
            System.Data.OleDb.OleDbConnection conn1 = new
       System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= C:\Users\user\" +
                @"My Documents\Inventory.mdb";
         
            string queryString1 = "SELECT * From Inv where product_name = '" +Value+"'"  ;
            OleDbCommand command = new OleDbCommand(queryString1, conn1);


            command.Parameters.AddWithValue("@product_id", OleDbType.VarChar).Value = Value;
            conn1.Open();

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TextBox1.Text = reader["product_cost"].ToString();
                TextBox2.Text = reader["product_stock"].ToString();
            }
            reader.Close();
            conn1.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbConnection conn1 = new
       System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= C:\Users\user\" +
                @"My Documents\Inventory.mdb";

            string queryString1 = "UPDATE Inv Set product_cost = '" + TextBox1.Text+ "', product_stock = '" +TextBox2.Text+"' WHERE product_name = '"+TextBox3.Text+"'" ;
            OleDbCommand command = new OleDbCommand(queryString1, conn1);
            conn1.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Close(); conn1.Close();



        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Webform1.aspx");
        }
    }
}