using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateCustomerAddressDTO 
    {
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public Guid AddressId { get; set; }
        [Required]
        [StringLength(350)]
        public string Address { get; set; }
    }
}
