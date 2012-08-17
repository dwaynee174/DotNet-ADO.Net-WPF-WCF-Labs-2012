using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoanManagement.Entity;

namespace LoanManagement.ConsoleUI
{
    public class CommonData
    {
        public static User[] users =  {
                                        new User
                                        { 
                                            FirstName = "Sarma",
                                            LastName = "Guda",
                                            UserName = "sarma",
                                            Password = "sarma",
                                            RoleId = (int)Role.Customer
                                        },
                                        new User
                                        { 
                                            FirstName = "Babar",
                                            LastName = "Shaik",
                                            UserName = "babar",
                                            Password = "babar",
                                            RoleId = (int)Role.Employee
                                        },
                                        new User
                                        { 
                                            FirstName = "Sreenivasrao",
                                            LastName = "CPCL",
                                            UserName = "sreenivas",
                                            Password = "sreenivas",
                                            RoleId = (int)Role.Manager
                                        }
                                    };

        /// <summary>
        /// Static Loans data
        /// </summary>
        public static Loan[] loans = { 
                                         new Loan
                                         { 
                                             Amount = 30.00,
                                             AssignedTo = new User(2),
                                             Category = LoanType.HomeLoan,
                                             Description = "First Loan Request",
                                             IsApproved = false,
                                             User = new User(1)
                                         },
                                         new Loan
                                         { 
                                             Amount = 100.00,
                                             AssignedTo = new User(2),
                                             Category = LoanType.HomeLoan,
                                             Description = "Second Loan Request",
                                             IsApproved = false,
                                             User = new User(1)
                                         },
                                         new Loan
                                         { 
                                             Amount = 150.00,
                                             AssignedTo = new User(2),
                                             Category = LoanType.HomeLoan,
                                             Description = "Third Loan Request",
                                             IsApproved = false,
                                             User = new User(1)
                                         }
                                    };

        public static FixupCollection approvalDetails = new FixupCollection 
                            { 
                                     new Approval{ 
         Id = 1,
         Approver = CommonData.users[0],
         Loan = CommonData.loans[0],
         Remarks = "done",
         DateApproved = System.DateTime.Now, 
         IsApproved = true, 
         CreateDate = System.DateTime.Now, 
         UpdateDate = System.DateTime.Now 
      },
      new Approval 
      { 
         Id = 2,
         Approver = CommonData.users[1],
         Loan = CommonData.loans[1],
         Remarks = "done dona done",
         DateApproved = System.DateTime.Now, 
         IsApproved = true,
         CreateDate = System.DateTime.Now, 
         UpdateDate = System.DateTime.Now 
      },
      new Approval
      { 
         Id = 3,
         Approver =CommonData.users[2] ,
         Loan = CommonData.loans[2],
         Remarks = "done",
         DateApproved = System.DateTime.Now, 
         IsApproved = false,
         CreateDate = System.DateTime.Now, 
         UpdateDate = System.DateTime.Now 
      }

                            
                            };
            
        

    }
}
