using Microsoft.EntityFrameworkCore;
using TMS.Data;
using TMS.Data.Contracts;
using TMS.Domain;
using TMS.Domain.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ITaxService, TaxService>();
builder.Services.AddScoped<ITaxRepository, TaxRepository>();
var connection = "Server=(localdb)\\MSSQLLocalDB;Database=TMS;Trusted_Connection=True";
builder.Services.AddDbContext<TMSContext>(opt => opt.UseInMemoryDatabase(connection));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
//app.UseMvc(routeBuilder => { routeBuilder.MapRoute("api_default", "{controller}/{action}/{id}")});
app.Run();
