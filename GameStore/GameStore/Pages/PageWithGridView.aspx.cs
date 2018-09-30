using GameStore.Models;
using GameStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameStore
{
    public partial class PageWithGridView : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["gridViewDBConnection"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT GameID, Name, Description, Category, Price FROM Games", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                grid.DataSource = reader;
                grid.DataBind();
                reader.Close();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}