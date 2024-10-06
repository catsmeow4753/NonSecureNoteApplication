using NonSecureNoteApplication.Models;

namespace NonSecureNoteApplication.Interfaces
{
    public interface INoteService
    {
        void CreateNote(DataModel data);
        void UpdateNote(DataModel data, string newFileName);
        bool DeleteNote(DataModel data);
        DataModel GetNote(string fileName);
        List<DataModel> GetAllNotes();
    }
}
