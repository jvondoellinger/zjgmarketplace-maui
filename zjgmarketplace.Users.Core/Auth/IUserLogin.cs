namespace zjgmarketplace.Users.Core.Auth
{
    internal interface IUserLogin
    {
        Task Login(string email, string password);
    }
}
