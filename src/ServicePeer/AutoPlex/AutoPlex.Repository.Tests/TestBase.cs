using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using AutoPlex.Repository.Context;

namespace AutoPlex.Repository.Tests
{
    [ExcludeFromCodeCoverage]
    public class TestBase
    {
        public IConfiguration _config;
        public static RepositoryContext _repositoryContext;

        public TestBase()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.test.json", optional: false, reloadOnChange: true)
                .Build();

            _repositoryContext = new RepositoryContext(_config);
        }
    }
}
