using NonSecureNoteApplication.Models;

namespace NonSecureNoteApplication.Interfaces
{
    public interface INoteService
    {
        void CreateNote(DataModel dataModel);
        void UpdateNote(string fileName);
        void DeleteNote(string fileName);
        DataModel GetNote(string fileName);
    }
}
