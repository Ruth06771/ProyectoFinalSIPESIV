using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Datos.Repository;
using ProyectoFinal.Negocio.Interfaces;
using ProyectoFinal.Negocio.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();
//Base de datos
builder.Services.AddScoped<ProyectoFinalDatabase>();
// Repositorios
builder.Services.AddScoped<ITblPersonaRepository, TblPersonaRepository>();
// Servicios
builder.Services.AddScoped<ITblPersonaService, TblPersonaService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapScalarApiReference();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
