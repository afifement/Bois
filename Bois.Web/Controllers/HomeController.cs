using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Bois.BLL.Abstract;
using Bois.BLL.Concrete;

namespace Bois.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        IPhoto photo;
        public ActionResult Index()
        {
            string identificateur = User.Identity.GetUserId();
            photo = new Photo();
            Session["image"] = photo.GetCurrentPhoto(identificateur);
            return View();
        }



        public FileContentResult getImg(int newWidth, int newHeight)
        {
            string identificateur = User.Identity.GetUserId();
            photo = new Photo();
            byte[] byteArray = photo.GetCurrentPhoto(identificateur); 
            return byteArray != null
                ? new FileContentResult(ResizeImage(byteArray, newWidth, newHeight), "image/jpeg")
                : null;
        }

        public byte[] ResizeImage(byte[] myBytes, int newWidth, int newHeight)
        {
            System.IO.MemoryStream myMemStream = new System.IO.MemoryStream(myBytes);
            System.Drawing.Image fullsizeImage = System.Drawing.Image.FromStream(myMemStream);
            System.Drawing.Image newImage = fullsizeImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            System.IO.MemoryStream myResult = new System.IO.MemoryStream();
            newImage.Save(myResult, System.Drawing.Imaging.ImageFormat.Jpeg);  //Or whatever format you want.
            return myResult.ToArray();
        }
    }
}
