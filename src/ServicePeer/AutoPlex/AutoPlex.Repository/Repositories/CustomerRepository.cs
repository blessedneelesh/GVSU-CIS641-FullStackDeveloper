using AutoPlex.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AutoPlex.Repository.Models.Dto;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Repository.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly IRepositoryContext _repositoryContext;

        public CustomerRepository(IRepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task<PagedList<CustomerResponseDto>> GetAllCustomers(CustomerParameters customerParameters)
        {
            using IDbConnection connection = _repositoryContext.GetDatabaseConnection();

            // Load all customers and let PagedList perform paging in memory.
            string sql = @"SELECT * FROM customer";
            var customers = (await connection.QueryAsync<CustomerResponseDto>(sql)).ToList();

            return PagedList<CustomerResponseDto>.ToPagedList(customers, customerParameters.PageNumber, customerParameters.PageSize);
        }
    }
}
