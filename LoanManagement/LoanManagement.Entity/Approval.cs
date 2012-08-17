//-----------------------------------------------------------------------
// <copyright file="Approval.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace LoanManagement.Entity
{
    /// <summary>
    /// Class to represent Loan approval
    /// </summary>
    [Serializable]
    public partial class Approval : EntityBase
    {
        #region Primitive Properties
        /// <summary>
        /// Gets or sets Loan object
        /// </summary>
        public Loan Loan
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets User as Approver
        /// </summary>
        public User Approver
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets the remarks for approval
        /// </summary>
        public string Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether loan is approved or not
        /// </summary>
        public bool IsApproved
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Approved date of Loan
        /// </summary>
        public DateTime DateApproved
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
