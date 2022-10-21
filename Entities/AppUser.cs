using Microsoft.AspNetCore.Identity;

namespace Abdulaziz.Entities;

public class AppUser : IdentityUser
{
    public string Id { get; set; }
    public string Fullname { get; set; }
    public string? Email { get; set; }
    public string Password { get; set; }
    public string ImageUrl { get; set; }
    public ulong TelegramUserId { get; set; }
    public ERole UserRole { get; set; }

    [Obsolete("Used only for entity binding")]
    public AppUser() { }

    public AppUser(string fullname, string username, string email)
    {
        Fullname = fullname;
        Email = email;
        UserName = username;
    }
}