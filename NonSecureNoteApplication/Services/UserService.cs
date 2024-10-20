using Microsoft.AspNetCore.Authentication;
using NonSecureNoteApplication.Helpers;
using NonSecureNoteApplication.Models;

namespace NonSecureNoteApplication.Services
{
    public class UserService
    {
        private string filePath = @"Data/User";
        FileHandler fileHandler = new FileHandler();

        public async void CreateNewUser(string username, string password)
        {
            if (username.Length > 3 & password.Length > 3) {

                User user = new User(username, password);
                await fileHandler.WriteUserJsonAsync(user);
            }
            
        }

        public string Login(string username, string password) 
        {
            fileHandler.ReadUserJson(username);

            var rand = new Random();

            var token = rand.Next().ToString() + DateTime.Now.ToString();

            return token;
        }

        public void Logout() { }

        public void UpdateUser(string username, string password) { }

        public void DeleteUser(string username, string password) { }

    }
}
