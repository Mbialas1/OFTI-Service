using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Models
{
    public class UsersWorkerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FirstLogged { get; set; }
        public List<WorkersAddresDto> workersAddresses { get; set; }
    }
}
