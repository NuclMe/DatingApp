namespace API.Entities;
public class AppUser
{
    public int id { get; set; } = 0;
    public required string UserName { get; set; }

    public required byte[] PasswordHash { get; set; }

    public required byte[] PasswordSalt { get; set; }

}