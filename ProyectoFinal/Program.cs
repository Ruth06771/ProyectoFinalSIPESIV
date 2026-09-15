using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Datos.Repository;
using ProyectoFinal.Negocio.Interfaces;
using ProyectoFinal.Negocio.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

//Base de datos
builder.Services.AddScoped<ProyectoFinalDatabase>();
// Repositorios
builder.Services.AddScoped<ITblPersonaRepository, TblPersonaRepository>();
builder.Services.AddScoped<ItblInstitucionRepository, TblInstitucionRepository>();
builder.Services.AddScoped<ITblUnidadOrganizativaRepository, TblUnidadOrganizativaRepository>();
builder.Services.AddScoped<ITblAsignaturaRepository, TblAsignaturaRepository>();
builder.Services.AddScoped<ITblAreaRepository, TblAreaRepository>();
builder.Services.AddScoped<ITblParametroRepository, TblParametroRepository>();
builder.Services.AddScoped<ITblSubParametroRepository, TblSubParametroRepository>();
builder.Services.AddScoped<ITblRolRepository, TblRolRepository>();
builder.Services.AddScoped<ITblProgramRepository, TblProgramRepository>();
builder.Services.AddScoped<ITblPermisosRepository, TblPermisosRepository>();
builder.Services.AddScoped<ITblUsuarioRepository, TblUsuarioRepository>();
// Servicios
builder.Services.AddScoped<ITblPersonaService, TblPersonaService>();
builder.Services.AddScoped<ITblAsignaturaService, TblAsignaturaService>();
builder.Services.AddScoped<ITblAreaService, TblaAreaService>();
builder.Services.AddScoped<ITblInstitucionService, TblInstitucionService>();
builder.Services.AddScoped<ITblParametroService, TblParametroService>();
builder.Services.AddScoped<ITblSubParametroService, TblSubParametroService>();
builder.Services.AddScoped<ITblUnidadOrganizativaService, TblUnidadOrganizativaService>();
builder.Services.AddScoped<ITblRolService, TblRolService>();
builder.Services.AddScoped<ITblProgramService, TblProgramService>();
builder.Services.AddScoped<ITblPermisosService, TblPermisosService>();
builder.Services.AddScoped<ITblUsuarioService, TblUsuarioService>();


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
