using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Dept
/// </summary>
public class Dept
{
    public int Deptno { get; set; }
    public string DeptName { get; set; }
}

public class Emp
{
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public int DeptNo { get; set; }
    public int EmpSalary { get; set; }
}

public class EmpDeptCollection
{
    public static List<Emp> GetAllEmployees()
    {
        List<Emp> empList = new List<Emp>
        {
        new Emp{EmpNo=1,EmpName="Ruchi",EmpSalary=95000,DeptNo=10},
        new Emp{EmpNo=2,EmpName="Deep",EmpSalary=25000,DeptNo=20},
        new Emp{EmpNo=3,EmpName="Bharat",EmpSalary=35000,DeptNo=10},
        new Emp{EmpNo=4,EmpName="Banshri",EmpSalary=15000,DeptNo=20},
        new Emp{EmpNo=5,EmpName="Mukta",EmpSalary=45000,DeptNo=30},
        new Emp{EmpNo=6,EmpName="Amala",EmpSalary=55000,DeptNo=40},
        new Emp{EmpNo=7,EmpName="Rochelle",EmpSalary=45000,DeptNo=30},
        new Emp{EmpNo=8,EmpName="Zeba",EmpSalary=45000,DeptNo=40},
        new Emp{EmpNo=9,EmpName="Sara",EmpSalary=35000,DeptNo=10},
        new Emp{EmpNo=10,EmpName="Sakshi",EmpSalary=15000,DeptNo=20}
        };
        return empList;
    }

    public static List<Dept> GetAllDept()
    {
        List<Dept> deptList = new List<Dept> 
        { 
        new Dept{Deptno=10,DeptName="Accounts"},
        new Dept{Deptno=20,DeptName="HR"},
        new Dept{Deptno=30,DeptName="Sales"},
        new Dept{Deptno=40,DeptName="Admin"}
        };
        return deptList;
    }
}