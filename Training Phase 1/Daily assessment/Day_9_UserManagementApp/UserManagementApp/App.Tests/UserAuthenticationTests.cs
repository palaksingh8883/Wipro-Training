using System.Security.Cryptography;
using System.Text;
using Serilog;

public class UserService
{
    public bool Authenticate(string username, string password)
    {
        // Dummy logic for the example. Hash and compare password here.
        string storedPasswordHash = GetStoredPasswordHash(username); // Retrieve the stored hash

        using (var sha256 = SHA256.Create())
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordHash = sha256.ComputeHash(passwordBytes);

            string hashedPassword = Convert.ToBase64String(passwordHash);
            return hashedPassword == storedPasswordHash;
        }
    }

    private string GetStoredPasswordHash(string username)
    {
        // Return a dummy hash for the sake of the example.
        // In a real-world app, this would retrieve the stored hash from a database.
        return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes("correctpassword")));
    }
}
