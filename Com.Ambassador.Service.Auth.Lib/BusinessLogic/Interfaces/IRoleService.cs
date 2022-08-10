using Com.Ambassador.Service.Auth.Lib.Models;
using Com.Ambassador.Service.Auth.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IRoleService : IBaseService<Role>
    {
        bool CheckDuplicate(int id, string code);
    }
}
