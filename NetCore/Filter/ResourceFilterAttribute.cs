using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Filter
{
    public class ResourceFilterAttribute :ExceptionFilterAttribute
    {
        /// <summary>
        /// 控制器注册，方法注册，全局注册（在startup的ConfigureServices方法里面全局注册，全局注册可以直接依赖注入，除全局注册外，还有servicefilter（传递一个type）、typefilter、IfilterFactory方式，，前边俩种需要在startup里面添加瞬时注册）；，还有resource，action，result三个过滤器，都是先ting后ed   
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)//如果这个异常没有被处理
            {
                Console.WriteLine($"{context.HttpContext.Request.Path}");
                Console.WriteLine($"{context.HttpContext.Request.Path}fjosjfosjfosfofosf");
                context.Result = new JsonResult(new
                {
                    Result = "出现错误"
                });
                context.ExceptionHandled = true;

            }
        }
    }
}
