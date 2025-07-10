using RestaurantFinder.Business.Abstract;
using RestaurantFinder.Business.Concrete;
using RestaurantFinder.DataAccess.Abstract;
using RestaurantFinder.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<IRestaurantService, RestaurantManager>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
