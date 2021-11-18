using Microsoft.AspNetCore.Mvc;
using OFTI_Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Controllers
{
    [Route("api/workers")]
    public class UsersController : ControllerBase
    {
        private UsersWorkerDbContext _UsersWorkerDb;
        public UsersController(UsersWorkerDbContext usersWorkerDbContext)
        {
            _UsersWorkerDb = usersWorkerDbContext;
        }

        [Route("test")]
        public ActionResult<IEnumerable<UsersWorker>> GetAll()
        {
            var workers = _UsersWorkerDb.UsersWorkers.ToList();

            return Ok(workers);
        }
    }
}
