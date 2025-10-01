using System.ComponentModel.DataAnnotations;

namespace Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;

public record UserRegisterRequestModel
{
    public string Username { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }

    public Phone Phone { get; init; }

    [StringLength(maximumLength: 11)]
    public CPF Document { get; init; }
    public DateTime BirthDay { get; init; }
}

public record CPF
{
    public string Cpf { get; set; }
}

public record Phone
{
    public string CountryCode { get; internal set; }
    public string AreaCode { get; internal set; }
    public string Number { get; internal set; }
}
