using IBusiness;
using SqlConnect;
using System;
using System.Collections.Generic;
using System.Text;
using Entitnies;

namespace Business
{
    public class BaseUserBLL: IBaseUserBLL
    {
        DapperHelper _db = new DapperHelper();
        public BaseUserEntity GetEntity(string UserId)
        {
            BaseUserEntity user = _db.QureyFirst<BaseUserEntity>("select * from Base_User where UserId=@UserId",new { UserId});
            return user;
        }

        public long InsertEntity(BaseUserEntity baseUserEntity)
        {
            return _db.Insert<BaseUserEntity>(baseUserEntity);
        }

        
    }
}
