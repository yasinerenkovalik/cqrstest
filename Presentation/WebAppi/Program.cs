using Microsoft.Extensions.DependencyInjection;
using Persistance;  // Persistence katmanı için gerekli using
using Microsoft.EntityFrameworkCore;
using Domain;
using Applicatino;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();



builder.Services.AddPersistanceService();
builder.Services.AddDomainService();
builder.Services.AddApplicationService();


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
