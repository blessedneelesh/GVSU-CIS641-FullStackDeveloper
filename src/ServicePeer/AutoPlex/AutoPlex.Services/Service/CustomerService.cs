using AutoPlex.Services.Abstractions.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Interface;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Services.Service
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<PagedList<CustomerResponseDto>> GetAllCustomers(CustomerParameters customerParameters)
        {
            return _customerRepository.GetAllCustomers(customerParameters);
        }

        public Task<CustomerResponseDto?> GetCustomerById(long id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public Task<CustomerResponseDto> AddCustomer(CustomerCreateDto customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public Task<CustomerResponseDto?> UpdateCustomer(long id, CustomerUpdateDto customer)
        {
            return _customerRepository.UpdateCustomer(id, customer);
        }

        public Task<bool> DeleteCustomer(long id)
        {
            return _customerRepository.DeleteCustomer(id);
        }
    }
}
