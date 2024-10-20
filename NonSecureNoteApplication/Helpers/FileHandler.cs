using NonSecureNoteApplication.Models;
using System.IO;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace NonSecureNoteApplication.Helpers
{
    public class FileHandler
    {
        private string filePath = @"Data/Notes";

        public async Task WriteJsonAsync(DataModel data)
        {
			var jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
			await File.WriteAllTextAsync($"{filePath}/{data.TitleText}.json", jsonString);
        }

        public DataModel ReadJson(string fileName)
		{
            var jsonString = File.ReadAllText($"{fileName}");
            return JsonSerializer.Deserialize<DataModel>(jsonString);
		}

        //User stuff start
        #region userStuff

        private string userFilePath = @"Data/User";

        public async Task WriteUserJsonAsync(User user)
        {
            var jsonString = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync($"{filePath}/{user.Username}.json", jsonString);
        }

        public User ReadUserJson(string fileName)
        {
            var jsonString = File.ReadAllText($"{fileName}");
            return JsonSerializer.Deserialize<User>(jsonString);
        }

        #endregion
    }
}
