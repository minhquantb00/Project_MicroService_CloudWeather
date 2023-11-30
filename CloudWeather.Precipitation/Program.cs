using CloudWeather.Precipitation.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
app.MapGet("/observation/{zip}", async (string zip, [FromQuery] int? days, PrecipDbContext db) =>
{
    if(days == null || days <1 || days > 30)
    {
        return Results.BadRequest("Please provide a 'days' query between 1 and 30");
    }
    var startData = DateTime.Now - TimeSpan.FromDays(days.Value);
    var result = await db.Precipitations.Where(x => x.ZipCode == zip && x.CreateOn > startData).ToListAsync();
    return Results.Ok(result);
});

app.Run();
