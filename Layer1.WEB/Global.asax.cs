using AutoMapper;
using Layer1.WEB.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Layer1.WEB
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AutoFac
            Bootstrapper.Run();

            //AutoMapper
            Mapper.Initialize(c => c.AddProfile<MappingProfile> ());

            GlobalConfiguration.Configure(WebApiConfig.Register);
         
        }
    }
}
