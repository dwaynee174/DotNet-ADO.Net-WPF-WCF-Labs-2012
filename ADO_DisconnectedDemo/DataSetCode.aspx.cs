using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration; //to access a web.config file

public partial class DataSetCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string conStr = WebConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da = new SqlDataAdapter("select * from employees", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "employees");
        dgemp.DataSource = ds.Tables["EMPLOYEES"];
        dgemp.DataBind();
       
    }
}