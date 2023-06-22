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
            var customer = new Customers(
                GuidGenerator.Create()
                );
            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.TcNo = customerDTO.TcNo;
            customer.Gender = customerDTO.Gender;
            customer.CreateDateTime = customerDTO.CreateDateTime;
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
            var customers = await _repository.GetListAsync();
            return ObjectMapper.Map<List<Customers>,List<CustomerDTO>>(customers);
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
