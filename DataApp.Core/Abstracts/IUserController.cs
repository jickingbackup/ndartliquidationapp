using DataApp.Core.Models;

namespace DataApp.Core.Abstracts
{
    public interface IUserController:IController<User>
    {
        User Login(string username, string password);
    }
}
