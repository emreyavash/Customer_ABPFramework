﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class DenemeDTO : EntityDto<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public bool UnusualName { get; set; }
    }
}
