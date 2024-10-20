using System.Diagnostics.CodeAnalysis;

namespace NonSecureNoteApplication.Models
{
    public class User
    {
        [SetsRequiredMembers]
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public required string Username { get; init; }
        public required string Password { get; init; }
    }
}
