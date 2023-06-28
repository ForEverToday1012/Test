using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.Common;
using Entitnies;

namespace SqlConnect
{
    public class DapperHelper
    {
        public static string SqlConnecting = "Data Source=localhost;Database=Gaia_MYGL;User ID=sa;Password=iwehave2305!";
        public static IDbConnection _dbConnection = new SqlConnection();

        public DapperHelper()
        {
            _dbConnection.ConnectionString = SqlConnecting;
        }
        

        public T QureyFirst<T>(string sql, object param)
        {
            //查询
            //using (IDbConnection Connection = new SqlConnection("Server=LAPTOP-QDDHF04P: Database - ZhaoXiDataBaseInit:Trusted. .Connection = True:"))
            return _dbConnection.QueryFirst<T>(sql,param);



        }

        public long Insert<T>(T Entity) where T: BaseUserEntity
        {
            return DapperHelperExtend<BaseUserEntity>.InsertEntity(Entity);
           
        }
    }
}
