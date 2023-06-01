using Dapper;
using Microsoft.Data.SqlClient;
using ProductManagement.Infrastructure.IRepository;
using System.Data;

namespace ProductManagement.Infrastructure.Repository
{
    public class DapperServices : IDapperServices
    {

          private readonly IConfiguration _config;

        private string Connectionstring = "DefaultConnection";

        public DapperServices(IConfiguration config)
        {
            _config = config;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int ExecuteScaler<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));

            return db.Execute(sp, parms, commandType: commandType);
        }

        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));

            return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));

            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }
    }
}
