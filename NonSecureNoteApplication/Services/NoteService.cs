using NonSecureNoteApplication.Helpers;
using NonSecureNoteApplication.Interfaces;
using NonSecureNoteApplication.Models;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NonSecureNoteApplication.Services
{
    public class NoteService : INoteService
    {
        private string filePath = @"Data";

        public void CreateNote(DataModel data)
        {
            FileHandler fileHandler = new FileHandler();

            fileHandler.WriteJsonAsync(data);
        }

        public void UpdateNote(DataModel data, string newFileName)
        {
        
        }

        public bool DeleteNote(DataModel data)
        {
            string path = $"{filePath}/{data.TitleText}.json";

            if (File.Exists(path))
            {
                File.Delete(path);

                Console.WriteLine($"Deleted file: {path}");

                return true;
            }
            else
            {
                return false;
            }
        }

        public DataModel GetNote(string fileName)
        {
            FileHandler fileHandler = new FileHandler();

            return fileHandler.ReadJson($"{filePath}/{fileName}.json");
        }

        public List<DataModel> GetAllNotes()
        {
            FileHandler fileHandler = new FileHandler();

            List<DataModel> noteList = new List<DataModel>();

            foreach (string fileName in Directory.GetFiles(filePath))
            {
                noteList.Add(fileHandler.ReadJson($"{fileName}"));
            }

            return noteList;
        }
    }
}
