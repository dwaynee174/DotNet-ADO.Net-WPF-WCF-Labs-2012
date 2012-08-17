﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeDB")]
public partial class EmployeeDBDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertEmployee(Employee instance);
  partial void UpdateEmployee(Employee instance);
  partial void DeleteEmployee(Employee instance);
  #endregion
	
	public EmployeeDBDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeDBDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeDBDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EmployeeDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Employee> Employees
	{
		get
		{
			return this.GetTable<Employee>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _empno;
	
	private string _ename;
	
	private System.Nullable<int> _salary;
	
	private System.Nullable<int> _deptno;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnempnoChanging(int value);
    partial void OnempnoChanged();
    partial void OnenameChanging(string value);
    partial void OnenameChanged();
    partial void OnsalaryChanging(System.Nullable<int> value);
    partial void OnsalaryChanged();
    partial void OndeptnoChanging(System.Nullable<int> value);
    partial void OndeptnoChanged();
    #endregion
	
	public Employee()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empno", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int empno
	{
		get
		{
			return this._empno;
		}
		set
		{
			if ((this._empno != value))
			{
				this.OnempnoChanging(value);
				this.SendPropertyChanging();
				this._empno = value;
				this.SendPropertyChanged("empno");
				this.OnempnoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ename", DbType="VarChar(10)")]
	public string ename
	{
		get
		{
			return this._ename;
		}
		set
		{
			if ((this._ename != value))
			{
				this.OnenameChanging(value);
				this.SendPropertyChanging();
				this._ename = value;
				this.SendPropertyChanged("ename");
				this.OnenameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Int")]
	public System.Nullable<int> salary
	{
		get
		{
			return this._salary;
		}
		set
		{
			if ((this._salary != value))
			{
				this.OnsalaryChanging(value);
				this.SendPropertyChanging();
				this._salary = value;
				this.SendPropertyChanged("salary");
				this.OnsalaryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptno", DbType="Int")]
	public System.Nullable<int> deptno
	{
		get
		{
			return this._deptno;
		}
		set
		{
			if ((this._deptno != value))
			{
				this.OndeptnoChanging(value);
				this.SendPropertyChanging();
				this._deptno = value;
				this.SendPropertyChanged("deptno");
				this.OndeptnoChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591