using Microsoft.AspNetCore.Builder;
using RestaurantFinder.Business.Abstract;
using RestaurantFinder.Business.Concrete;
using RestaurantFinder.DataAccess.Abstract;
using RestaurantFinder.DataAccess.Concrete;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<IRestaurantService, RestaurantManager>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Restaurant Finder API",
        Version = "v1"
    });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c =>      
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Restaurant Finder API v1");
        c.RoutePrefix = string.Empty; 
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwaggerUi();

app.MapControllers();

app.Run();
