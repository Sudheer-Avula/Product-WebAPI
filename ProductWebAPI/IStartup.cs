using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWebAPI
{
    public interface IStartup
    {
        /// <summary>
        /// Environment
        /// </summary>
        IHostingEnvironment Environment { get; }
        /// <summary>
        /// 
        /// </summary>
        IConfigurationRoot Configuration { get; }


        /// <summary>
        /// ConfigureServices
        /// </summary>
        /// <param name="services"></param>
        void ConfigureServices(IServiceCollection services);

        /// <summary>
        /// Configure
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="memoryCache"></param>
        /// <param name="introspectionBackChannel"></param>
        void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
            IServiceProvider serviceProvider, IMemoryCache memoryCache);
    }
}
