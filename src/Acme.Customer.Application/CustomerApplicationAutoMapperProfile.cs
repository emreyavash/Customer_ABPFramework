﻿using Acme.Customer.Abstract;
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
        CreateMap<CustomerPaymentInfo, CustomerPaymentInfoDTO>();
        CreateMap<CreateUpdateCustomerPaymentDTO, CustomerPayment>();
        CreateMap<CreateUpdateCustomerPaymentInfoDTO, CustomerPaymentInfo>();

        CreateMap<CustomerAddress, CustomerAddressDTO>();
        CreateMap<AddressType, AddressTypeDTO>();
        CreateMap<CreateUpdateCustomerAddressDTO, CustomerAddress>();
        CreateMap<CreateUpdateAddressTypeDTO, AddressType>();

        CreateMap<CustomerPhoneNumber, CustomerPhoneNumberDTO>();
        CreateMap<PhoneType, PhoneTypeDTO>();
        CreateMap<CreateUpdateCustomerPhoneNumberDTO, CustomerPhoneNumber>();
        CreateMap<CreateUpdatePhoneTypeDTO, PhoneType>();

        CreateMap<Customers,CustomerDTO>();
        CreateMap<CreateUpdateCustomerDTO, Customers>();

        CreateMap<CustomerEmail,CustomerEmailDTO>();
        CreateMap<EmailType, EmailTypeDTO>();
        CreateMap<CreateUpdateCustomerEmailDTO, CustomerEmail>();
        CreateMap<CreateUpdateEmailTypeDTO,EmailType>();

        CreateMap<IDenemeService, DenemeService>();
        CreateMap<Deneme, DenemeDTO>();
        CreateMap<CreateDenemeDTO, Deneme>();
        

    }
}
