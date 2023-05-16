using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Customer.Entities
{
    public class Deneme : AggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public bool UnusualName { get; set; }
        public Deneme(Guid id) : base(id)
        {
        }
    }
}
