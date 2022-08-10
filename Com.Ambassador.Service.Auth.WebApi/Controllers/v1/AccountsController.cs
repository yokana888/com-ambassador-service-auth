using AutoMapper;
using Com.Ambassador.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.Ambassador.Service.Auth.Lib.Models;
using Com.Ambassador.Service.Auth.Lib.Services.IdentityService;
using Com.Ambassador.Service.Auth.Lib.Services.ValidateService;
using Com.Ambassador.Service.Auth.Lib.ViewModels;
using Com.Ambassador.Service.Auth.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Auth.WebApi.Controllers.v1
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/accounts")]
    [Authorize]
    public class AccountsController : BaseController<Account, AccountViewModel, IAccountService>
    {

        public AccountsController(IIdentityService identityService, IValidateService validateService, IAccountService service, IMapper mapper) : base(identityService, validateService, service, mapper, "1.0.0")
        {

        }
    }
}
