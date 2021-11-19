using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OFTI_Service.Entities;
using OFTI_Service.Models;
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
        private IMapper _mapper;
        public UsersController(UsersWorkerDbContext usersWorkerDbContext, IMapper mapper)
        {
            _UsersWorkerDb = usersWorkerDbContext;
            _mapper = mapper;
        }

        [HttpGet("test")]
        public ActionResult<IEnumerable<UsersWorkerDto>> GetAll()
        {
            //if (!_UsersWorkerDb.UsersWorkers.Any())
            //{
                var workers = _UsersWorkerDb
                    .UsersWorkers 
                    .Include(r => r.workersAddresses)
                    .ToList();

            

                return _mapper.Map<List<UsersWorkerDto>>(workers);
            //}
                
            return null;
        }

        [HttpGet("{id}")]
        public ActionResult<UsersWorkerDto> Get([FromRoute] int id)
        {
            if (!_UsersWorkerDb.UsersWorkers.Any())
            {
                var workers = _UsersWorkerDb
                .UsersWorkers
                .Include(r => r.workersAddresses)
                .FirstOrDefault(u => u.Id == id);


                if (workers is null)
                {
                    return NotFound();
                }

                return _mapper.Map<UsersWorkerDto>(workers);
            }

            return null;
        }
    }
}
