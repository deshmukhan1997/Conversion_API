
using ConversionAPI.Application.Interfaces;
using ConversionAPI.Application.Services;
using ConversionAPI.Infrastructure.Providers;


var builder = WebApplication.CreateBuilder(args);

// Register application services
builder.Services.AddScoped<
    IUnitConversionService, UnitConversionService>();

// Register conversion providers
builder.Services.AddSingleton<
    IUnitConversionProvider, LengthConversionProvider>();

builder.Services.AddSingleton<
    IUnitConversionProvider, WeightConversionProvider>();

builder.Services.AddSingleton<
    IUnitConversionProvider, TemperatureConversionProvider>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
