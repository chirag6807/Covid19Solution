using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Covid19Solution.UnitOfWork.Main;
using Covid19Solution.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;
using RxWeb.Core.Security.Filters;

namespace Covid19Solution.Api.Controllers.MasterModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    //[AllowAnonymousUser]
    public class CaseInfosController : BaseController<CaseInfo,CaseInfo,CaseInfo>

    {
        public CaseInfosController(IMasterUow uow):base(uow) {}

    }
}
