using AvaliaçãoTecnobyte.Context;
using AvaliaçãoTecnobyte.Integrations.Interfaces;
using AvaliaçãoTecnobyte.Integrations;
using AvaliaçãoTecnobyte.Repositories;
using AvaliaçãoTecnobyte.Repositories.Interfaces;
using AvaliaçãoTecnobyte.Services;
using AvaliaçãoTecnobyte.Services.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte
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
            services.AddDbContext<ContextSystem>((options) => options.UseNpgsql(Configuration.GetConnectionString("Connection")));

            services.AddSwaggerGen();

            services.AddTransient<IRepositoryPeople, RepositoryPeople>();
            services.AddTransient<IServicePeople, ServicePeople>();
            services.AddTransient<IIntegrationServicoDados, IntegrationServicoDados>();
            services.AddTransient<IServiceDistrictUf, ServiceDistrictUf>();

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

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tecnobyte Avaliação"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
