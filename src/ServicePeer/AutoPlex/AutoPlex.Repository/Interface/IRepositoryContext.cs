using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AutoPlex.Repository.Interface
{
    public interface IRepositoryContext
    {
        IDbConnection GetDatabaseConnection();
    }
}
