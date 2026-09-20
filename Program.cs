using Finance_app.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Scalar.AspNetCore;
using Finance_app.Interfaces;
using Finance_app.Repositary;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IStockRepository, StockRepositary>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();


namespace Finance_app
{
    public static class OpenApiExtensions
    {
        public static WebApplication MapScalarApiReference(this WebApplication app)
        {
            // TODO: implement actual mapping if needed
            return app;
        }
    }
}
