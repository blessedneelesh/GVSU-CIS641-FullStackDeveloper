using AutoPlex.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AutoPlex.Repository.Models.Dto;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace AutoPlex.Repository.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly IRepositoryContext _repositoryContext;

        public CustomerRepository(IRepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task<List<CustomerResponseDto>> GetAllCustomers()
        {
            using IDbConnection connection = _repositoryContext.GetDatabaseConnection();

            string sql = @"SELECT * FROM customer";
            var customers = await connection.QueryAsync<CustomerResponseDto>(sql); // Dapper extension method

            return customers.ToList();
        }
    }
}
