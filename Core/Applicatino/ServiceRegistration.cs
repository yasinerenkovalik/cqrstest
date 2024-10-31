
using System.Reflection;
using Applicatino.Mapping;
using Microsoft.Extensions.DependencyInjection;


namespace Applicatino{

public static class ServiceRegistration
{
 public static void AddApplicationService(this IServiceCollection serviceCollection)
{
    
    var assembly = Assembly.GetExecutingAssembly(); // Eğer başka assembly'ler varsa, onları da eklemeyi unutmayın
  serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
   serviceCollection.AddAutoMapper(typeof(GenerealMapping));
  
}



} 
}
