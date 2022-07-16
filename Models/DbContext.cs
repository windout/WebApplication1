using Dapper;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class DbContext:IDbContext
    {
        private readonly IDbConnection connection;

        public DbContext(IConfiguration configuration)
        {
            connection = new SqlConnection(configuration.GetValue<string>("StringConnection"));
        }
        public List<T> ReadAll<T>()
        {
            var list = connection.Query<T>("select * from Material").ToList();
            return list;
        }
    }
}
