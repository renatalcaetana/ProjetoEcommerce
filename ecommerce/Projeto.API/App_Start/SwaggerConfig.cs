using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using System.Collections.Generic;
using Swagger.Net.Application;
using Swagger.Net;



using System.Net.Http;

namespace Projeto.API
{
    public class SwaggerConfig
    {

        //public static void Register()
        //{
        //    var thisAssembly = typeof(SwaggerConfig).Assembly;
        //    GlobalConfiguration.Configuration
        //        .EnableSwagger(c =>
        //        {
        //            c.SingleApiVersion("v1", "ECommerce");
        //            c.IncludeXmlComments(GetXmlCommentsPath());
        //        })
        //        .EnableSwaggerUi(c =>
        //        {
        //        });
        //}
        //protected static string GetXmlCommentsPath()
        //{
        //    return System.String.Format(@"{0}\bin\swagger.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        //}

        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.Schemes(new[] { "http", "https" });
                    c.SingleApiVersion("v1", "API de vendas para o e-commerce da Big Corp S/A");
                    c.AccessControlAllowOrigin("*");
                    c.IncludeXmlComments($"{AppDomain.CurrentDomain.BaseDirectory}\\bin\\swagger.XML");
                    c.OperationFilter<SwaggerFilter>();
                    c.DescribeAllEnumsAsStrings();
                    c.RootUrl(ResolveBasePath);
                })
                 .EnableSwaggerUi(c =>
                 {
                     c.DocumentTitle("ECommerce");
                     c.CssTheme("theme-muted-css");
                     c.DisableValidator();
                 });
        }

        private static string ResolveBasePath(HttpRequestMessage message)
        {
            var virtualPathRoot = message.GetRequestContext().VirtualPathRoot;
            var schemeAndHost = $"{message.RequestUri.Scheme}://" + message.RequestUri.Authority;
            var uri = new Uri(new Uri(schemeAndHost, UriKind.Absolute), virtualPathRoot);

            return uri.AbsoluteUri;
        }

        private class SwaggerFilter : IOperationFilter
        {
            public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
            {
                var toBeAuthorize = apiDescription.GetControllerAndActionAttributes<AuthorizeAttribute>().Any();

                if (toBeAuthorize)
                {
                    if (operation.parameters == null)
                        operation.parameters = new List<Parameter>();

                    operation.parameters.Add(new Parameter()
                    {
                        name = "Authorization",
                        @in = "header",
                        description = "Informe o token",
                        required = true,
                        type = "string",
                        @default = "bearer "
                    });
                }
            }
        }
    }

}
