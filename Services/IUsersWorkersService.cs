using OFTI_Service.Models;
using System.Collections.Generic;

namespace OFTI_Service.Services
{
    public interface IUsersWorkersService
    {
        int Create(CreateUsersWorkersDto workersDto);
        bool Delete(int id);
        IEnumerable<UsersWorkerDto> GetAll();
        UsersWorkerDto GetById(int id);
        bool Update(int id, UpdateUsersWorkers updateUsersWorkers);
    }
}