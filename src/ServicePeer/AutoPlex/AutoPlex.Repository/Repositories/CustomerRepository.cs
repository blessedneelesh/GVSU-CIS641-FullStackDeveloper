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

            var whereClauses = new List<string>();
            var queryParams = new DynamicParameters();

            var status = customerParameters.Status?.Trim();
            if (!string.IsNullOrWhiteSpace(status) &&
                (status.Equals("active", StringComparison.OrdinalIgnoreCase) ||
                 status.Equals("inactive", StringComparison.OrdinalIgnoreCase)))
            {
                whereClauses.Add("LOWER(status) = @Status");
                queryParams.Add("Status", status.ToLowerInvariant());
            }

            var searchTerm = customerParameters.SearchTerm?.Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                whereClauses.Add(@"(
                    LOWER(first_name) LIKE @SearchTerm OR
                    LOWER(last_name) LIKE @SearchTerm OR
                    LOWER(email) LIKE @SearchTerm OR
                    LOWER(phone) LIKE @SearchTerm
                )");
                queryParams.Add("SearchTerm", $"%{searchTerm.ToLowerInvariant()}%");
            }

            var sql = "SELECT * FROM customer";
            if (whereClauses.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", whereClauses);
            }

            var customers = (await connection.QueryAsync<CustomerResponseDto>(sql, queryParams)).ToList();

            return PagedList<CustomerResponseDto>.ToPagedList(
                customers,
                customerParameters.PageNumber,
                customerParameters.PageSize);
        }
    }
}
