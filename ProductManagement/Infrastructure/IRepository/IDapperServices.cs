using Dapper;
using System.Data;

namespace ProductManagement.Infrastructure.IRepository
{
    public interface IDapperServices:IDisposable
    {
        T Get<T>(string sp, DynamicParameters parms, 
            CommandType commandType = CommandType.StoredProcedure);
       List<T> GetAll<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);

        int ExecuteScaler<T>(string sp, DynamicParameters parms,
           CommandType commandType = CommandType.StoredProcedure);
    }
}
