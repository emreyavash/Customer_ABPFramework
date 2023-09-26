using Acme.Customer.Create_UpdateDTO;
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
using Volo.Abp.Identity;
using System.Linq.Dynamic.Core;
using System.Security.Cryptography.X509Certificates;

namespace Acme.Customer.Abstract
{
    public class CustomerAppService :ApplicationService,ICustomerAppService
    {
        private readonly IRepository<Customers, Guid> _repository;

        public CustomerAppService(IRepository<Customers, Guid> repository)
        {
            _repository = repository;
        }

        public async Task CreateCustomer(CreateUpdateCustomerDTO customerDTO)
        {
            var customer = new Customers(
                GuidGenerator.Create()
                );
            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.TcNo = customerDTO.TcNo;
            customer.Gender = customerDTO.Gender;
            customer.CreateDateTime = customerDTO.CreateDateTime;
            customer.CustomerAddresses = new List<CustomerAddress>();
            foreach (var ca in customerDTO.CustomerAddresses)
            {
                var customerAddress = new CustomerAddress(GuidGenerator.Create())
                {
                    CustomerId = customer.Id,
                    AddressId = ca.AddressId,
                    Address =ca.Address,
                  
                    
                };
                customer.CustomerAddresses.Add(customerAddress);
            }
            customer.CustomerPhoneNumbers = new List<CustomerPhoneNumber>();
            foreach (var cp in customerDTO.CustomerPhoneNumbers)
            {
                var customerPhoneNumber = new CustomerPhoneNumber(GuidGenerator.Create())
                {
                    CustomerId = customer.Id,
                    PhoneTypeId = cp.PhoneTypeId,
                    PhoneNumber = cp.PhoneNumber,
                };
                customer.CustomerPhoneNumbers.Add(customerPhoneNumber);
            }
            customer.CustomerEmails = new List<CustomerEmail>();
            foreach (var ce in customerDTO.CustomerEmails)
            {
                var customerEmails = new CustomerEmail(GuidGenerator.Create())
                {
                    CustomerId = customer.Id,
                    Email = ce.Email,
                    EmailTypeId = ce.EmailTypeId,
                };
                customer.CustomerEmails.Add(customerEmails);
            }
            customer.CustomerPaymentInfos = new List<CustomerPaymentInfo>();
            foreach(var cp in customerDTO.CustomerPaymentInfos)
            {
                var customerPaymentInfos = new CustomerPaymentInfo(GuidGenerator.Create())
                {
                    CustomerId = customer.Id,
                    PaymentId = cp.PaymentId,
                    
                };
                customer.CustomerPaymentInfos.Add(customerPaymentInfos);
            }
            var checkName = CheckUnusualName(customerDTO.FirstName);
            customer.UnusualName = checkName;

           
            await _repository.InsertAsync(customer);

        }

        public async Task DeleteCustomer(Guid id)
        {
            await _repository.DeleteAsync(id);

        }

        public async Task<List<CustomerDTO>> GetCustomers()
        {
            var queryable = await _repository.WithDetailsAsync(x => x.CustomerAddresses,x=>x.CustomerEmails,x=>x.CustomerPhoneNumbers,x=>x.CustomerPaymentInfos);
            var customers =  queryable.ToList();
            return ObjectMapper.Map<List<Customers>,List<CustomerDTO>>(customers);
        }
        public async Task<CustomerDTO> GetCustomerById(Guid id)
        {
            var queryable = await _repository.WithDetailsAsync(x => x.CustomerAddresses, x => x.CustomerEmails, x => x.CustomerPhoneNumbers, x => x.CustomerPaymentInfos);
            var customer = queryable.FirstOrDefault(x=>x.Id ==id);
            return ObjectMapper.Map<Customers, CustomerDTO>(customer);
        }
        

        private bool CheckUnusualName(string firstName)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<Char> charArr = firstName.ToLower().Where(x => x.IsIn(sesliHarfler)).OrderBy(x=>x).ToList();      
            int sayac = 0;
            if (charArr.Count() >= 3)
            {
                for (int i = 1; i < charArr.Count; i++)
                {
                    if (charArr[i - 1] == charArr[i])
                    {
                        sayac++;
                        if (sayac >= 2)
                            break;
                    }
                    else
                    {
                        sayac = 0;
                    }
                }
            }
            if (sayac >= 2)
                return true;
            else
                return false;
        }

    }
}
