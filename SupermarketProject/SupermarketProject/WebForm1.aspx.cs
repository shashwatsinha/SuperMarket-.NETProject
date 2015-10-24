using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace SupermarketProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection connection;
        public SqlDataAdapter dataadapter;
        public DataSet dataset;
       
        protected void Page_Load(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbConnection conn = new
        System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= C:\Users\user\" +
                @"My Documents\Inventory.mdb";

            string queryString = "SELECT * From Inv";
            OleDbCommand command = new OleDbCommand(queryString, conn);
              

            conn.Open();

            OleDbDataReader reader = command.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
           
            reader.Close();
            conn.Close();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddInventory.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePrices.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Webform2.aspx");
        }
    }
}