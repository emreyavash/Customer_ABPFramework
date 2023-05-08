using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateCustomerEmailDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int EmailTypeId { get; set; }
        [Required]
        [StringLength(250)]
        public string Email { get; set; }
    }
}
