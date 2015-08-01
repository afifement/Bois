using Bois.DAL; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bois.BLL.Abstract
{
    public interface IAccount
    {
        ajt_collaborator GetCollaborator(string id_user);
        ajt_collaborator GetCollaboratorById(int id);
        IEnumerable<ajt_collaborator> GetAllCollaborators();
        IEnumerable<ajt_collaborator> GetCollaboratorsForEmploye(IEnumerable<ajt_collaborator> ajt_coll);
        IEnumerable<ajt_collaborator> GetCollaboratorsForAdmins(IEnumerable<ajt_collaborator> ajt_coll);
        string GetRoleFromCollaborator(ajt_collaborator coll);
        void CreateCollaborator(ajt_collaborator collaborateur);
        void UpdateCollaborateur(ajt_collaborator collaborateur);
        void DeleteCollaborateur(ajt_collaborator collaborateur);
    }
}
