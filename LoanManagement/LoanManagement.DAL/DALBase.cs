//-----------------------------------------------------------------------
// <copyright file="DALBase.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LoanManagement.DAL
{
    /// <summary>
    /// Base class for Data Access Layer
    /// </summary>
    public class DALBase
    {
        /// <summary>
        /// Connection String
        /// </summary>
        private const string DbStringName = "Server=SERVER;Database=LoanManagement;Integrated Security=SSPI;";

        /// <summary>
        /// Sql Conection object 
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Gets Constructor for instantiating and opening the connection.
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection();
                    connection.ConnectionString = DbStringName;
                }

                return connection;
            }
        }

        /// <summary>
        /// Method to get the created object id for given tableName and ColumnName
        /// </summary>
        /// <param name="tableName">Name of the table to find the id</param>
        /// <param name="columnName">Name of the column in which need to find the id</param>
        /// <returns>Integer value representing object id if, object successfully found.</returns>
        public int GetCreatedObjectId(string tableName, string columnName)
        {
            int objectId = 0;
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }

                DataTable tblResult = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "Select MAX(" + columnName + ") as " + columnName + " from " + tableName).Tables[0];
                if (tblResult.Rows.Count > 0)
                {
                    objectId = Convert.ToInt32(tblResult.Rows[0][columnName]);
                }

                return objectId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
    }
}
