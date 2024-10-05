using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NonSecureNoteApplication.Helpers;
using NonSecureNoteApplication.Interfaces;
using NonSecureNoteApplication.Models;
using NonSecureNoteApplication.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NonSecureNoteApplication.Pages
{
    public class NoteEditorModel : PageModel
    {
        //private FileHandler FileHandler = new FileHandler();
        private INoteService NoteService;

        [BindProperty]
        public DataModel DataModel { get; set; }

        public NoteEditorModel(INoteService noteService)
        {
            //FileHandler = fileHandler;
            NoteService = noteService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    NoteService.CreateNote(DataModel);
                }
                catch (Exception e)
                {
                    //Error = true;
                    //ErrorMessage = e.Message;
                }

                //return RedirectToPage("/Members/Index");
            }

            return Page();
        }
    }
}
