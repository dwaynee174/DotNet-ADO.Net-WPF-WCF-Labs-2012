//-----------------------------------------------------------------------
// <copyright file="IController.cs" company="Accenture Services Private Limited">
//     Copyright (c) MS .Net 4.0 Training Material. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace LoanManagement.Controller
{
    /// <summary>
    /// Generic Interface to handle Loanmanagement.Entity object creation, updatation, deletion and retrieval
    /// </summary>
    /// <typeparam name="T">T: The type of <see cref="Loanmanagement.Entity"/> object</typeparam>
    public interface IController<T>
    {
        /// <summary>
        /// Abstract to create any <see cref="LoanManagement.Entity"/>
        /// </summary>
        /// <param name="obj">obj to create <see cref="LoanManagement.Entity"/> object</param>
        /// <returns>Returns id of the current object</returns>
        int Create(T obj);

        /// <summary>
        /// Abstract  to get <see cref="LoanManagement.Entity"/> object
        /// </summary>
        /// <param name="id">An integer value to get the <see cref="LoanManagement.Entity"/> object</param>
        /// <returns>Returns <see cref="LoanManagement.Entity"/> object</returns>
        T GetObject(int id);
        
        /// <summary>
        /// Abstract to get <see cref="LoanManagement.Entity"/> object
        /// </summary>
        /// <param name="objName">An unique string to return <see cref="LoanManagement.Entity"/> object</param>
        /// <returns>Returns <see cref="LoanManagement.Entity"/> object</returns>
        T GetObject(string objName);
        
        /// <summary>
        /// Abstract to update the <see cref="LoanManagement.Entity"/> object
        /// </summary>
        /// <param name="obj"><see cref="LoanManagement.Entity"/> object to update</param>
        /// <returns>true if <see cref="LoanManagement.Entity"/> object is updated</returns>
        bool Update(T obj);
        
        /// <summary>
        /// Abstract to delete the <see cref="LoanManagement.Entity"/> object
        /// </summary>
        /// <param name="obj"><see cref="LoanManagement.Entity"/> object to delete</param>
        /// <returns>true if<see cref="LoanManagement.Entity"/> object is deleted</returns>
        bool Delete(T obj);
    }
}
