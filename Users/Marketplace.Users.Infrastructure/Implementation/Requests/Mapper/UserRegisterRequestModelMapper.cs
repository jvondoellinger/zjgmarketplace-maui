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
            TelNumber = model.Phone.Number
        };
        return new(model.Username, model.Email, model.Password, phone, doc, model.BirthDay);
    } 
}
