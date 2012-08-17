using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ShowEmployees : System.Web.UI.Page
{
    SqlConnection con = null;
    SqlCommand cmd = null;
    SqlDataReader dr = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string conStr = "Data Source=SERVER;Initial Catalog=EmployeeDB;Integrated Security=true";
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("select dname from department", con);
            con.Open();
            dr = cmd.ExecuteReader();
            //to fetch the deptname from the database
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ddlDept.Items.Add(dr["dname"].ToString());
                }
            }
            con.Close();
        }
    }
    protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstename.Items.Clear();
        string conStr = "Data Source=SERVER; Initial Catalog=EmployeeDB; Integrated Security=true";
        con = new SqlConnection(conStr);
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "EmpDeptProc";
        SqlParameter p = new SqlParameter();
        p.ParameterName = "@dname";
        p.SqlDbType = SqlDbType.VarChar;
        p.Size = 10;
        p.Value = ddlDept.Text; //assign the value to the parameter
        //add the above parameter to the command object
        cmd.Parameters.Add(p);

        //or
        //cmd.Parameters.Add("@dname", SqlDbType.VarChar, 10).Value = ddlDept.Text;
        con.Open();
        dr = cmd.ExecuteReader();
        
            while(dr.Read())
            {
                lstename.Items.Add(dr["ename"].ToString());
            
        
        }
       
        con.Close();

    }
}