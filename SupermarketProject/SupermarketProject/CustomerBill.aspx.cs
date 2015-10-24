using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.OleDb;
using System.Web.UI.WebControls;
using System.IO;

namespace SupermarketProject
{
    public partial class CustomerBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["cNo"];
            string profit, totalBill;
            Label1.Text = "Customer Number "+ID;
            Label2.Text = DateTime.Now.ToString();
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
              @"Data source= C:\Users\user\" +
              @"My Documents\Inventory.mdb";

            string querySQL = "SELECT ItemNumber,ProductName,UnitCost,Quantity,TotalCost from custNumber"+ID;
            OleDbCommand command = new OleDbCommand(querySQL, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
           
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Read();
            reader.Close();
            conn.Close();


            string querySQL1 = "Select SUM(TotalCost) AS TotalBill from custNumber"+ID;
            OleDbCommand command1 = new OleDbCommand(querySQL1, conn);
            conn.Open();
            OleDbDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
              //  profit = reader1["TotalProfit"].ToString();
             TextBox1.Text = Convert.ToString(reader1["TotalBill"]);
            }
            reader1.Close();
            conn.Close();

            //TextBox1.Text = totalBill.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalesMenu.aspx");
        }
    }
}