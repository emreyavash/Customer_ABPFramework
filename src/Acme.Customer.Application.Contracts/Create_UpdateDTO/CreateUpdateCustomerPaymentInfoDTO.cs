using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateCustomerPaymentInfoDTO
    {
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}
