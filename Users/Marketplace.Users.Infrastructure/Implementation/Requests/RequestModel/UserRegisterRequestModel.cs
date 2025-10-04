using Marketplace.Users.Infrastructure.Serializer;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;

public class UserRegisterRequestModel
{
    public UserRegisterRequestModel(string username, string email, string password, Phone phone, CPF document, DateOnly birthDay)
    {
        Username = username;
        Email = email;
        Password = password;
        Phone = phone;
        Document = document;
        BirthDay = birthDay;
    }

    public string Username { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }

    public Phone Phone { get; init; }

    [StringLength(maximumLength: 11)]
    public CPF Document { get; init; }
    
    public DateOnly BirthDay { get; init; }
}

public record CPF
{
    public string Cpf { get; set; }
}

public record Phone
{
    public string CountryCode { get; init; }
    public string AreaCode { get; init; }
    [JsonPropertyName("number")]
    [JsonConverter(typeof(NumberAsStringConverter))]
    public string TelNumber { get; init; }
}
