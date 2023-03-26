using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NoteWeb.Data;
using NoteWeb.Data.Mocks;
using NoteWeb.Data.Models;
using NoteWeb.Data.Repository;
using NoteWeb.Data.Services;

namespace NoteWeb
{
    public class Startup
    {
        private IConfigurationRoot _configurationString;

        public Startup(IWebHostEnvironment hostEnv)
        {
            _configurationString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options=> options.UseNpgsql(_configurationString.GetConnectionString("DefaultConnection")));
            services.AddTransient<INotePageRepository<NotePage>, MockNotePage>();
            services.AddTransient<INoteFileRepository<NoteFile>, MockNoteFile>();
            services.AddTransient<NotePageService, NotePageService>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
