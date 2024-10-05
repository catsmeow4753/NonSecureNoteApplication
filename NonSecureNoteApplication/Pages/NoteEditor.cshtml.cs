using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace NonSecureNoteApplication.Pages
{
    public class NoteEditorModel : PageModel
    {
        private static List<Note> _notes = new List<Note>
    {
        new Note { Id = 1, Title = "First Note", Body = "This is the body of the first note." },
        new Note { Id = 2, Title = "Second Note", Body = "This is the body of the second note." },
        // Add more notes as needed
    };

        public List<Note> Notes { get; set; }

        public void OnGet()
        {
            Notes = _notes;
        }

        public IActionResult OnPostAddNote([FromBody] NoteUpdateModel newNote)
        {
            var newId = _notes.Max(n => n.Id) + 1; // Generate new ID
            var note = new Note { Id = newId, Title = newNote.Title, Body = newNote.Body };
            _notes.Add(note);

            return new JsonResult(note);
        }

        public IActionResult OnPostEditTitle(int id, [FromBody] NoteUpdateModel update)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                note.Title = update.Title;
            }
            return new JsonResult(note);
        }

        
        public IActionResult OnPostEditBody(int id, [FromBody] NoteUpdateModel update)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                note.Body = update.Body;
            }
            return new JsonResult(note);
        }
    }

    public class Note
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Body { get; set; }
    }

    public class NoteUpdateModel
    {
        
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
