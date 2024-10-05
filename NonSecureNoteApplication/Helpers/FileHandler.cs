using NonSecureNoteApplication.Models;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace NonSecureNoteApplication.Helpers
{
    public class FileHandler
    {
        private string filePath = @"Data/File_1.json";

        public async Task WriteJsonAsync(DataModel data)
        {
			var jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
			await File.WriteAllTextAsync(filePath, jsonString);
		}

  //      public async Task ReadJsonAsync()
  //      {
		//	// read file into a string and deserialize JSON to a type
		//	//DataModel data = JsonConvert.DeserializeObject<DataModel>(File.ReadAllText(filePath));

		//	// deserialize JSON directly from a file
		//	using (StreamReader file = File.OpenText(filePath))
		//	{
		//		JsonSerializer serializer = new JsonSerializer();
		//		DataModel data = (DataModel)serializer.Deserialize(file, typeof(DataModel));
		//	}
		//}
        
  //      public static void WriteJson(string text, string fileName)
  //      {
  //          string output = Newtonsoft.Json.JsonConvert.SerializeObject(text, Newtonsoft.Json.Formatting.Indented);
		//	File.WriteAllText(fileName, output);
		//}

  //      public static string ReadJson(string fileName)
  //      {
  //          string jsonString = File.ReadAllText(fileName);
  //          return JsonSerializer.Deserialize<string>(jsonString).ToString();
  //      }
    }
}
