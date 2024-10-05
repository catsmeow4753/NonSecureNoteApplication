using NonSecureNoteApplication.Models;

namespace NonSecureNoteApplication.Interfaces
{
    public interface INoteService
    {
        void CreateNote(DataModel dataModel);
    }
}
