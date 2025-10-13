using Marketplace.AuthorizationLayer.Models;

namespace Marketplace.AuthorizationLayer.Interface;

public interface ITokenRequest<T> where T : ApiToken
{
    T SendRequest();
}
