using Acme.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Customer.Create_UpdateDTO
{
    public class CreateUpdateCustomerDTO
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [StringLength(11)]
        public string TcNo { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public bool UnusualName { get; set; }
        [Required]
        public ICollection<CustomerAddressDTO> CustomerAddresses { get; set; }
        [Required]
        public ICollection<CustomerPhoneNumberDTO> CustomerPhoneNumbers { get; set; }       
        [Required]
        public ICollection<CustomerEmailDTO> CustomerEmails { get; set; }
        [Required]
        public ICollection<CustomerPaymentInfoDTO> CustomerPaymentInfos { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreateDateTime { get; set; }= DateTime.Now;
    }
}
