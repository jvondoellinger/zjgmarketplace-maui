using System.ComponentModel.DataAnnotations;

namespace Marketplace.Users.Core.Models;

public class UserModel
{
    public string Username { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }

    [StringLength(maximumLength: 14)]
    public Phone Phone { get; init; }

    [StringLength(maximumLength: 11)]
    public string Cpf { get; init; }
    public DateOnly BirthDay { get; init; }
}

public class Phone
{
    public string CountryCode { get; init; }
    public string AreaCode { get; init; }
    public string Number { get; init; }
}
