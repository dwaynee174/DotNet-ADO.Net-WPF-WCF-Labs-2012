using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LinqToSqlDemo : System.Web.UI.Page
{
    EmployeeDBDataContext empDBC = new EmployeeDBDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
      
        var empQuery=from emp in empDBC.Employees
                     orderby emp.ename ascending
                     select emp;
        GridView1.DataSource = empQuery;
        GridView1.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
       
        Employee emp = new Employee();
        emp.ename = txtename.Text;
        emp.salary = Convert.ToInt32(txtsal.Text);
        emp.deptno = Convert.ToInt32(txtdeptno.Text);

      
        empDBC.Employees.InsertOnSubmit(emp);
        empDBC.SubmitChanges();
        lblMessage.Text = "1 record inserted";
        ClearText();

    }

    public void ClearText()
    {
        txtdeptno.Text = "";
        txtempno.Text = "";
        txtename.Text = "";
        txtsal.Text = "";
    
    }
    public Employee FindEmployee(int empno)
    {
        
        var empQuery = from emp in empDBC.Employees
                       where emp.empno == empno
                       select emp;
        Employee en = empQuery.FirstOrDefault();
        return en;
    
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        int empno = Convert.ToInt32(txtempno.Text);
        Employee en = FindEmployee(empno);
        txtename.Text = en.ename;
        txtdeptno.Text = en.deptno.ToString();
        txtsal.Text = en.salary.ToString();
       

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
     int empno=Convert.ToInt32(txtempno.Text);
     Employee emp = FindEmployee(empno);
 
     empDBC.Employees.DeleteOnSubmit(emp);
     empDBC.SubmitChanges();
    lblMessage.Text = "1 record deleted";
     ClearText();

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int empno = Convert.ToInt32(txtempno.Text);
        Employee en = FindEmployee(empno);
        en.ename = txtename.Text;
        en.deptno = Convert.ToInt32(txtdeptno.Text);
        en.salary = Convert.ToInt32(txtsal.Text);
        empDBC.SubmitChanges();
        lblMessage.Text = "1 record updated";
        ClearText();
    }
}