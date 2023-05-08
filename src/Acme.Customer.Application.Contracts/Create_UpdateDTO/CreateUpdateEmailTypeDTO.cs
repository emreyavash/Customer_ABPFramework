using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateEmailTypeDTO
    {
        [Required]
        [StringLength(50)]
        public string EmailTypeName { get; set; }

    }
}
