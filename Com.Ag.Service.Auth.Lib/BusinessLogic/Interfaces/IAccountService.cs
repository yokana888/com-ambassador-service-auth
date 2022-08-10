using Com.Ag.Service.Auth.Lib.Models;
using Com.Ag.Service.Auth.Lib.Utilities.BaseInterface;
using Com.Ag.Service.Auth.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ag.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IAccountService : IBaseService<Account>
    {
        Task<Account> Authenticate(string username, string password);

        bool CheckDuplicate(int id, string username);
    }
}
