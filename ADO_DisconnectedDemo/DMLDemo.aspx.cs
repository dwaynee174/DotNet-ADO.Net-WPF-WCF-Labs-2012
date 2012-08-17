using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class DMLDemo : System.Web.UI.Page
{
    SqlConnection con = null;
    SqlDataAdapter da = null;
    DataSet ds = null;
    string conStr = null;
    SqlCommandBuilder sb= null; //to auto-generate insert/update/delete command

    protected void Page_Load(object sender, EventArgs e)
    {
        conStr = WebConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

    }
    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        con = new SqlConnection(conStr);
        da = new SqlDataAdapter("select * from employees", con);
        ds = new DataSet();
        da.Fill(ds, "employees");

        int rowIndex = Convert.ToInt32(txtRowId.Text);

        //retrieve the row for the given rowindex from the DataRow collection 
        //of the DataTable in the DataSet

        DataRow selRow = ds.Tables["employees"].Rows[rowIndex];

        //read each field of the selRow & display in the textboxes
        txtempno.Text = selRow["empno"].ToString();
        txtename.Text = selRow["ename"].ToString();
        txtsal.Text = selRow["salary"].ToString();
        txtdeptno.Text = selRow["deptno"].ToString();


    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtempno.Text ="";
        txtename.Text ="";
        txtsal.Text = "";
        txtdeptno.Text = "";
        txtRowId.Text = "";

        btnInsert.Enabled = true;
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        con = new SqlConnection(conStr);
        da = new SqlDataAdapter("select * from employees", con);
        sb=new SqlCommandBuilder(da);
        ds = new DataSet();
        da.Fill(ds, "employees");
        //using disconnected architecture, add a new row to the dataSet
        //create a DataRow object which will contain
        //the schema of new row of the employees table which is in the DataSet
        DataRow newEmpRow = ds.Tables["employees"].NewRow();
    
      newEmpRow["ename"]= txtename.Text;
      newEmpRow["salary"] = txtsal.Text;
      newEmpRow["deptno"] = txtdeptno.Text;

        //add the above created row to existing DataRow collection
        //of the employees table which is in the DataSet
      ds.Tables["employees"].Rows.Add(newEmpRow);
      btnInsert.Enabled = false;
      Response.Write("1 record Inserted....");
      da.Update(ds, "employees");
      FillGrid();
    }

    public void FillGrid()
    {
        con = new SqlConnection(conStr);
        da = new SqlDataAdapter("select * from employees", con);
        ds = new DataSet();
        da.Fill(ds, "employees");

        dgemp.DataSource = ds.Tables["employees"];
        dgemp.DataBind();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        FillGrid();
    }
}