using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<PagedList<CustomerResponseDto>> GetAllCustomers(CustomerParameters customerParameters);
        Task<CustomerResponseDto?> GetCustomerById(long id);
        Task<CustomerResponseDto> AddCustomer(CustomerCreateDto customer);
        Task<CustomerResponseDto?> UpdateCustomer(long id, CustomerUpdateDto customer);
        Task<bool> DeleteCustomer(long id);
    }
}
