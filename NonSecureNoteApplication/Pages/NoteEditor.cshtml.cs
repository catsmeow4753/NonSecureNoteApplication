using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NonSecureNoteApplication.Interfaces;
using NonSecureNoteApplication.Models;

namespace NonSecureNoteApplication.Pages
{
    public class NoteEditorModel : PageModel
    {
        private INoteService NoteService;

        [BindProperty]
        public DataModel DataModel { get; set; }

        [BindProperty]
        public List<DataModel> NoteList { get; set; }

        public NoteEditorModel(INoteService noteService)
        {
            NoteService = noteService;
        }

        public IActionResult OnGet(int id)
        {
            NoteList = NoteService.GetAllNotes();

            if (NoteList.Count > 0 )
            {
                DataModel = NoteList[id];
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                NoteService.CreateNote(DataModel);
            }

            return Page();
        }

        public IActionResult OnPostView()
        {
            DataModel = NoteService.GetNote("");

            return Page();
        }

        public IActionResult OnPostDelete()
        {
            NoteService.DeleteNote(DataModel);

            return Page();
        }
    }
}
