using System.Security.Principal;
using Microsoft.AspNetCore.Identity;

namespace FinTracker.Models;


public class User : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string Currency { get; set; } = "KZT";

    public ICollection<Account> Accounts { get; set; } = new List<Account>();

}