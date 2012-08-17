using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LinkToObjectDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        lstnames.Items.Clear();
        List<string> names = new List<string>();
        names.Add("karthik");
        names.Add("dhwani");
        names.Add("sahil");
        names.Add("paras");
        names.Add("suruchi");
        names.Add("nidhi");
        names.Add("priti");
        names.Add("eva");

        //write a linq query to fetch all the names from the list
        //return type of the linq query is of IEnumerable<> type

        #region reading each name & fetching them
        //IEnumerable<string> namequery= from n in names 
        //                               select n; 
        #endregion

        #region sorting
        //IEnumerable<string> namequery = from n in names
        //                                orderby n descending
        //                                select n; 
        #endregion

        #region filtering
        IEnumerable<string> namequery = from n in names
                                        where n.StartsWith("s")
                                        orderby n descending
                                        select n; 
        #endregion 
        
        lstnames.DataSource = namequery;
        lstnames.DataBind();
        //or
        //foreach (string s in namequery)
        //{
        //    lstnames.Items.Add(s);
        //}
    }
    protected void btnShowEmp_Click(object sender, EventArgs e)
    {
        lstnames.Items.Clear();
        List<Emp> empList = EmpDeptCollection.GetAllEmployees();

        //linq query to fetch all employee details from the list
        //it returns IEnumerable<Emp>

       // var empQuery = from emp in empList
         //              select emp;

        //var empQuery = from emp in empList
        //               where emp.DeptNo == 10
        //               orderby emp.EmpName ascending
        //               select emp;

        //var empQuery = from emp in empList
        //               where emp.EmpSalary > 15000
        //               orderby emp.EmpSalary ascending
        //               select emp;

        //var empQuery = from emp in empList
        //               where emp.EmpSalary>15000 && emp.DeptNo==30
        //               select emp;
        //foreach (Emp employee in empQuery)
        //{
        //    lstnames.Items.Add("Employee Number=" + employee.EmpNo);
        //    lstnames.Items.Add("Employee Name=" + employee.EmpName);
        //    lstnames.Items.Add("salary =" + employee.EmpSalary);
        //    lstnames.Items.Add("Department Number=" + employee.DeptNo);
        //    lstnames.Items.Add("---------------------------------------");

        //}

        //write a query to display empname Z& salary of all employees & display it in the grid
        var empQuery = from emp in empList
                       select new {
                           EmployeeName = emp.EmpName,
                           EmployeeSalary = emp.EmpSalary
                       };
        //or
        //var empQuery = from emp in empList
        //               select new
        //               { emp.EmpName,emp.EmpSalary
        //               };

        

        GridView1.DataSource = empQuery;
        GridView1.DataBind();
    }
    protected void btnEmpDept_Click(object sender, EventArgs e)
    {
        lstnames.Items.Clear();
        List<Emp> empList = EmpDeptCollection.GetAllEmployees();

        //query to group emp deptwise
        //var empQuery = from emp in empList
        //               group emp by emp.DeptNo;

        List<Dept> deptList=EmpDeptCollection.GetAllDept();

        var empQuery = from emp in empList
                       join dept in deptList
                           on emp.DeptNo equals dept.Deptno
                           group emp by dept.DeptName;

        //read each group & then display empname & salary
        //in the current group

        foreach (var empGroup in empQuery)
        { 
        //key is the value on which grouping was done
            //in this case it is deptno
            lstnames.Items.Add("Department = " + empGroup.Key);
            foreach (Emp employee in empGroup)
            {
                lstnames.Items.Add("---------------------------------------");
                lstnames.Items.Add("Employee Name=" + employee.EmpName);
                lstnames.Items.Add("salary =" + employee.EmpSalary);
            }
            lstnames.Items.Add("********************************************");
        }
    
    }
}