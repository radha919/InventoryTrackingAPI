using Inventory.BAL.Services;
using Inventory.DAL.Data;
using Inventory.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using InventoryTrackingAPI.Security;
using Microsoft.AspNetCore.Authentication;
//using Amazon.OpsWorks.Model;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
var connection = builder.Configuration.GetConnectionString("postgresqlconnection");
builder.Services.AddControllers();
builder.Services.AddDbContext<InventoryDbcontext>(options=>options.UseNpgsql(connection));
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<ProductService,ProductService>();
builder.Services.AddScoped<ICustomerRepo,CustomerRepository>();
builder.Services.AddScoped<CustomerService,CustomerService>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();
builder.Services.AddScoped<OrderService, OrderService>();
builder.Services.AddScoped<IOrderLineRepository, OrderLineRepository>();
builder.Services.AddScoped<OrderLineItemService, OrderLineItemService>();
builder.Services.AddScoped<IPurchaserepo,PurchaseRepo>();
builder.Services.AddScoped<PurchaseService,PurchaseService>();
builder.Services.AddScoped<IPurchaseLineRepo,PurchaseLineRepo>();
builder.Services.AddScoped<PurchaseLineItemService,PurchaseLineItemService>();
builder.Services.AddScoped<ISalesOrderLineRepo,SalesOrderLineRepo>();
builder.Services.AddScoped<SalesOrderService,SalesOrderService>();
builder.Services.AddScoped<ISalesOrderRepo,SalesOrderRepo>();
builder.Services.AddScoped<SalesOrderService, SalesOrderService>();
builder.Services.AddScoped<ISupplierRepo,SupplierRepo>();
builder.Services.AddScoped<SupplierService, SupplierService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "Inventory API",
            Description = "Inventory Management System API",
        });
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
        {
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Description = "JWT Authorization header using the Bearer scheme."

        });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });
    });
builder.Services.AddAuthentication(auth =>
                {
                    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                    };
                });


        builder.Services.AddSingleton<IClaimsTransformation, ClaimsTransformer>();
  



 var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

