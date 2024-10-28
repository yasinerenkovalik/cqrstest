using System;
using Applicatino.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using Persistance.Repositories;

namespace Persistance;

public static class ServiceRegistration
{
    
   public static void AddPersistanceService(this IServiceCollection serviceCollection){
    serviceCollection.AddDbContext<ApplicationContext>();
    serviceCollection.AddScoped<IProductRepository,ProductRepository>();
   
        
    }

}
