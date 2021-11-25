using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OFTI_Service.Entities;
using OFTI_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Services
{
    public class UsersWorkersService : IUsersWorkersService
    {
        private readonly UsersWorkerDbContext _usersWorkerDb;
        private readonly IMapper _mapper;
        private readonly ILogger<UsersWorkersService> _logger;

        public UsersWorkersService(UsersWorkerDbContext usersWorkerDb, IMapper mapper, ILogger<UsersWorkersService> logger)
        {
            _usersWorkerDb = usersWorkerDb;
            _mapper = mapper;
            _logger = logger;
        }
        public bool Update(int id, UpdateUsersWorkers updateUsersWorkers)
        {
            var workers = _usersWorkerDb
                .UsersWorkers
                .FirstOrDefault(r => r.Id == id);

            if (workers is null)
                return false;

            workers.Name = updateUsersWorkers.Name;
            workers.LastName = updateUsersWorkers.LastName;
            workers.LoginName = updateUsersWorkers.LoginName;

            _usersWorkerDb.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            _logger.LogError($"Worker with id : {id} TRY DELETED!");
            var workers = _usersWorkerDb
            .UsersWorkers
            .FirstOrDefault(u => u.Id == id);

            if (workers is null) return false;

            _usersWorkerDb.UsersWorkers.Remove(workers);
            _usersWorkerDb.SaveChanges();

            return true;
        }
        public UsersWorkerDto GetById(int id)
        {
            var workers = _usersWorkerDb
            .UsersWorkers
            .Include(r => r.workersAddresses)
            .FirstOrDefault(u => u.Id == id);

            if (workers is null) return null;

            var result = _mapper.Map<UsersWorkerDto>(workers);
            return result;
        }
        public IEnumerable<UsersWorkerDto> GetAll()
        {
            var workers = _usersWorkerDb
                .UsersWorkers
                .Include(r => r.workersAddresses)
                .ToList();

            var workersDtos = _mapper.Map<List<UsersWorkerDto>>(workers);
            return workersDtos;
        }

        public int Create(CreateUsersWorkersDto workersDto)
        {
            var usersWorker = _mapper.Map<UsersWorker>(workersDto);
            _usersWorkerDb.UsersWorkers.Add(usersWorker);
            _usersWorkerDb.SaveChanges();

            return usersWorker.Id;
        }
    }
}
