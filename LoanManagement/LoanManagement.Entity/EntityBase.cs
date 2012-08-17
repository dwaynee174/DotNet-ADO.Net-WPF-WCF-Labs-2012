using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LoanManagement.Entity
{
    public abstract class EntityBase
    {
      virtual public int Id
       {
       get;  
       set;
       }
       virtual public DateTime? CreateDate
       {
           get;
           set;
       }
       
       virtual public Nullable <DateTime> UpdateDate
        {
            get;
            set;
        }
       public abstract int GetId();
    
    }
}
