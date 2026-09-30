using FinTracker.Models;

namespace FinTracker.Services
{
    public interface ITokenService
    {
        string CreateToken(User user, IList<string> roles);
    }
}