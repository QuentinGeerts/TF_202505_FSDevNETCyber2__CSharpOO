namespace DemoGeneric2.Models;

public class UserRepository
{
    private readonly List<User> _users;

    public UserRepository()
    {
        _users = new List<User>();
    }

    public void Add (User user)
    {
        if (user == null) throw new ArgumentNullException("user");
        if (_users.Contains(user)) throw new ArgumentException("L'utilisateur est déjà dans la liste");

        _users.Add(user);
        Console.WriteLine($"L'utilisateur a bien été ajouté.");
    }

    public User? FindById (Guid id)
    {
        foreach (var user in _users)
        {
            if (user.Id.Equals(id)) return user;
        }

        return null;
    }
}
