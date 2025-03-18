using System;
using System.Security.Cryptography;
using System.Text;

public class UserModel
{
    public string Username { get; set; }
    public string HashedPassword { get; set; }

    public UserModel(string username, string password)
    {
        Username = username;
        HashedPassword = HashPassword(password);
    }

    // Password hashing method
    public string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var byteVal in bytes)
            {
                builder.Append(byteVal.ToString("x2"));
            }
            return builder.ToString();
        }
    }

    // Authentication method
    public bool Authenticate(string enteredPassword)
    {
        return HashPassword(enteredPassword) == HashedPassword;
    }
}
