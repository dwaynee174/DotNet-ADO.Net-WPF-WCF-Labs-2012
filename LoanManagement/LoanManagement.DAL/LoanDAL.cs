//-----------------------------------------------------------------------
// <copyright file="LoanDAL.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using LoanManagement.Entity;

namespace LoanManagement.DAL
{
    /// <summary>
    /// Class to handle database transactions for loan Table.
    /// Database connection will be established in the constructor of the base class
    /// </summary>
    public class LoanDAL : DALBase, IDAL<Loan>
    {
        #region Constructor(s)
        /// <summary>
        /// Initializes a new instance of the LoanDAL class and triiggers the base class constructor.
        /// </summary>
        public LoanDAL()
            : base()
        {        
        }
        #endregion
        #region public method(s)
        /// <summary>
        /// Method to create the Loan
        /// </summary>
        /// <param name="obj">Loan object to be created</param>
        /// <returns>integer value with created LoanId</returns>
        public int Create(Loan obj)
        {
            SqlTransaction trans = null;
            SqlParameter parCategoryId = new SqlParameter("CategoryId", (int)obj.Category);
            SqlParameter parAmount = new SqlParameter("Amount", obj.Amount);
            SqlParameter parUserId = new SqlParameter("UserId", obj.User.Id);
            SqlParameter parAssignedTo = new SqlParameter("AssignedTo", obj.AssignedTo.Id);
            SqlParameter parDescription = new SqlParameter("Description", obj.Description);
            SqlParameter parIsApproved = new SqlParameter("IsApproved", obj.IsApproved);
            try
            {
                Connection.Open();
                trans = Connection.BeginTransaction();
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_LoanInsert", parCategoryId, parAmount, parUserId,
                                          parAssignedTo, parDescription, parIsApproved);
                trans.Commit();
                return GetCreatedObjectId("Loan", "LoanId");
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

        /// <summary>
        /// Method to get the loan object by loan id 
        /// </summary>
        /// <param name="id">LoanId to get the loan object</param>
        /// <returns>Loan object for given loan id</returns>
        public Loan GetObject(int id)
        {
            Loan loan = null;
            SqlParameter parLoanId = new SqlParameter("LoanId", id);
            Connection.Open();
            DataTable tblResult = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, "usp_SelectLoanById", parLoanId).Tables[0];
            Connection.Close();
            if (tblResult.Rows.Count > 0)
            {
                loan = GetObjectFromDataRow(tblResult.Rows[0]);
            }

            return loan;
        }

        /// <summary>
        /// Method for updating the loan 
        /// </summary>
        /// <param name="obj">Loan object to be updated</param>
        /// <returns>true if on successfull update</returns>
        public bool Update(Loan obj)
        {
            SqlTransaction trans = null;
            SqlParameter parLoanId = new SqlParameter("LoanId", obj.Id);
            SqlParameter parCategoryId = new SqlParameter("CategoryId", (int)obj.Category);
            SqlParameter parAmount = new SqlParameter("Amount", obj.Amount);
            SqlParameter parUserId = new SqlParameter("UserId", obj.User.Id);
            SqlParameter parAssignedTo = new SqlParameter("AssignedTo", obj.AssignedTo.Id);
            SqlParameter parDescription = new SqlParameter("Description", obj.Description);
            SqlParameter parIsApproved = new SqlParameter("IsApproved", obj.IsApproved);
            try
            {
                Connection.Open();
                trans = Connection.BeginTransaction();
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_LoanUpdate", parLoanId, parCategoryId, parAmount, parUserId,
                                          parAssignedTo, parDescription, parIsApproved);
                trans.Commit();
                return true;
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

        /// <summary>
        /// Method to Delete the loan from the system
        /// </summary>
        /// <param name="obj">Loan object to be deleted</param>
        /// <returns>true on successfull delete</returns>
        public bool Delete(Loan obj)
        {
            SqlTransaction trans = null;
            SqlParameter parLoanId = new SqlParameter("LoanId", obj.Id);
            try
            {
                Connection.Open();
                trans = Connection.BeginTransaction();
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_LoanDelete", parLoanId);
                trans.Commit();
                Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
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

        /// <summary>
        /// Method to get the loans collection object by AssignedEmployeeId
        /// </summary>
        /// <param name="assignedEmployeeId">assignedEmployeeId to get Loans Collection</param>
        /// <returns>Loans Collection object for given AssignedEmployeeId</returns>
        public FixupCollection<Loan> GetObjectsByEmployeeId(int assignedEmployeeId)
        {
            FixupCollection<Loan> objLoanCollection = new FixupCollection<Loan>();
            SqlParameter parEmployeeId = new SqlParameter("AssignedTo", assignedEmployeeId);
            Connection.Open();
            DataTable tblResult = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, "dbo.usp_SelectLoansAssigned", parEmployeeId).Tables[0];
            Connection.Close();
            foreach (DataRow objLoanRow in tblResult.Rows)
            {
                objLoanCollection.Add(GetObjectFromDataRow(objLoanRow));
            }

            return objLoanCollection;
        }

        #endregion
        #region Private Method(s)
        /// <summary>
        /// Method to build the loan object from given data row
        /// </summary>
        /// <param name="resultRow">Data Row object with Loan record</param>
        /// <returns>Loan object generated from the given data row</returns>
        private Loan GetObjectFromDataRow(DataRow resultRow)
        {
            Loan loan = new Loan();
            loan.Id = Convert.ToInt32(resultRow["LoanId"]);
            loan.Amount = Convert.ToInt32(resultRow["Amount"]);
            loan.AssignedTo = new UserDAL().GetUser(Convert.ToInt32(resultRow["AssignedTo"]));
            loan.Category = (LoanType) Enum.Parse(typeof(LoanType), resultRow["CategoryId"].ToString());
            loan.Description = Convert.ToString(resultRow["Description"]);
            loan.IsApproved = Convert.ToBoolean(resultRow["IsApproved"]);
            loan.User = new UserDAL().GetUser(Convert.ToInt32(resultRow["UserId"]));
            loan.CreateDate = Convert.ToDateTime(resultRow["CreateDate"]);
            loan.UpdateDate = Convert.ToDateTime(resultRow["UpdateDate"]);
            return loan;
        }

        #endregion
    }
}
