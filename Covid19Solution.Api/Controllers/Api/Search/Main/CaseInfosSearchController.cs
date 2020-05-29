using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Security;
using RxWeb.Core.Data;
using Covid19Solution.Models.ViewModels;
using Covid19Solution.BoundedContext.SqlContext;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;
using Newtonsoft.Json;
using System;
using Covid19Solution.Models.Main;

namespace Covid19Solution.Api.Controllers.CaseInfoModule
{
    [ApiController]
	[Route("api/[controller]")]
    [AllowAnonymous]
    public class SearchCaseInfosController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchCaseInfosController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }
      
        [HttpPost]
        public async Task<IActionResult> Post(SearchModel searchParams)
        {
            var spParameters = new SqlParameter[4];
            spParameters[0] = new SqlParameter() { ParameterName = "Query", Value = searchParams.SearchQuery };
            spParameters[1] = new SqlParameter() { ParameterName = "Serch", Value = ' ' };
            spParameters[2] = new SqlParameter() { ParameterName = "PageIndex", Value = searchParams.PageIndex };
            spParameters[3] = new SqlParameter() { ParameterName = "PageRow", Value = searchParams.PageRow };
            var storeProcSearchResult = await DbContextManager.StoreProc<DataResult>("dbo.spSearchCaseInfos", spParameters);
           // return Ok(storeProcSearchResult);
            return Ok(storeProcSearchResult.FirstOrDefault()?.Result);
        }


    }
}
