using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SupermarketProject
{
    public partial class AddInventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= C:\Users\user\" +
                @"My Documents\Inventory.mdb";


            int added = 0;
            string insertSQL;
            insertSQL = "INSERT INTO Inv(product_id,product_name,product_type,product_cost,product_stock)";
            insertSQL += "VALUES(@product_id,@product_name,@product_type,@product_cost,@product_stock)";
          

            OleDbCommand command = new OleDbCommand(insertSQL,conn); 
            
            
            conn.Open();
            command.Parameters.AddWithValue("@product_id", OleDbType.VarChar).Value = TextBox1.Text;
            command.Parameters.AddWithValue("@product_name", OleDbType.VarChar).Value = TextBox2.Text;
            command.Parameters.AddWithValue("@product_type", OleDbType.VarChar).Value = TextBox3.Text;
            command.Parameters.AddWithValue("@product_cost", OleDbType.VarChar).Value = TextBox4.Text;
            command.Parameters.AddWithValue("@product_stock", OleDbType.VarChar).Value = TextBox5.Text;

            added = command.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Webform1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Webform1.aspx");
        }
    }
}