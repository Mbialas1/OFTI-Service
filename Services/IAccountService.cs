using OFTI_Service.Models;

namespace OFTI_Service.Services
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto registerUserDto);
    }
}