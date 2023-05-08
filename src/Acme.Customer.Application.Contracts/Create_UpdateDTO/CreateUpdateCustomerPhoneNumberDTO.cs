using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateCustomerPhoneNumberDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int PhoneTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
    }
}
