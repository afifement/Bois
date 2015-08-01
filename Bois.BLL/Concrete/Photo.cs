using Bois.BLL.Abstract;
using Bois.DAL; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bois.BLL.Concrete
{
   public class Photo: IPhoto
    {
       static ICrud<ajt_photo> cruder;
       public byte[] GetCurrentPhoto(string identificateur)
        {
            if(cruder==null)cruder = new Crud<ajt_photo>();
           ajt_photo photo = cruder.GetAll().FirstOrDefault(x => x.id_user_fk == identificateur);
           return (photo == null)?null:photo.image;
        }


       public void UpdatePhoto(string id, byte[] image)
       {
           if (cruder == null) cruder = new Crud<ajt_photo>();
           List<ajt_photo> lstphoto = cruder.GetAll().ToList();
           ajt_photo photo = lstphoto.Where(x => x.id_user_fk == id).FirstOrDefault();
           if (photo != null) cruder.Delete(photo);
           ajt_photo pho = new ajt_photo() { id_user_fk = id, image = image };
           cruder.AddNew(pho); 
       }
    }
}
