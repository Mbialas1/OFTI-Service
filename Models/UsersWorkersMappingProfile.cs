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
        }
    }
}
