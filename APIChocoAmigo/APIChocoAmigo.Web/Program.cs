using APIChocoAmigo.Repository.EntityFramework.Configurations;
using APIChocoAmigo.Repository.EntityFramework;
using APIChocoAmigo.Repository.Interface;
using APIChocoAmigo.Repository.Repositories;
using APIChocoAmigo.Service.AutoMapper;
using APIChocoAmigo.Service.Interfaces;
using APIChocoAmigo.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true; // Configura os URLs para serem min�sculos
});

var y = builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

// Configurando o DbContext com o provedor de banco de dados (por exemplo, SQL Server)
builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddScoped<IGrupoRepository, GrupoRepository>();
builder.Services.AddScoped<IGrupoService, GrupoService>();

builder.Services.AddScoped<IParticipanteGrupoRepository, ParticipanteGrupoRepository>();
builder.Services.AddScoped<IParticipanteGrupoService, ParticipanteGrupoService>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin(); // Permitir solicita��es de qualquer origem
    options.AllowAnyMethod(); // Permitir solicita��es de qualquer m�todo (GET, POST, etc.)
    options.AllowAnyHeader(); // Permitir qualquer cabe�alho na solicita��o
});

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
