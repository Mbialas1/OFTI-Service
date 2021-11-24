using AutoMapper;
using OFTI_Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Models
{
    public class UsersWorkersMappingProfile : Profile
    {
        public UsersWorkersMappingProfile()
        {
            CreateMap<UsersWorker, UsersWorkerDto>();

            CreateMap<WorkersAddress, WorkersAddresDto>();

            CreateMap<CreateUsersWorkersDto, UsersWorker>()
                .ForMember(r => r.workersAddresses, c => c.MapFrom(dto => new WorkersAddress() 
                { 
                    City = dto.City,
                    Country = dto.Country,
                    NumberHouse = dto.NumberHouse,
                    Street = dto.Street
                }));
        }
    }
}
