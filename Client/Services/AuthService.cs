namespace Client.Services;

public class AuthService
{
    public bool IsAuthenticated { get; set; }
    public string? Username { get; set; }

    public Task<bool> LoginAsync(string username, string password)
    {
        if (username == "admin" && password == "admin")
        {
            IsAuthenticated = true;
            Username = username;
            
            return Task.FromResult(true);
        }
        
        IsAuthenticated = false;
        return Task.FromResult(false);
    }

    public void Logout()
    {
        IsAuthenticated = false;
        Username = string.Empty;
    }
}