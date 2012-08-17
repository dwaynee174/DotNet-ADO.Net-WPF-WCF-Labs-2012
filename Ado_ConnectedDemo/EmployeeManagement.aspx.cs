using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;   //root namespace for ADO.Net
using System.Data.SqlClient; //provider for SQLServer

public partial class EmployeeManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        SqlConnection con = null;
        string conStr = "Data Source=SERVER; Initial Catalog=EmployeeDB; Integrated Security=true";
   con=new SqlConnection(conStr);
   SqlCommand cmd = new SqlCommand();
        cmd.Connection=con; //Connection is the property of the cmd object
        cmd.CommandType = CommandType.Text;
        cmd.CommandText="select count(*) from Employees";

        con.Open();
        txttotal.Text = cmd.ExecuteScalar().ToString();
        con.Close();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=SERVER; Initial Catalog=EmployeeDB; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con; //Connection is the property of the cmd object
        cmd.CommandType = CommandType.Text;
        int re=Convert.ToInt32(txtempno.Text);
        cmd.CommandText = "select ename,salary,deptno from Employees where empno="+re;
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        
             if (dr.HasRows)
                {
                     dr.Read(); //to fetch the first record from the database
                     txtename.Text = dr["ename"].ToString();
                     txtsal.Text = dr["salary"].ToString();
                     txtdeptno.Text = dr["deptno"].ToString();
                     btnDelete.Visible = true;
                     btnUpdate.Visible = true; 
             }

            else
                {
                 lblresult.Text = "No employee found...";
                 txtename.Text = "";
                 txtsal.Text = "";
                 txtdeptno.Text = "";
                 btnDelete.Visible = false;
                 btnUpdate.Visible = false; 
                 }
        con.Close();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=SERVER; Initial Catalog=EmployeeDB; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con; //Connection is the property of the cmd object
        cmd.CommandType = CommandType.Text;
       
        string ename = txtename.Text;
        int salary = Convert.ToInt32(txtsal.Text);
        int deptno = Convert.ToInt32(txtdeptno.Text);
        cmd.CommandText = "insert into employees values('"+ename+"',"+salary+","+deptno+")";
        con.Open();
        cmd.ExecuteNonQuery();
        lblresult.Text = "1 record inserted";
        txtename.Text = "";
        txtsal.Text = "";
        txtdeptno.Text = "";
        con.Close();

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=SERVER; Initial Catalog=EmployeeDB; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con; //Connection is the property of the cmd object
        cmd.CommandType = CommandType.Text;
        string ename = txtename.Text;
        int empno = Convert.ToInt32(txtempno.Text);
        int salary = Convert.ToInt32(txtsal.Text);
        int deptno = Convert.ToInt32(txtdeptno.Text);
        cmd.CommandText = "update employees set ename='"+ename+"',salary="+salary+",deptno="+deptno+" where empno="+empno;
        con.Open();
        cmd.ExecuteNonQuery();
        lblresult.Text = "1 record updated";
        txtename.Text = "";
        txtsal.Text = "";
        txtdeptno.Text = "";
        con.Close();
           

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=SERVER; Initial Catalog=EmployeeDB; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con; //Connection is the property of the cmd object
        cmd.CommandType = CommandType.Text;
  
        int empno = Convert.ToInt32(txtempno.Text);
     
        cmd.CommandText = "delete from employees where empno=" + empno;
        con.Open();
        cmd.ExecuteNonQuery();
        lblresult.Text = "1 record deleted";
        txtename.Text = "";
        txtsal.Text = "";
        txtdeptno.Text = "";
        con.Close();
    }
}