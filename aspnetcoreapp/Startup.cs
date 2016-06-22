using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace aspnetcoreapp
{
     public class Startup
     {
          public void Configure(IApplicationBuilder app)
          {
               app.Run(context =>
               {
                    return context.Response.WriteAsync("Hello From ASP.NET Core");
               });
          }
     }
}