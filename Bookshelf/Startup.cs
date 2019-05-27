using Bookshelf.Data;
using Bookshelf.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace Bookshelf
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private Container container = new Container();

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            _configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore().AddJsonFormatters();

            services.AddDbContext<BookshelfDbContext>(builder => builder.UseSqlServer(_configuration.GetConnectionString("bookshelf-sqlserver")));

            services.AddSimpleInjector(container, options =>
            {
                options.AddAspNetCore().AddControllerActivation();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSimpleInjector(container);
            InitializeContainer();
            container.Verify();

            app.UseMvc();
        }

        private void InitializeContainer()
        {
            container.Register<BookService>(Lifestyle.Scoped);
        }
    }
}
