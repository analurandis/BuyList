using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Buylist.Common.Repository.Entity;
using Buylist.CommonRepository;
using Buylist.DataAccess.Context;
using Buylist.Domain;
using Buylist.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
{
    builder.WithOrigins(
        "https://localhost:5105/swagger",
        "https://localhost:5105");
}));


builder.Services.AddSingleton<IBuyListRepository<Produto, int>>(new ProdutoRepository( new BuylistContext()));
builder.Services.AddSingleton<IBuyListRepository<Item, int>>(new ItemRepository(new BuylistContext()));
builder.Services.AddSingleton<IBuyListRepository<Local, int>>(new LocalRepository(new BuylistContext()));
builder.Services.AddSingleton<IBuyListRepository<Compra, int>>(new CompraRepository(new BuylistContext()));


var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
