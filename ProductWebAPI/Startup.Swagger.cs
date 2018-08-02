using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ProductWebAPI
{
    public partial class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationBuilder"></param>
        /// <param name="config"></param>
        public void ConfigureSwaggerServices(IApplicationBuilder applicationBuilder, IConfigurationRoot config)
        {
            applicationBuilder.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.Host = httpReq.Host.Value);
            });
            var redirects = new RewriteOptions()
                .AddRedirect("swagger/ui/index.html", "swagger");
           // applicationBuilder.UseRewriter(redirects);
           //// var routePrefix = !string.IsNullOrEmpty(config["AppSettings:Path"]) ? $"/{config["AppSettings:Path"]}/swagger" : "/swagger";
           // applicationBuilder.UseSwaggerUI(c =>
           // {
           //     c.SwaggerEndpoint($"/v1/swagger.json", "V1");
           //     //c.ConfigureOAuth2(config.GetValue<string>("IpreoAccount:SwaggerClient"), null, null, "Content Services");
           // });
        }

    }
}
