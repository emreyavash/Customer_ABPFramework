using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using Acme.Customer.Entities;
using Acme.Customer.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.Customer.Abstract
{
    public class DenemeService : ApplicationService, IDenemeService
    {
        private readonly IRepository<Deneme, Guid> _repository;

        public DenemeService(IRepository<Deneme, Guid> repository)
        {
            _repository = repository;
        }

        public async Task CreateDeneme(CreateDenemeDTO customerDTO)

        {
            var checkName = CheckUnusualName(customerDTO.FirstName);

            var customer = new Deneme(
                GuidGenerator.Create()
                );
            customer.FirstName= customerDTO.FirstName;
            customer.LastName= customerDTO.LastName;
            customer.TcNo = customerDTO.TcNo;
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

        public async Task<List<DenemeDTO>> GetCustomers()
        {
            
            var result = await _repository.GetListAsync();
            return ObjectMapper.Map<List<Deneme>,List<DenemeDTO>>(result);
        }


        private bool CheckUnusualName(string firstName)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] charArr = firstName.ToLower().ToCharArray();
            Array.Sort(charArr);
            int sayac = 0;
            var checkSesliHarf = charArr.Where(x => x.IsIn(sesliHarfler));
            if (checkSesliHarf.Count()>=3)
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
