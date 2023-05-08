using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateCustomerPaymentDTO
    {
        [Required]
        [StringLength(250)]
        public string PaymentName { get; set; }

    }
}
