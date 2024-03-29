﻿using Core6.Utilities.IoC;
using Core6.Utilities.Mail;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core6.DependencyResolves
{  public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            //  services.AddMemoryCache();
            //  services.AddSingleton<ICacheManager, MemoryCacheManager>();
            services.AddSingleton<IMailService, MailManager>();
            services.AddSingleton<IEmailConfiguration, EmailConfiguration>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        //  services.AddSingleton<Stopwatch>();
        }
    }
}
