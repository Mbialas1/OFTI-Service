using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OFTI_Service.Entities;
using OFTI_Service.Models;
using OFTI_Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Controllers
{
    [Route("api/workers")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersWorkersService _workersService;

        public UsersController(IUsersWorkersService workersService)
        {
            _workersService = workersService;
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateUsersWorkers updateUsers, [FromRoute]int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var isUpdate = _workersService.Update(id, updateUsers);
            return isUpdate ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var isDeleted = _workersService.Delete(id);

            return isDeleted ? NoContent() : NotFound();
        }

        [HttpGet("test")]
        public ActionResult<IEnumerable<UsersWorkerDto>> GetAll()
        {
            var workers = _workersService.GetAll();
            return workers.ToList();
        }

        [HttpPost("testPost")]
        public ActionResult CreateUsersWorkers([FromBody] CreateUsersWorkersDto createUsersWorkersDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var id = _workersService.Create(createUsersWorkersDto);

            return Created($"/api/workers/{id}", null);
        }

        [HttpGet("{id}")]
        public ActionResult<UsersWorkerDto> Get([FromRoute] int id)
        {
            var workers = _workersService.GetById(id);

            return workers is not null ? Ok(workers) : NotFound();
        }
    }
}
