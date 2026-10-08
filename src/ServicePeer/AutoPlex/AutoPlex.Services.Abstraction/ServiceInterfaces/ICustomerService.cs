using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Dto;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerResponseDto>> GetAllCustomers();
    }
}
