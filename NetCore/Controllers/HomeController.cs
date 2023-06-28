using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Entitnies;
using IBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore.Common;
using NetCore.Models;
using NewLife.Caching;

//using Microsoft.Extensions.Caching.Distributed;

namespace NetCore.Controllers
{
    public class HomeController : Controller
    {
        //private IDistributedCache _Cache;
        private IBaseUserBLL _baseUserBLL;
        private readonly ILogger<HomeController> _ILogger;
        public delegate void SayHi(string name);
        public HomeController(IBaseUserBLL baseUserBLL, ILogger<HomeController> logger)
        {
            _baseUserBLL = baseUserBLL;
            _ILogger = logger;
        }
        public IActionResult Index()
        {//redis应用存储
            string key = "DistributedCache";
            //string cache=_Cache.GetString(key);
            //string datetime = DateTime.Now.ToString("yyyy-MM-dd");
            //if (!string.IsNullOrEmpty(cache))
            //{

            //}
            //else
            //{
            //    _Cache.SetString(key, datetime, new DistributedCacheEntryOptions() {
            //        AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(60)
            //    });
            //}
            //ViewBag.DateTime = datetime;
            //ViewBag.cache = cache;
            Redis redis = new Redis();
            this.expression();





            //this.mydelegate("wangbo", sayhihello);//委托示例

            var user = _baseUserBLL.GetEntity("6c23bc58-a03e-47c5-9269-b46f48cf0d0f");
            BaseUserEntity baseUserEntity = new BaseUserEntity()
            {
                UserId = Guid.NewGuid().ToString(),
                RealName="wang"
            };
           string t= Reflections.isNullOrEmpty<BaseUserEntity>(baseUserEntity);
            //_baseUserBLL.InsertEntity(baseUserEntity);
            if (!string.IsNullOrEmpty(t))
            {
                user.NickName = t;
            }



            return View(user);
        }
        /// <summary>
        /// 动态拼装lamdba
        /// </summary>
        public void expression()
        {
            //Expression<Func<int,int>> exp=i=>i+10;


            //ParameterExpression parameterExpression = Expression.Parameter(typeof(int), "i");//声明参数i
            //ConstantExpression constant = Expression.Constant(10, typeof(int));//声明常量10
            //BinaryExpression binaryAdd = Expression.Add(parameterExpression,constant);//方法体拼装，加起来
            //Expression<Func<int, int>> expression = Expression.Lambda<Func<int, int>>(binaryAdd, new ParameterExpression[] { parameterExpression });//参数和方法体放一起，组成lambda
            //Func<int, int> func = expression.Compile();//编译成委托
            //int result1 = func.Invoke(23);
            //int result2 = func.Invoke(3);
            //int result3 = func.Invoke(13);


            ParameterExpression parameterExpression = Expression.Parameter(typeof(BaseUserEntity), "s");
            ConstantExpression contstant1 = Expression.Constant(1, typeof(int));
            MemberExpression Gender = Expression.Property(parameterExpression, typeof(BaseUserEntity).GetProperty("Gender"));
            BinaryExpression GenderEqual = Expression.Equal(Gender, contstant1);
            ConstantExpression contstant2 = Expression.Constant(2, typeof(int));
            MemberExpression CompanyName = Expression.Property(parameterExpression, typeof(BaseUserEntity).GetProperty("CompanyName"));
            MemberExpression CompanyNameLength = Expression.Property(CompanyName, typeof(string).GetProperty("Length"));
            BinaryExpression CompanyNameEqual = Expression.GreaterThan(CompanyNameLength, contstant2);
            ConstantExpression contstant3 = Expression.Constant("12", typeof(string));
            MemberExpression Mobile = Expression.Property(parameterExpression, typeof(BaseUserEntity).GetProperty("Mobile"));
            MethodInfo methodInfo = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
            MethodCallExpression MobileCall = Expression.Call(Mobile, methodInfo, new Expression[] { contstant3 });
            ConstantExpression contstant4 = Expression.Constant(100, typeof(int));
            MemberExpression SortCode = Expression.Property(parameterExpression, typeof(BaseUserEntity).GetProperty("SortCode"));
            BinaryExpression SortCodeEqual = Expression.GreaterThan(SortCode,contstant4);

            BinaryExpression and1 = Expression.AndAlso(SortCodeEqual, CompanyNameEqual);
            BinaryExpression and2 = Expression.AndAlso(and1, GenderEqual);
            BinaryExpression and3 = Expression.AndAlso(and2, MobileCall);

            Expression<Func<BaseUserEntity, bool>> expression =Expression.Lambda<Func<BaseUserEntity, bool>>(and3, new ParameterExpression[] { parameterExpression });

            Func<BaseUserEntity, bool> func = expression.Compile();

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void mydelegate(string name)
        {
            SayHi sayHi = new SayHi(this.sayhihello);

            _ILogger.LogWarning("say hi");
            sayHi.Invoke(name);
        }

        public void sayhihello(string name)
        {
            _ILogger.LogWarning($"say hi:{name}");
        }

         
        public IEnumerable<T> GetList<T>(List<T> s,Func<T,bool> func)
        {
            foreach (var t in s)
            {
                if(func.Invoke(t))
                yield return t;
            }
        }
    }
}
