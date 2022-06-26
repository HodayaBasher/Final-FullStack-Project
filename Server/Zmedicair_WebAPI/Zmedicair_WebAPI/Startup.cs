using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BLL.BLL_Interfaces;
using BLL.BLL_Classes;
using DAL;
using DAL.DAL_Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using DAL.DAL_Classes;

namespace Zmedicair_WebAPI
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
            services.AddControllers();

            //ADD Cors
            services.AddCors(p => p.AddPolicy("AlowAll", option =>
            {
                option.AllowAnyMethod();
                option.AllowAnyHeader();
                option.AllowAnyOrigin();
            }));

            //ADD Scoped
            services.AddScoped(typeof(ICommonQuestionsTableDAL), typeof(CommonQuestionsTableDAL));
            services.AddScoped(typeof(ICommonQuestionsTableBLL), typeof(CommonQuestionsTableBLL));

            services.AddScoped(typeof(IDailyMonitoringTableDAL), typeof(DailyMonitoringTableDAL));
            services.AddScoped(typeof(IDailyMonitoringTableBLL), typeof(DailyMonitoringTableBLL));

            services.AddScoped(typeof(IMachinesTableDAL), typeof(MachinesTableDAL));
            services.AddScoped(typeof(IMachinesTableBLL), typeof(MachinesTableBLL));

            services.AddScoped(typeof(IMessagesTableDAL), typeof(MessagesTableDAL));
            services.AddScoped(typeof(IMessagesTableBLL), typeof(MessagesTableBLL));

            services.AddScoped(typeof(IShoppingInformationTableDAL), typeof(ShoppingInformationTableDAL));
            services.AddScoped(typeof(IShoppingInformationTableBLL), typeof(ShoppingInformationTableBLL));

            services.AddScoped(typeof(IShoppingTableDAL), typeof(ShoppingTableDAL));
            services.AddScoped(typeof(IShoppingTableBLL), typeof(ShoppingTableBLL));

            services.AddScoped(typeof(IUsersTableDAL), typeof(UsersTableDAL));
            services.AddScoped(typeof(IUsersTableBLL), typeof(UsersTableBLL));


            //ADD DbContext
            services.AddDbContext<Zmedicair_DBContext>(p => p.UseSqlServer("Server=LAPTOP-AP8782VQ;Database=Zmedicair_DB;Trusted_Connection=True;"));
        }


    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors("AlowAll");

    app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
