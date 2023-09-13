using Inventory.BAL.Services;
using Inventory.DAL.Data;
using Inventory.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("postgresqlconnection");
builder.Services.AddControllers();
builder.Services.AddDbContext<InventoryDbcontext>(options=>options.UseNpgsql(connection));
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<ProductService,ProductService>();
builder.Services.AddScoped<ICustomerRepo,CustomerRepository>();
builder.Services.AddScoped<CustomerService,CustomerService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
