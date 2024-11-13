namespace API.Features.Account.DTO;

public class AccountResponse
{
    public Guid Id { get; set; }
    public Guid ReviewerId { get; set; }
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}