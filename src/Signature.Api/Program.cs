using Microsoft.AspNetCore.Mvc;
using Signature.Shared;
using static Signature.Shared.SignatureResult;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => opt.AddPolicy("*", policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().Build()));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("*");

app.UseHttpsRedirection();

app.MapPost("api/signature", ([FromBody] SignatureResult result) =>
{
    // todo regra de negocio
    return Results.Ok();
})
.WithOpenApi();

app.Run();

