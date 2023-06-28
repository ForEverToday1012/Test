using System;
using System.Collections.Generic;
using System.Text;
using Entitnies;

namespace IBusiness
{
    public interface IBaseUserBLL
    {
        BaseUserEntity GetEntity(string UserId);
        long InsertEntity(BaseUserEntity baseUserEntity);
    }
}
