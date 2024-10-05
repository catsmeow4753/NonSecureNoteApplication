using NonSecureNoteApplication.Helpers;
using NonSecureNoteApplication.Interfaces;
using NonSecureNoteApplication.Models;

namespace NonSecureNoteApplication.Services
{
    public class NoteService : INoteService
    {
        public void CreateNote(DataModel dataModel)
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.WriteJsonAsync(dataModel);
        }

        public void UpdateNote(string fileName)
        {
        
        }

        public void DeleteNote(string fileName)
        {

        }

        public DataModel GetNote(string fileName)
        {
            FileHandler fileHandler = new FileHandler();
            return fileHandler.ReadJsonAsync(fileName);
        }
    }
}
