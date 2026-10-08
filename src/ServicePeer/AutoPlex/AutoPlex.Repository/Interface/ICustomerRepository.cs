using AutoPlex.Repository.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPlex.Repository.Interface
{
    public interface ICustomerRepository
    {
        Task<List<CustomerResponseDto>> GetAllCustomers();
    }
}
