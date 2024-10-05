using NonSecureNoteApplication.Helpers;
using NonSecureNoteApplication.Interfaces;
using NonSecureNoteApplication.Models;
using System.Numerics;

namespace NonSecureNoteApplication.Services
{
    public class NoteService : INoteService
    {
        //private string jsonFilePath = @"Data\MemberCatalog.json";

        public void CreateNote(DataModel dataModel)
        {
            //List<IMember> members = GetAllMembers();
            //member.Id = members.Count == 0 ? 1 : members.Max(x => x.Id) + 1;

            //members.Add(member);
            FileHandler fileHandler = new FileHandler();
            fileHandler.WriteJsonAsync(dataModel);
        }
    }
}
