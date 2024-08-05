public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public bool IsAdmin { get; set; }

    public User(string username, string password, string email, bool isAdmin = false)
    {
        Username = username;
        Password = password;
        Email = email;
        IsAdmin = isAdmin;
    }
}
