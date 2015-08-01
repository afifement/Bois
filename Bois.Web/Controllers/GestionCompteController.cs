using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bois.Web.Controllers
{
   
    public class GestionCompteController : Controller
    {

         [Authorize(Roles = "admin,manager,superadmin,employe")]
        public ActionResult FicheClient()
        {
            return View();
        }
         [Authorize(Roles = "admin,manager,superadmin")]
        public ActionResult Collaborateur()
        {
            return View();
        }

        
    }
}
