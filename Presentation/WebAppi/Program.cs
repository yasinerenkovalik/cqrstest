using Microsoft.Extensions.DependencyInjection;
using Persistance;  // Persistence katmanı için gerekli using
using Microsoft.EntityFrameworkCore;
using Domain;
using Applicatino;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddApplicationService();


builder.Services.AddPersistanceService();
builder.Services.AddDomainService();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
   
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); 
app.UseAuthorization();     

app.MapControllers();      
app.Run();                 
