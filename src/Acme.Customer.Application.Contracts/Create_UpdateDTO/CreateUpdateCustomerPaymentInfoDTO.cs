using Acme.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateCustomerPaymentInfoDTO
    {
        [Required]
        public Guid PaymentId { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
    }
}
