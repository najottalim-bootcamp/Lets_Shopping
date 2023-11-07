using LetsShopping.DataAccess.Repositories.AddressRepositories;
using LetsShopping.DataAccess.Repositories.CardsRepositories;
using LetsShopping.DataAccess.Repositories.CategoryRepository;
using LetsShopping.DataAccess.Repositories.CompanyRepository;
using LetsShopping.Service.Services.Order;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderInterface,OrderService>();
builder.Services.AddScoped<IOrderListRepository, OrderListRepository>();



builder.Services.AddScoped<ICardRepisotry, CardRepository>();
builder.Services.AddScoped<ICatogoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderListRepository, OrderListRepository>();

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();



builder.Services.AddScoped<IOrderInterface, OrderService>();



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
