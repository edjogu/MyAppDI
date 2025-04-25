using MyAppDI.Application.Services;
using MyAppDI.Domain.Interfaces;
using MyAppDI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Registro de dependencias (Inyección de dependencias)
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<CustomerService>();

// Habilita controladores
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// Swagger (Documentación OpenAPI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Mapeo automático de controladores [ApiController]
app.MapControllers();

app.Run();
