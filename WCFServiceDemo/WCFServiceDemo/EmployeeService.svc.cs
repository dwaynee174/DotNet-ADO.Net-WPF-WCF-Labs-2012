using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WCFServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class EmployeeService  : IEmpService
    {
        
        public Employee SearchEmpByID(int empno)
        {
            string conStr = "Data source=server;initial catalog=employeedb;integrated security=true";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ename,salary,deptno from employees where empno=" + empno;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Employee e = new Employee();
                e.EmpNo = empno;
                e.EmpName = dr["ename"].ToString();
                e.EmpSalary = Convert.ToInt32(dr["salary"]);
                e.DeptNo = Convert.ToInt32(dr["deptno"]);
                return e;
            }
            else
            {
                return null;
            }

        }
    }
}
