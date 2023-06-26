using ProductService.Application.Queries.GetStoreList;
using ProductService.Database;
using ProductService.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGetFlavourListQuery, GetFlavourListQuery>();
builder.Services.AddScoped<IFlavourRepository, FlavourRepository>();
builder.Services.AddScoped<IGetToppingListQuery, GetToppingListQuery>();
builder.Services.AddScoped<IToppingRepository, ToppingRepository>();
builder.Services.AddScoped<IGetIceListQuery, GetIceListQuery>();
builder.Services.AddScoped<IIceRepository, IceRepository>();
builder.Services.AddScoped<IProductDB, MockProductDB>();

// Add services to the container.

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
