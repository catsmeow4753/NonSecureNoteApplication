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
        public List<DataModel> NoteList { get; set; }

        public NoteEditorModel(INoteService noteService)
        {
            NoteService = noteService;
        }

        public IActionResult OnGet()
        {
            NoteList = NoteService.GetAllNotes();

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

        public IActionResult OnPostEdit(int id)
        {
            DataModel = NoteList[id];

            //NoteService.UpdateNote(DataModel, "");

            return Page();
        }

        public IActionResult OnPostDelete()
        {
            NoteService.DeleteNote(DataModel);

            return Page();
        }
    }
}
