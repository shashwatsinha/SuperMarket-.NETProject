using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;

namespace SupermarketProject
{
    public partial class Billing : System.Web.UI.Page
    {
        private static string connectionString;
        
        DataTable dt = new DataTable();
        static int i = 0;
        static int custNo = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                i = 0;
                // custNo++;
                dt.Columns.Add("Item Number");
                dt.Columns.Add("Product Id");
                dt.Columns.Add("Quantity");
                ViewState["dt"] = dt;
                GridView1.DataSource = dt;
                GridView1.DataBind();

                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                  @"Data source= C:\Users\user\" +
                  @"My Documents\Inventory.mdb";


                string counter;
                counter = "SELECT * FROM [Counter] Where ID = 1";
                OleDbCommand command = new OleDbCommand(counter, conn);
                conn.Open();
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                custNo = Convert.ToInt32(reader["CustNumber"]);
                reader.Close();
                conn.Close();



                string insertSQL;
                insertSQL = "CREATE TABLE custNumber" + custNo + "(ItemNumber int,ProductName varchar(20),UnitCost int,Quantity int, TotalCost int,Profit int)";
                OleDbCommand command1 = new OleDbCommand(insertSQL, conn);
                conn.Open();
                OleDbDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                conn.Close();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            i++;
            string Name;
            string cost;
            string margin;
            DataTable dt = ViewState["dt"] as DataTable;
            DataRow dr = dt.NewRow();
            dr["Item Number"] = i;
            dr["Product ID"] = TextBox1.Text;
            dr["Quantity"] = TextBox2.Text;
            dt.Rows.Add(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
              @"Data source= C:\Users\user\" +
              @"My Documents\Inventory.mdb";

            string querySQL = "SELECT product_name,product_cost,Margin from Inv Where product_id ='" + TextBox1.Text + "'";
            OleDbCommand command = new OleDbCommand(querySQL, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();

            Name = reader["product_name"].ToString();
            cost = reader["product_cost"].ToString();
            margin = reader["Margin"].ToString();

            reader.Close();
            conn.Close();


            string insertSQL;
            insertSQL = "INSERT INTO custNumber" + custNo + "(ItemNumber,ProductName,UnitCost,Quantity,TotalCost,Profit)";
            insertSQL += "VALUES(@ItemNumber,@ProductName,@UnitCost,@Quantity,@TotalCost,@Profit)";


            OleDbCommand command1 = new OleDbCommand(insertSQL, conn);


            conn.Open();
            command1.Parameters.AddWithValue("@ItemNumber", OleDbType.VarChar).Value = i;
            command1.Parameters.AddWithValue("@ProductName", OleDbType.VarChar).Value = Name;
            command1.Parameters.AddWithValue("@UnitCost", OleDbType.VarChar).Value = cost;
            command1.Parameters.AddWithValue("@Quantity", OleDbType.VarChar).Value = TextBox2.Text;
            command1.Parameters.AddWithValue("@TotalCost", OleDbType.VarChar).Value = Convert.ToInt32(cost) * Convert.ToInt32(TextBox2.Text);
            command1.Parameters.AddWithValue("@Profit", OleDbType.VarChar).Value = Convert.ToInt32(TextBox2.Text) * Convert.ToInt32(margin);

            command1.ExecuteNonQuery();
            conn.Close();

            string updateSQL;
            updateSQL = "UPDATE Inv Set product_stock = product_stock -'" + TextBox2.Text + "' WHERE product_id = '" + TextBox1.Text + "'";
            OleDbCommand command2 = new OleDbCommand(updateSQL, conn);
            conn.Open();
            OleDbDataReader reader1 = command2.ExecuteReader();
            reader1.Close(); conn.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            System.Data.OleDb.OleDbConnection conn1 = new System.Data.OleDb.OleDbConnection();
            conn1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
              @"Data source= C:\Users\user\" +
              @"My Documents\Inventory.mdb";

            string queryString1 = "UPDATE [Counter] Set CustNumber = CustNumber + '" + 1 + "' Where ID = 1";
            OleDbCommand command = new OleDbCommand(queryString1, conn1);
            conn1.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Close(); conn1.Close();
            Response.Redirect("CustomerBill.aspx?cNo=" + custNo);
        }

    }
}