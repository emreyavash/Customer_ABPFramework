﻿using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using Acme.Customer.Entities;
using Acme.Customer.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Customer.Abstract
{
    public class CustomerAppService :CrudAppService<
        Customers,
        CustomerDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerDTO>,ICustomerAppService
    {
        private readonly IRepository<Customers, Guid> _repository;
        public CustomerAppService(IRepository<Customers,Guid> repository):base(repository) {
            _repository = repository;
        }

        public async Task CreateCustomer(CreateUpdateCustomerDTO customerDTO)
        {
            var checkName = CheckUnusualName(customerDTO.FirstName);
            var customer = new Customers(
                GuidGenerator.Create()
                );
            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.TcNo = customerDTO.TcNo;
            customer.Gender = customerDTO.Gender;
            customer.CreateDateTime = customerDTO.CreateDateTime;
            if (checkName)
            {
                customer.UnusualName = checkName;

            }
            else
            {
                customer.UnusualName = checkName;

            }
            await _repository.InsertAsync(customer);

        }

        private bool CheckUnusualName(string firstName)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] charArr = firstName.ToLower().ToCharArray();
            Array.Sort(charArr);
            int sayac = 0;
            var checkSesliHarf = charArr.Where(x => x.IsIn(sesliHarfler));
            if (checkSesliHarf.Count() >= 3)
            {
                var number = checkSesliHarf.Count();
                for (int i = 1; i < charArr.Length; i++)
                {
                    if (charArr[i - 1] == charArr[i])
                        sayac++;
                }
            }
            if (sayac >= 2)
                return true;
            else
                return false;
        }

    }
}
