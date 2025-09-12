namespace zjgmarketplace.Users.Core.Entity
{
    public class User
    {
        public User(string id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }
        public User(string name, string email, string password)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Password = password;
        }

        public string Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
