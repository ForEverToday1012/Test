using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;
using NetCore.Filter;
using NetCore.Models;

namespace NetCore.Controllers
{
    public class SecondController : Controller
    {
        private readonly ILogger<SecondController> _ILogger;
        private delegate void MyDelefate<T>(T Reft);
        public SecondController(ILogger<SecondController> logger)
        {
            _ILogger = logger;
        }
       // [ResourceFilterAttribute]
        public IActionResult Index()
        {
            //this._ILogger.LogInformation("123456789");
            //if (string.IsNullOrEmpty(this.HttpContext.Session.GetString("Test"))){
            //    this.HttpContext.Session.SetString("Test", "success");
            ////}
            //Student student = new Student() {
            //    id = 1,
            //    name="wangbo",
            //    age=23,
            //    sex="男"
            //};


            //MyDelefate<Student> mydelefate = new MyDelefate<Student>(this.Nothing);
            //mydelefate.Invoke(student);

            
            return View();
        }
      
    }
}