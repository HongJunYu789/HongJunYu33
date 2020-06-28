using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EFEntity;
using Microsoft.Extensions.Configuration;

namespace RLZYCXSC
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //��ȡ����������ͼ
            services.AddControllersWithViews();
            //��ȡ�����ַ���
            var conStr = configuration.GetConnectionString("SqlServerConnection");
            //��ȡ�����Ĳ���
            services.AddDbContext<TextDbContent>();
        }

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //2
            app.UseStaticFiles();//���ؾ�̬�ļ������

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Test}/{action=CX}/{id?}"

                   );
            });
        }
    }
}
