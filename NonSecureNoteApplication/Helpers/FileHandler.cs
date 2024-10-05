using NonSecureNoteApplication.Models;
using System.IO;
using System.Text.Json;
namespace NonSecureNoteApplication.Helpers
{
    public class FileHandler
    {
        private string filePath = @"Data";

        public async Task WriteJsonAsync(DataModel data)
        {
			var jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
			await File.WriteAllTextAsync($"{filePath}/{data.TitleText}.json", jsonString);
        }
        public DataModel ReadJsonAsync(string fileName)
		{
            var jsonString = File.ReadAllText($"{filePath}/{fileName}.json");
            return JsonSerializer.Deserialize<DataModel>(jsonString);
		}
	}
}
