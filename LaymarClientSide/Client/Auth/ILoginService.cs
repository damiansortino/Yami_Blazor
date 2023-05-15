using System.Threading.Tasks;

namespace LaymarClientSide.Client.Auth
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
