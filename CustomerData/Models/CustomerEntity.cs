using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Models
{
    public class CustomerEntity : BaseEntity
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        public string? Address { get; set; }

        [StringLength(11)]
        public string? Phone { get; set; }
    }
}
