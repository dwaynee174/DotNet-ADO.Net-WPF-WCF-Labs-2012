using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoanManagement.Entity;
using System.Data;
using System.Data.SqlClient;

namespace LoanManagement.DAL
{
    class ApprovalDAL: DALBase,IDAL<Approval>
    {
        public ApprovalDAL()
            : base()
        { }

        public int Create(Approval obj)
        {   SqlTransaction trans = null;
            SqlParameter parLoanId = new SqlParameter("LoanId", obj.Loan.Id);
            SqlParameter parApproverId = new SqlParameter("ApproverId", obj.Approver.Id);
            SqlParameter parRemarks = new SqlParameter("Remarks", obj.Remarks);
            SqlParameter parIsApproved = new SqlParameter("IsApproved", obj.IsApproved);
            SqlParameter parDateApproved = new SqlParameter("DateApproved", obj.DateApproved);
            SqlParameter parDateCreated = new SqlParameter("DateCreated", obj.CreateDate);
            SqlParameter parDateUpdated = new SqlParameter("DateUpdated", obj.UpdateDate);

           
            try{
                Connection.Open();
                trans = Connection.BeginTransaction();
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_ApprovalInsert", parLoanId,parApproverId, parRemarks ,
                                           parIsApproved, parDateApproved, parDateCreated, parDateUpdated);
                trans.Commit();
                return GetCreatedObjectId("Approval", "ApprovalId");
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

        public Approval GetObject(int id)
        {
            Approval app = null;
            SqlParameter parApprovalId = new SqlParameter("ApprovalId", id);
            Connection.Open();
            DataTable tblResult = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, "usp_SelectLoanById", parApprovalId).Tables[0];
            Connection.Close();
            if (tblResult.Rows.Count > 0)
            {
                app = GetObjectFromDataRow(tblResult.Rows[0]);
            }

            return app;
        }

        public bool Update(Approval obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Approval obj)
        {
            throw new NotImplementedException();
        }
    }
}
