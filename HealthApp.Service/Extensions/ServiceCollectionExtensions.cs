using HealthApp.Service.Mapping;
using HealthApp.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HealthApp.Storage.Repositories;
using System.Reflection;
using MediatR;

namespace HealthApp.Service.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHealthAppServices(this IServiceCollection serviceCollection)
        {
           
            serviceCollection.AddDbContext<HealthAppDbContext, HealthAppDbContext>();
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();


            serviceCollection.AddSingleton(mapper);

            serviceCollection.AddTransient<IHealthDataRepository, HealthDataRepository>();
            serviceCollection.AddTransient<IHealthReportRepository, HealthReportRepository>();
            serviceCollection.AddTransient<IMonitoringDeviceRepository, MonitoringDeviceRepository>();
            serviceCollection.AddTransient<IUserRepository, UserRepository>();



            return serviceCollection;

            
        }
    }
}
