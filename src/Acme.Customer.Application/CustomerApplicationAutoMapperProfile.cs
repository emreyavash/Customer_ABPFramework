using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using Acme.Customer.Entities;
using AutoMapper;

namespace Acme.Customer;

public class CustomerApplicationAutoMapperProfile : Profile
{
    public CustomerApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Customers,CustomerDTO>();
        CreateMap<CustomerEmail,CustomerEmailDTO>();
        CreateMap<CustomerPayment,CustomerPaymentDTO>();
        CreateMap<CustomerPaymentInfo,CustomerPaymentInfoDTO>();
        CreateMap<CustomerPhoneNumber,CustomerPhoneNumberDTO>();
        CreateMap<EmailType,EmailTypeDTO>();
        CreateMap<PhoneType, PhoneTypeDTO>();
        CreateMap<CreateUpdateCustomerDTO, Customers>();

    }
}
