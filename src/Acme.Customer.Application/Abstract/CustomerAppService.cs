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

        public CustomerAppService(IRepository<Customers,Guid> repository):base(repository) { 
        }


        private bool CheckUnusualName(string firstName)
        {
            char[] charArr = firstName.ToCharArray();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            Array.Sort(charArr);
            int sayac = 0;
            for (int i = 1; i < charArr.Length; i++)
            {
                if (charArr[i - 1] == charArr[i])
                    {
                    
                        sayac++;
                    }
            }
            if (sayac >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
