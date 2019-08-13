using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class OrganizationAddress
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }

    }
}
