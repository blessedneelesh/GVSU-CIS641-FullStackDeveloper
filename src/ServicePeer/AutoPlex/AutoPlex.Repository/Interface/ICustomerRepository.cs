using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPlex.Repository.Interface
{
    public interface ICustomerRepository
    {
        Task<PagedList<CustomerResponseDto>> GetAllCustomers(CustomerParameters customerParameters);
    }
}
