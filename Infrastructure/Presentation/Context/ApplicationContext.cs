using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistance.Context;

public class ApplicationContext:DbContext
{
     /*private readonly IConfiguration _configuration;
        public ApplicationContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        */
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      //  var connetionString=_configuration.GetConnectionString("PostgreSql");
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=admin;Password=adminpass;Database=yasindb");
    }
    public DbSet<Product>Products{get;set;}
    public DbSet<User> Users{get;set;}

}
