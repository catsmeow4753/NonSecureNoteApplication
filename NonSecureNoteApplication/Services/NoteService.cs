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
            FileHandler fileHandler = new FileHandler();
            fileHandler.WriteJsonAsync(dataModel);
        }
    }
}
