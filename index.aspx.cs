using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{    
    //Established Database Connection
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
      Photos();
    }

  //  Function For Fetch Images From DataBase
    protected void Photos()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql_query = "select * from gallery";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                string col = "<div class='row'>";
                for (int i = 0; i < dt.Rows.Count; i++)
                    col+="<div class='col-md-2 pb-4'> <div class='shadow'><a href='"+ dt.Rows[i]["image"].ToString() + "' data-lightbox='example-set' ><img style='height: 130px;'  class='img-fluid thumbnail' src='"+ dt.Rows[i]["image"].ToString() + "'></a></div> </div>";
                col += "</div>";
                photos.InnerHtml = col;

            }
            else
                photos.InnerHtml = "Server Down Try Again..";

        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }
   
}