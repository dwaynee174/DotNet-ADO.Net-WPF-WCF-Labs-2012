using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace LoanManagement.Entity
{
  public  class FixupCollection : System.Collections.CollectionBase
    {
      public void ClearItems()
      {
          List.Clear(); 
      }

    public  void Add(object item)
      {
          if (!this.List.Contains(item))
          {
              List.Add(item);
          }
      }



    }

    public class FixupCollection<T>:ObservableCollection<T>
    {
        protected override void ClearItems()
        {
            new List<T>(this).ForEach(t => Remove(t));
        }

        protected override void InsertItem(int index, T item)
        {
            if (!this.Contains(item))
            {
                base.InsertItem(index, item);
            }
        }


    }
}
