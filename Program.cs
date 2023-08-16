using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.Configure<JsonOptions>(options =>
{
    // Never seem to come in here. 
    options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals;
});

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new{value=double.PositiveInfinity}));

app.Run();

