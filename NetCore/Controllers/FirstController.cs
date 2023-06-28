using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;
using NetCore.Filter;

namespace NetCore.Controllers
{
    public class FirstController : Controller
    {
        
        private readonly ILogger<FirstController> _ILogger;
        public FirstController(ILogger<FirstController> logger)
        {
            _ILogger = logger;
        }
        [ResourceFilterAttribute]
        public IActionResult Index()
        {
            //this._ILogger.LogInformation("123456789");
            //if (string.IsNullOrEmpty(this.HttpContext.Session.GetString("Test"))){
            //    this.HttpContext.Session.SetString("Test", "success");
            //}
            int s = 1;
            int i = 2;
            int l = s + i;
            int g = l - l;
            int m=i/g;

            
            return View();
        }
    }
}