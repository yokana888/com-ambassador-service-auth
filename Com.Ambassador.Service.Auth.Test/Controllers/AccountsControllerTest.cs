using Com.Ambassador.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.Ambassador.Service.Auth.Lib.Models;
using Com.Ambassador.Service.Auth.Lib.ViewModels;
using Com.Ambassador.Service.Auth.Test.Utils;
using Com.Ambassador.Service.Auth.WebApi.Controllers.v1;

namespace Com.Ambassador.Service.Auth.Test.Controllers
{
    public class AccountsControllerTest : BaseControllerTest<AccountsController, Account, AccountViewModel, IAccountService>
    {
    }
}
