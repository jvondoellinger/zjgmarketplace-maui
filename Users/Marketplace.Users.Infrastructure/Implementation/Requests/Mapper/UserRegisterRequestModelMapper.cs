using Marketplace.Users.Core.Models;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;

namespace Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;

internal sealed class UserRegisterRequestModelMapper
{
    internal static UserRegisterRequestModel Map(UserModel model)
    {
        var doc = new CPF()
        {
            Cpf = model.Cpf
        };
        ;
        var phone = new RequestModel.Phone()
        {
            AreaCode = model.Phone.AreaCode,
            CountryCode = model.Phone.CountryCode,
            Number = model.Phone.Number
        };
        return new()
        {
            Username = model.Username,
            BirthDay = model.BirthDay,
            Email = model.Email,
            Password = model.Password,
            Document = doc,
            Phone = phone
        };
    } 
}
