using OFTI_Service.Entities;
using OFTI_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly UsersWorkerDbContext _context;

        public AccountService(UsersWorkerDbContext context)
        {
            _context = context;
        }
        public void RegisterUser(RegisterUserDto registerUserDto)
        {
            var user = new User()
            {
                Email = registerUserDto.Email,
                DataBirth = registerUserDto.DateOfBirth,
                Nationality = registerUserDto.Nationality,
                RoleID = registerUserDto.RoleId
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
