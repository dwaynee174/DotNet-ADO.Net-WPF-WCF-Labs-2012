//---------------------------------------------------------------------------------------------
// <copyright file="LoanController.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------------------------
using System;
using LoanManagement.DAL;
using LoanManagement.Entity;

namespace LoanManagement.Controller
{
    /// <summary>
    /// Class to handle the Loan
    /// </summary>
    public class LoanController : IController<Loan>
    {
        #region Private Properties
        /// <summary>
        /// Local variable to hold the LoanManagement.Entity.Loan object
        /// </summary>
        private LoanDAL _loanDAL = null;
        #endregion
        #region Constructor(s)
        /// <summary>
        /// Initializes a new instance of the LoanController class
        /// </summary>
        public LoanController()
        {
            this._loanDAL = new LoanDAL();
        }
        #endregion
        #region Public Method(s)
        /// <summary>
        /// Method to create a Loan
        /// </summary>
        /// <param name="obj">Loan object to be created</param>
        /// <returns>Integer value with created Loan Id</returns>
        public int Create(Loan obj)
        {
            return this._loanDAL.Create(obj);
        }

        /// <summary>
        /// Method to get the loan object by loan id 
        /// </summary>
        /// <param name="id">LoanId to get the loan object</param>
        /// <returns>Loan object for given loan id</returns>
        public Loan GetObject(int id)
        {
            return this._loanDAL.GetObject(id);
        }

        /// <summary>
        /// Method to get the loan object by loan id 
        /// </summary>
        /// <param name="objName">string that contains the LoanId to get the loan object</param>
        /// <returns>Loan object for given loan id</returns>
        public Loan GetObject(string objName)
        {
            return this._loanDAL.GetObject(int.Parse(objName));
        }

        /// <summary>
        /// Method for updating the loan 
        /// </summary>
        /// <param name="obj">Loan object to be updated</param>
        /// <returns>true if on successfull update</returns>
        public bool Update(Loan obj)
        {
            return this._loanDAL.Update(obj);
        }

        /// <summary>
        /// Method to Delete the loan from the system
        /// </summary>
        /// <param name="obj">Loan object to be deleted</param>
        /// <returns>true on successfull delete</returns>
        public bool Delete(Loan obj)
        {
            return this._loanDAL.Delete(obj);
        }

        /// <summary>
        /// Method to get the loans collection object by employeeId
        /// </summary>
        /// <param name="employeeId">employeeId to get Loans Collection</param>
        /// <returns>Loans Collection object for given employeeId</returns>
        public FixupCollection<Loan> GetLoansByEmployeeId(int employeeId)
        {
            return this._loanDAL.GetObjectsByEmployeeId(employeeId);
        }
        #endregion
    }
}
