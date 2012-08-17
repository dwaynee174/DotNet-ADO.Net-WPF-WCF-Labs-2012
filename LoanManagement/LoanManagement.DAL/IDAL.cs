using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanManagement.DAL
{
    public interface IDAL<T>
    {
        int Create(T obj);
        T GetObject(int id);
        bool Update(T obj);
        bool Delete(T obj);
    }

    class IDAL
    {

    }
}
