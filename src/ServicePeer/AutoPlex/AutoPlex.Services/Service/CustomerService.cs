using AutoPlex.Services.Abstractions.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Interface;
using AutoPlex.Repository.Models.Dto;

namespace AutoPlex.Services.Service
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<List<CustomerResponseDto>> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }
    }
}
