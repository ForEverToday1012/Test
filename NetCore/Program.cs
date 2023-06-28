using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace NetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            //var hostbuilder = CreateWebHostBuilder(args);
            //var host = hostbuilder.Build();
            //host.Run();//准备一个web服务器运行起来

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)//创建默认builder，，完成各种配置
            .ConfigureLogging((context, loggingBuilder) => {//扩展日志
                loggingBuilder.AddFilter("System", LogLevel.Warning);
                loggingBuilder.AddFilter("Microsoft", LogLevel.Warning);
                loggingBuilder.AddLog4Net();
            })
            //.UseDefaultServiceProvider   可以用该方法注册autofac容器，，当然需要先引用nuget包
            .UseStartup<Startup>();  
    }
}
