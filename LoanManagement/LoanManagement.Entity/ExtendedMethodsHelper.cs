//-----------------------------------------------------------------------
// <copyright file="ExtendedMethodsHelper.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace LoanManagement.Entity
{
    /// <summary>
    /// Class to handle the extended methods of LoanManagemetn.Entity
    /// </summary>
    /// <remarks>It covers about Optional parameters, Extension methods in 4.0</remarks>
    public static class ExtendedMethodsHelper
    {
        /// <summary>
        /// Extended method to display a loan object in string format
        /// </summary>
        /// <param name="User">user object to be formatted as string</param>
        /// <param name="referenceID">A reference id mapped for loan</param>
        /// <returns>Returns formatted string containing user information</returns>
        public static string Message(this User user, int referenceID = 0)
        {
            if (referenceID == 0)
            {
                return string.Format("User created successfully with User Name \"{0}\" and Id {1}", user.UserName, user.GetId());
            }
            else
            {
                return string.Format("User created successfully with User Name \"{0}\" and Id {1}.", user.UserName, user.Id);
            }
        }
    }
}