using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Models
{
    public class CreateUsersWorkersDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LoginName { get; set; }
        public bool Master { get; set; }
        public bool Admin { get; set; }
        public DateTime LastLogged { get; set; }
        public DateTime FirstLogged { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NumberHouse { get; set; }
        public string Country { get; set; }
    }
}
