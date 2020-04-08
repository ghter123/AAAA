using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AAAA.Services.Api.Configurations;

namespace AAAA.Services.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // DBContextsÅäÖÃ
            services.AddDatabaseSetup(Configuration);

            // ASPNET.IdentityºÍJWTÅäÖÃ
            services.AddIdentitySetup(Configuration);

            services.AddControllers();

            // Policy¼øÈ¨ÅäÖÃ
            services.AddAuthSetup(Configuration);

            // SwaggerÅäÖÃ
            services.AddSwaggerSetup();

            // ±¾µÍÒÀÀµ×¢Èë
            services.AddDependencyInjectionSetup();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseCors(c =>
            //{
            //    c.AllowAnyHeader();
            //    c.AllowAnyMethod();
            //    c.AllowAnyOrigin();
            //});

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerSetup();
        }
    }
}
