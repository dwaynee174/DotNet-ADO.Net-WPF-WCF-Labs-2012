//-----------------------------------------------------------------------
// <copyright file="UserDAL.cs" company="Accenture Services Private Limited">
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
    /// Class to handle database transactions for User Table.
    /// Database connection will be established in the constructor of the base class
    /// </summary>
    public class UserDAL : DALBase
    {
        #region Constructor(s)
        /// <summary>
        /// Initializes a new instance of the UserDAL class and triggers the base class constructor.
        /// </summary>
        public UserDAL()
            : base()
        {
        }
        #endregion
        #region Public Method(s)
        /// <summary>
        /// Method for create the user
        /// </summary>
        /// <param name="user">User objcet to be created</param>
        /// <returns>integer value with the created user id</returns>
        public int CreateUser(User user)
        {
            SqlTransaction trans = null;

            SqlParameter parFirstName = new SqlParameter("FirstName", user.FirstName);
            SqlParameter parLastName = new SqlParameter("LastName", user.LastName);
            SqlParameter parUserName = new SqlParameter("UserName", user.UserName);
            SqlParameter parPassword = new SqlParameter("Password", user.Password);
            SqlParameter parRoleId = new SqlParameter("RoleId", user.RoleId);
            SqlParameter parCreateDate = new SqlParameter("CreateDate", DateTime.Now);
            SqlParameter parUpdateDate = new SqlParameter("UpdateDate", DateTime.Now);
            try
            {
                Connection.Open();
                trans = Connection.BeginTransaction();
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_UserInsert", parFirstName, parLastName, 
                                          parUserName, parPassword, parRoleId, parCreateDate, parUpdateDate);
                trans.Commit();

                DataTable tblResult = SqlHelper.ExecuteDataset(Connection, "usp_SelectUserByUserName", parUserName).Tables[0];
                if (tblResult.Rows.Count > 0)
                {
                    user.Id = GetUserObj(tblResult.Rows[0]).Id;
                }

                Connection.Close();
                return user.Id;
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
        /// Method for Updating the user
        /// </summary>
        /// <param name="user"> User object with new values that gets updated</param>
        /// <returns>true if updated successfully, false if not updated.</returns>
        public bool UpdateUser(User user)
        {
            SqlTransaction trans = null;

            SqlParameter parUserId = new SqlParameter("UserId", user.Id);
            SqlParameter parFirstName = new SqlParameter("FirstName", user.FirstName);
            SqlParameter parLastName = new SqlParameter("LastName", user.LastName);
            SqlParameter parUserName = new SqlParameter("UserName", user.UserName);
            SqlParameter parPassword = new SqlParameter("Password", user.Password);
            SqlParameter parRoleId = new SqlParameter("RoleId", user.RoleId);

            try
            {
                Connection.Open();
                trans = Connection.BeginTransaction();
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_UserUpdate", parUserId, parFirstName, parLastName, parUserName, parPassword, parRoleId);

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
        /// Method for deleting the given user
        /// </summary>
        /// <param name="user">User object to be deleted</param>
        /// <returns>true if deleted successfully, flase if not get deleted </returns>
        public bool DeleteUser(User user)
        {
            SqlTransaction trans = null;
            SqlParameter parUserId = new SqlParameter("UserId", user.Id);
            try
            {
                Connection.Open();
                trans = Connection.BeginTransaction();
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_UserDelete", parUserId);
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
        /// Method to return the user object for given user id.
        /// </summary>
        /// <param name="userId">User Id to get the user object</param>
        /// <returns>User object with the given user id, null if the user with the id does not exist</returns>
        public User GetUser(int userId)
        {
            User user = null;
            SqlParameter parUserId = new SqlParameter("UserId", userId);
            try
            {

                Connection.Open();
                DataTable tblResult = SqlHelper.ExecuteDataset(base.Connection, "usp_SelectUserById", parUserId).Tables[0];
                Connection.Close();
                if (tblResult.Rows.Count > 0)
                {
                    user = GetUserObj(tblResult.Rows[0]);
                }

                return user;
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
        /// Method to return the user object for given UserName.
        /// </summary>
        /// <param name="userName">UserName to get the user object</param>
        /// <returns>User object with the given UserName, null if the user with the UserName does not exist</returns>
        public User GetUser(string userName)
        {
            User user = null;
            SqlParameter parUserName = new SqlParameter("UserName", userName);
            try
            {

                Connection.Open();
                DataTable tblResult = SqlHelper.ExecuteDataset(base.Connection, "usp_SelectUserByUserName", parUserName).Tables[0];
                Connection.Close();
                if (tblResult.Rows.Count > 0)
                {
                    user = GetUserObj(tblResult.Rows[0]);
                }

                return user;
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
        /// Method to get the User collection for give user roleId
        /// </summary>
        /// <param name="roleId">roldId to find the Users</param>
        /// <returns>Returns User collection object</returns>
        public FixupCollection<User> GetUsers(int roleId)
        {
            FixupCollection<User> objUserCollection = new FixupCollection<User>();
            SqlParameter parRoleId = new SqlParameter("RoleId", roleId);
            try
            {
                Connection.Open();
                DataTable tblResult = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, "dbo.usp_SelectUsersByRoleId", parRoleId).Tables[0];
                Connection.Close();
                foreach (DataRow objLoanRow in tblResult.Rows)
                {
                    objUserCollection.Add(GetUserObjForRole(objLoanRow));    
                }

                return objUserCollection;
            }
            catch (Exception ex)
            {
                objUserCollection.Clear();
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
        #endregion
        #region Private Method(s)
        /// <summary>
        /// Method to bind the data row to  an user object
        /// </summary>
        /// <param name="userRow">data row with user data</param>
        /// <returns>user object with given user data by data row</returns>
        private User GetUserObj(DataRow userRow)
        {
            User user = new User();

            user.Id = Convert.ToInt32(userRow["UserId"]);
            user.FirstName = userRow["FirstName"].ToString();
            user.LastName = userRow["LastName"].ToString();
            user.UserName = userRow["UserName"].ToString();
            user.Password = userRow["Password"].ToString();
            user.RoleId = Convert.ToInt32(userRow["RoleId"]);
            user.CreateDate = Convert.ToDateTime(userRow["CreateDate"]);
            user.UpdateDate = Convert.ToDateTime(userRow["UpdateDate"]);
            return user;
        }

        /// <summary>
        /// Method to bind the data row to  an user object
        /// </summary>
        /// <param name="userRow">data row with user data</param>
        /// <returns>user object with given user data by data row</returns>
        /// <returns></returns>
        private User GetUserObjForRole(DataRow userRow)
        {
            User user = new User
                        {
                            Id = Convert.ToInt32(userRow["UserId"]),
                            FirstName = userRow["FirstName"].ToString(),
                            LastName = userRow["LastName"].ToString()
                        };

            return user;
        }
        #endregion
    }
}