using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMicroservice.Models
{
    public class Executive
    {
        [Key]
        public int ExecutiveId { get; set; }

        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string Locality { get; set; }

        public string EmailId { get; set; }

    }
}
