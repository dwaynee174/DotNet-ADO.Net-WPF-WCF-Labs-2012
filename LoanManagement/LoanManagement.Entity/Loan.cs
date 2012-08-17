//-----------------------------------------------------------------------
// <copyright file="Loan.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace LoanManagement.Entity
{
    /// <summary>
    /// Class to represent a Loan 
    /// </summary>
    [Serializable]
    public partial class Loan: EntityBase 
    {
        #region Constructor(s)
        /// <summary>
        /// Initializes a new instance of the Loan class
        /// </summary>
        public Loan() 
        { 
        }

        //public int Id
        //{
        //    get;
        //    set;
        //}
        /// <summary>
        /// Initializes a new instance of the Loan class with given loan id
        /// </summary>
        /// <param name="id">Loan id to create a Loan object</param>
        public Loan(int id) 
        { 
            this.Id = id; 
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// Gets or sets Loan category
        /// </summary>
        public LoanType Category
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets loan amount
        /// </summary>
        public double Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the User
        /// </summary>
        public User User
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Loan assigned User of role Employee
        /// </summary>
        public User AssignedTo
        {
            get;
            set;
        }
    
        /// <summary>
        /// Gets or sets Loan description
        /// </summary>
        public string Description
        {
            get;
            set;
        }
    
        /// <summary>
        /// Gets or sets a value indicating whether Loan is approved or not
        /// </summary>
        public bool IsApproved
        {
            get;
            set;
        }
        public override int GetId()
        {
            return this.Id;
        }

        #endregion
    }
}
