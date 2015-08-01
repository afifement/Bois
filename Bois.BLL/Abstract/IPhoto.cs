using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bois.BLL.Abstract
{
   public interface IPhoto
    {
        byte[] GetCurrentPhoto(string identificateur);
        void UpdatePhoto(string id, byte[] image);
    }
}
