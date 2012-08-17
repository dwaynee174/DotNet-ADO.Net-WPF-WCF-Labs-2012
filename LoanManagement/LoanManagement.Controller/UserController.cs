//-----------------------------------------------------------------------
// <copyright file="UserController.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using LoanManagement.DAL;
using LoanManagement.Entity;

namespace LoanManagement.Controller
{
    /// <summary>
    /// Class to handle Users
    /// </summary>
    public class UserController : IController<User>
    {
        #region private Properties
        /// <summary>
        /// Local variable to hold LoanManagement.Entity.UserDAL object
        /// </summary>
        private UserDAL _userDAL = null;
        #endregion
        #region Constructor(s)
        /// <summary>
        /// Initializes a new instance of the UserController class
        /// </summary>
        public UserController()
        {
            this._userDAL = new UserDAL();
        }
        #endregion
        #region Public Method(s)
        /// <summary>
        /// Method to create LoanManagement.Entity.User
        /// </summary>
        /// <param name="obj">LoanManagement.Entity.User object to create</param>
        /// <returns>Integer value with created User id</returns>
        public int Create(User obj)
        {
            return this._userDAL.CreateUser(obj);
        }

        /// <summary>
        /// Method to Get LoanManagement.Entity.User object for given id
        /// </summary>
        /// <param name="id">objName to get LoanManagement.Entity.User object</param>
        /// <returns>Returns LoanManagement.Entity.User if, LoanManagement.Entity.User object is found for given id</returns>
        public User GetObject(int id)
        {
            return this._userDAL.GetUser(id);
        }

        /// <summary>
        /// Method to Get LoanManagement.Entity.User object for given objName
        /// </summary>
        /// <param name="objName">objName to get LoanManagement.Entity.User object</param>
        /// <returns>Returns LoanManagement.Entity.User if, LoanManagement.Entity.User object is found for given objName</returns>
        public User GetObject(string objName)
        {
            return this._userDAL.GetUser(objName);
        }

        /// <summary>
        /// Method to update LoanManagement.Entity.User object
        /// </summary>
        /// <param name="obj">LoanManagement.Entity.User object to update</param>
        /// <returns>tru if LoanManagement.Entity.User update is successfull</returns>
        public bool Update(User obj)
        {
            return this._userDAL.UpdateUser(obj);
        }

        /// <summary>
        /// Method to delete LoanManagement.Entity.User object
        /// </summary>
        /// <param name="obj">LoanManagement.Entity.User object to delete</param>
        /// <returns>true if LoanManagement.Entity.User delete is successfull</returns>
        public bool Delete(User obj)
        {
            return this._userDAL.DeleteUser(obj);
        }

        /// <summary>
        /// Method to get Collection of LoanManagement.Entity.User object
        /// </summary>
        /// <param name="roleId">Role id to get the Users</param>
        /// <returns>Returns Collection of LoanManagement.Entity.User object for given roleId</returns>
        public FixupCollection<User> GetObjects(int roleId)
        {
            return this._userDAL.GetUsers(roleId);
        }
        #endregion
    }
}
