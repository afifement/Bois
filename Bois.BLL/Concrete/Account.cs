using Bois.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Bois.DAL;  

namespace Bois.BLL.Concrete
{
   public class Account : IAccount
    {

       static ICrud<ajt_collaborator> cruder;


        public ajt_collaborator GetCollaborator(string id_user)
        {
            if (cruder == null) cruder = new Crud<ajt_collaborator>();
            return cruder.GetAll().FirstOrDefault(x => x.id_user_fk == id_user);
        }
        public ajt_collaborator GetCollaboratorById(int id)
        {
            if (cruder == null) cruder = new Crud<ajt_collaborator>();
            return cruder.GetAll().FirstOrDefault(x => x.id == id);
        }
        public IEnumerable<ajt_collaborator> GetAllCollaborators()
        {
            if (cruder == null) cruder = new Crud<ajt_collaborator>();
            return cruder.GetAll().OrderByDescending(x=>x.id);
        }

        public void CreateCollaborator(ajt_collaborator collaborateur)
        {
            if (cruder == null) cruder = new Crud<ajt_collaborator>();
            List<ajt_collaborator> liste = cruder.GetAll().Where(x => x.id_user_fk == collaborateur.id_user_fk).ToList();
            if(liste.Count == 0)cruder.AddNew(collaborateur);
        }

        public void UpdateCollaborateur( ajt_collaborator collaborateur)
        {
            if (cruder == null) cruder = new Crud<ajt_collaborator>();
            cruder.Update(collaborateur);
        }

        public void DeleteCollaborateur( ajt_collaborator collaborateur)
        {
            if (cruder == null) cruder = new Crud<ajt_collaborator>();
            cruder.Archive(collaborateur);
        }


        public IEnumerable<ajt_collaborator> GetCollaboratorsForEmploye(IEnumerable<ajt_collaborator> ajt_coll)
        {
            List<ajt_collaborator> aj_coll_result = new List<ajt_collaborator>();
            foreach (ajt_collaborator item in ajt_coll)
            {
                ICrud<aspnetuser> crud = new Crud<aspnetuser>();
                List<aspnetuser> users = crud.GetAll().ToList();
                aspnetuser user = users.Where(x => x.Id == item.id_user_fk).FirstOrDefault();
                List<aspnetrole> liste = user.aspnetroles.ToList();
                if (liste.Count > 0) { 
                aspnetrole  rule = liste[0];
                if (rule.Name.Contains("chauffeur")) aj_coll_result.Add(item);
                }
            }
            return aj_coll_result.OrderByDescending(x => x.id);
        }

        public IEnumerable<ajt_collaborator> GetCollaboratorsForAdmins(IEnumerable<ajt_collaborator> ajt_coll)
        {
            List<ajt_collaborator> aj_coll_result = new List<ajt_collaborator>();
            foreach (ajt_collaborator item in ajt_coll)
            {
                ICrud<aspnetuser> crud = new Crud<aspnetuser>();
                List<aspnetuser> users = crud.GetAll().ToList();
                aspnetuser user = users.Where(x => x.Id == item.id_user_fk).FirstOrDefault(); 
                List<aspnetrole> liste = user.aspnetroles.ToList();
                if (liste.Count > 0) { 
                aspnetrole rule = liste[0];
                if (rule.Name.Contains("employe")) aj_coll_result.Add(item);
                                    }
            }
            return aj_coll_result.OrderByDescending(x=>x.id);
        }


        public string GetRoleFromCollaborator(ajt_collaborator coll)
        {
            ICrud<aspnetuser> crud = new Crud<aspnetuser>();
            List<aspnetuser> users = crud.GetAll().ToList();
            aspnetuser user = users.Where(x => x.Id == coll.id_user_fk).FirstOrDefault();
            List<aspnetrole> liste = user.aspnetroles.ToList();
            return liste[0].Name;
        }


       
    }
}
