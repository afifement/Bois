using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bois.DAL
{

   public interface ICrud<T> where T:class
    {
       IEnumerable<T> GetAll();

       bool AddNew(params T[] items);
         
       bool Delete(params T[] items);

       bool Update(params T[] items);

       bool Archive(params T[] items);

    }
}
