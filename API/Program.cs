using BLL.Services;
using DAL.Entities.Context;
using DAL.Entities.Models;
using DAL.Repo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//BLL
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<CategoryService>();
//builder.Services.AddScoped<ProductRepo>();
builder.Services.AddScoped(typeof(Repository<>));
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<CartItemService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<OrderItemService>();
builder.Services.AddScoped<PaymentService>();

//DAL
//builder.Services.AddScoped<UserRepo>();

builder.Services.AddDbContext<SmsContext>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
