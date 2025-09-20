namespace zjgmarketplace.Users.Core.Auth
{
    public interface IUserAuthenticated
    {
        bool IsAuthenticated { get; }
        Task ValidateTokenAsync();
    }
}
