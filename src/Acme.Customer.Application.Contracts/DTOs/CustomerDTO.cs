using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerDTO : AuditedEntityDto<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public bool Gender { get; set; }
        public bool UnusualName { get; set; }
        public ICollection<CustomerAddressDTO> CustomerAddresses { get; set; }
        public ICollection<CustomerPhoneNumberDTO> CustomerPhoneNumbers { get; set; }
        public ICollection<CustomerEmailDTO> CustomerEmails { get; set; }
        public ICollection<CustomerPaymentInfoDTO> CustomerPayments { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
