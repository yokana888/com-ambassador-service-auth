using Com.Ag.Service.Auth.Lib.Models;
using Com.Ag.Service.Auth.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ag.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IRoleService : IBaseService<Role>
    {
        bool CheckDuplicate(int id, string code);
    }
}
