using Acme.Customer.Abstract;
using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using Acme.Customer.Entities;
using Acme.Customer.İnterface;
using AutoMapper;

namespace Acme.Customer;

public class CustomerApplicationAutoMapperProfile : Profile
{
    public CustomerApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<CustomerPayment, CustomerPaymentDTO>();
        CreateMap<CreateUpdateCustomerPaymentDTO, CustomerPayment>();

        CreateMap<CustomerPaymentInfo, CustomerPaymentInfoDTO>();
        CreateMap<CreateUpdateCustomerPaymentInfoDTO, CustomerPaymentInfo>();

        CreateMap<CustomerAddress, CustomerAddressDTO>();
        CreateMap<AddressType, AddressTypeDTO>();
        CreateMap<CreateUpdateCustomerAddressDTO, CustomerAddress>();
        CreateMap<CreateUpdateAddressTypeDTO, AddressType>();

        CreateMap<CustomerPhoneNumber, CustomerPhoneNumberDTO>();
        CreateMap<CreateUpdateCustomerPhoneNumberDTO, CustomerPhoneNumber>();

        CreateMap<PhoneType, PhoneTypeDTO>();
        CreateMap<CreateUpdatePhoneTypeDTO, PhoneType>();

        CreateMap<Customers,CustomerDTO>();
        CreateMap<CreateUpdateCustomerDTO, Customers>();

        CreateMap<CustomerEmail,CustomerEmailDTO>();
        CreateMap<CreateUpdateCustomerEmailDTO, CustomerEmail>();

        CreateMap<EmailType, EmailTypeDTO>();
        CreateMap<CreateUpdateEmailTypeDTO,EmailType>();

        

    }
}
