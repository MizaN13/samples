using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//using Data.Repository.Common;
//using Data.Repository.Container;
//using Data.Repository.Container.Interfaces;

namespace TheSharpFactory.Services.Unified
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
            => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
            //Database.RegisterModelConnectionString(
            //    RepoLookup.ModelId.WWI,
            //    Configuration.GetConnectionString("WWIConnectionString")
            //);

            //services.AddSingleton<IRepositoryContainer, RepositoryContainer>();
            => _ = services.AddControllers();

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
