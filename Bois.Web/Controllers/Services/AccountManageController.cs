  
using AutoMapper;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;  
using Microsoft.Owin.Security;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.WebPages.Html;
using System.Threading.Tasks;
using System.Diagnostics;
using Web;
using Bois.Web.Models;
using Bois.DAL; 
using Bois.BLL.Abstract;
using Bois.BLL.Concrete;
 

namespace Bois.Web.Controllers 
{
    public class AccountManageController : ApiController
    {
        IAccount repo = new Account();
        private ApplicationUserManager _userManager;

        public AccountManageController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public AccountManageController()
        {

        }

        

      

        [HttpGet]
        public IEnumerable<CollaborateurModel> GetAllCollaborators()
        {
            IEnumerable<ajt_collaborator> ajt_col =  repo.GetAllCollaborators().Where(x=>!x.deletion_date.HasValue);
        
            if (User.IsInRole("admin") )
            {
                ajt_col = repo.GetCollaboratorsForAdmins(ajt_col);
            }
            List<CollaborateurModel> model = new List<CollaborateurModel>();

            List<ajt_collaborator> lstCol = ajt_col.ToList();

            foreach (ajt_collaborator item in lstCol)
            {
                try
                {
                    CollaborateurModel temp = Mapper.Map<ajt_collaborator, CollaborateurModel>(item);
                    model.Add(temp);
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.InnerException.ToString());
                }
               
            }
                  
             foreach (CollaborateurModel item in model)
             {
                 ajt_collaborator temp_coll = Mapper.Map<CollaborateurModel, ajt_collaborator>(item);
                 item.Role = repo.GetRoleFromCollaborator(temp_coll);
             }
             return model;
        }

        [HttpGet]
        public IEnumerable<CollaborateurModel> GetAllChauffeurs()
        {
            return GetAllCollaborators().Where(x => x.Role.ToLower().Contains("chauffeur") && x.is_deleted == false);
        }

        


        [ HttpGet]
        public CollaborateurModel GetCollaborator(int id )
        {
            ajt_collaborator entity = repo.GetCollaboratorById(id);
            string id_user_fk = entity.id_user_fk;
            CollaborateurModel item = Mapper.Map<ajt_collaborator, CollaborateurModel>(entity);
            ajt_collaborator temp_coll = Mapper.Map<CollaborateurModel, ajt_collaborator>(item);
            item.Role = repo.GetRoleFromCollaborator(temp_coll);
            item.id_user_fk = id_user_fk;
            return item;
        }

        [HttpPost]
        public bool ValidateCollaborateur(CollaborateurModel item)
        {
            if (item.Username == null || item.Email == null) return false;
            if (UserManager.FindByEmail(item.Email) != null) return false;
            if (item.Password.Any(".,;_-+/!@#$%^&*".Contains) && item.Password.Any(char.IsDigit) && item.Password.Any(char.IsLower) && item.Password.Any(char.IsUpper))
            {
                return ModelState.IsValid;
            }
            else { 
                return false;
            }
         
        }

        [HttpPost]
        public bool ValidateCollaborateurEdition(CollaborateurModel item)
        {
            bool result = (item.Nom == null) || (item.Prenom == null) || (item.address == null);
            return !result;
        }

        [HttpPost]
        public  void CreateAccount(CollaborateurModel item)
        {
            var user = new ApplicationUser { UserName = item.Email, Email = item.Email };
            var result= UserManager.Create(user, item.Password);

            var currentUser = UserManager.FindByName(item.Email);
                var roleresult = UserManager.AddToRole(currentUser.Id, item.Role);
                ajt_collaborator entity = Mapper.Map<CollaborateurModel, ajt_collaborator>(item);
                entity.id_user_fk = currentUser.Id;
                entity.deletion_date = null;
             
                repo.CreateCollaborator(entity);
          
             
        }

        [HttpPut]
        public void UpdateAccount(CollaborateurModel item)
        {
             
                ApplicationUser user = UserManager.FindByIdAsync(item.id_user_fk).Result;
                user.Roles.Clear();
                UserManager.AddToRoleAsync(item.id_user_fk, item.Role);
                ajt_collaborator entity = repo.GetCollaboratorById(item.id);
                entity.id_user_fk = item.id_user_fk;
                entity.marital_status = item.marital_status;
                entity.Nom = item.Nom;
                entity.Prenom = item.Prenom;
                entity.address = item.address; 
                repo.UpdateCollaborateur(entity);      
             
        }

        [HttpDelete]
        public void DeleteAccount(int id)
        { 
           ajt_collaborator ajt_col = repo.GetCollaboratorById(id); 
           repo.DeleteCollaborateur(ajt_col); 
        }

        


        public ApplicationUserManager UserManager
        {
            get
            {

                return _userManager ??  HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

    }
}
