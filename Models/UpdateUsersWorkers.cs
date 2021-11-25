using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OFTI_Service.Models
{
    public class UpdateUsersWorkers
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LoginName { get; set; }
    }
}
