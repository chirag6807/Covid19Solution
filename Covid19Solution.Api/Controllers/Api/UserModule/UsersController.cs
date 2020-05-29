using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Covid19Solution.Domain.UserModule;
using Covid19Solution.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Covid19Solution.Api.Controllers.UserModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class UsersController : BaseDomainController<User,User>

    {
        public UsersController(IUserDomain domain):base(domain) {
        
        }

    }
}
