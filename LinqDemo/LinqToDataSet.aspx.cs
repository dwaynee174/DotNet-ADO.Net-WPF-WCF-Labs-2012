using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class LinqToDataSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        DataSet empds = GetDataSet();
        var empQuery = from emp in empds.Tables["employees"].AsEnumerable() //AsEnumerable will return each row
                       orderby emp.Field<string>("ename")
                       //select emp;    //since emp returns datarow this stmt does not give valid output here
                       select new               //anonymous types
                       {                 
                           EmployeeName = emp.Field<string>("ename"),       
                           EmployeeSalary=emp.Field<int>("salary")

                       }; //since the query can return only one type
        //thats why we use anonymous type

        dgemp.DataSource = empQuery;
        dgemp.DataBind();
    }
    public DataSet GetDataSet()
    {
        string conStr = "Data Source=server;initial catalog=employeedb;integrated security=true";
        SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da = new SqlDataAdapter("select * from employees", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "employees");
        return ds;
    }
}