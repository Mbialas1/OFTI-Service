using OFTI_Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Tymczas
{
    public class UsersWorkerAdd
    {
        private readonly UsersWorkerDbContext _dbcontext;

        public UsersWorkerAdd(UsersWorkerDbContext usersWorkerDbContext)
        {
            _dbcontext = usersWorkerDbContext;
        }

        public void Seed()
        {
            if (_dbcontext.Database.CanConnect())
            {
                var workers = GetWorkers();
                _dbcontext.UsersWorkers.AddRange(workers);
                _dbcontext.SaveChanges();
            }
        }

        private IEnumerable<UsersWorker> GetWorkers()
        {
            return new List<UsersWorker>()
            {
                new UsersWorker()
                {
                    Name = "Adrian",
                    LastName = "Białas",
                    LoginName = "NewProfile",
                    Master = false,
                    Admin = true,
                    LastLogged = DateTime.Now,
                    FirstLogged = DateTime.Now,
                    workersAddresses = new WorkersAddress()
                    {
                          City = "Poznań",
                          Country = "PL",
                          NumberHouse = "3",
                          Street = "Dąbrowskiego"
                    }
                }
            };
        }
    }
}