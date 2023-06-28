using Dapper.Contrib.Extensions;
using Entitnies;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlConnect
{
   public class DapperHelperExtend<T> where T : BaseEntity
    {
        public static T GetEntity(string Id) 
        {
            return DapperHelper._dbConnection.Get<T>(Id);
            
        }

        public static long InsertEntity(T t)
        {
            return DapperHelper._dbConnection.Insert<T>(t);

        }
    }
}
