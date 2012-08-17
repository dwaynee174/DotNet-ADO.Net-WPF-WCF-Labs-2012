//-----------------------------------------------------------------------
// <copyright file="User.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace LoanManagement.Entity
{
    /// <summary>
    /// Class to represent a User
    /// </summary>
    [Serializable]
    public partial class User: EntityBase 
    {
        #region constructor(s)
        /// <summary>
        /// Initializes a new instance of the User class
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Initializes a new instance of the User class with given id
        /// </summary>
        /// <param name="id">id of the User</param>
        public User(int id)
        {
            this.Id = id;
        }

        #endregion
        #region Primitive Properties

        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets LastName
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets UserName
        /// </summary>
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Role id of User
        /// </summary>
        public int RoleId
        {
            get;
            set;
        }
        public override int GetId()
        {
            return Id;
        }

        public string Name
        {
            get
            {
                return ("firstname="+FirstName+"Lastname=" + LastName);

            }
        }
        
        #endregion
        
    }
}
