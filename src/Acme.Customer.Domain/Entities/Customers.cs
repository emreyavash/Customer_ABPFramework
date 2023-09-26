using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class Customers : AggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public bool Gender { get; set; }
        public bool UnusualName { get; set; }
        public ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public ICollection<CustomerPhoneNumber> CustomerPhoneNumbers { get; set; }
        public ICollection<CustomerEmail> CustomerEmails { get; set; }
        public ICollection<CustomerPaymentInfo> CustomerPaymentInfos { get; set; }

        public DateTime CreateDateTime { get; set; }

        public Customers(Guid id):base(id)
        {
        }

        private Customers()
        {
        }
    }
}
