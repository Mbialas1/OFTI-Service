using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Models
{
    public class CreateUsersWorkersDto
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LoginName { get; set; }
        public bool Master { get; set; }
        public bool Admin { get; set; }
        public DateTime LastLogged { get; set; }
        public DateTime FirstLogged { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string NumberHouse { get; set; }
        public string Country { get; set; }
    }
}
