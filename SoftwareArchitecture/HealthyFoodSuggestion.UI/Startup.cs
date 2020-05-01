using System;
using HealthyFoodSuggestion.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthyFoodSuggestion.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpClient<ISuggestionService, SuggestionService>(
                client => {
                    client.BaseAddress = new Uri(
                        Configuration.GetSection("ServiceApi:Uri").Value
                    );
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJIZWFsdGh5Rm9vZFN1Z2dlc3Rpb24iLCJpYXQiOjE1ODgzNDA4NzAsImV4cCI6MTYxOTg3Njg3MCwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMS8iLCJzdWIiOiJBcHBVc2VyIiwiVXNlclR5cGUiOiJCbGF6b3IgVXNlciJ9.3SYuedMA7kjqfx9fy3iC1ZzHct-7qHGyG6wBAD_0lME");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
