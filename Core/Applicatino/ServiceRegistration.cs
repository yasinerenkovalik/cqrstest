using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Applicatino;

public static class ServiceRegistration
{
 public static void AddApplicationService(this IServiceCollection serviceCollection)
{
    
    var assembly = Assembly.GetExecutingAssembly(); // Eğer başka assembly'ler varsa, onları da eklemeyi unutmayın
    serviceCollection.AddAutoMapper(assembly);
    serviceCollection.AddMediatR(assembly);
}



} 
