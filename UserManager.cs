using System.Collections.Generic;
using System.Linq;
using Project11;

public class UserManager
{
    private static UserManager instance;
    private List<User> users;

    private UserManager()
    {
        users = new List<User>();
        // Add a default admin for demonstration purposes
        users.Add(new User("admin", "admin", "admin@example.com", true));
    }

    public static UserManager GetInstance()
    {
        if(instance == null)
        {
            if (instance == null)
                instance = new UserManager();
            return instance;
        }
        return instance;
    }

    public void AddUser(User user)
    {
        users.Add( user );
        //MessageBox.Show("yser added");
    }

    public User GetUser(string username)
    {
        return users.FirstOrDefault(u => u.Username == username);
    }

    public void RemoveUser(string username)
    {
        var user=GetUser(username);
        if (user!=null)
        {
            users.Remove(user);
            // Console.WriteLine($"Student '{username}' removed successfully.");
            MessageBox.Show("User '{username}' removed successfully.");
        }
        else
        {
            // Console.WriteLine($"Student '{username}' not found.");
            MessageBox.Show("User '{username}' removed successfully.");
        }
    }

    public bool ValidateUser(string username, string password, out bool isAdmin)
    {
        var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
        if (user != null)
        {
            isAdmin = user.IsAdmin;
            return true;
        }
        isAdmin = false;
        return false;
    }
    
    
}
