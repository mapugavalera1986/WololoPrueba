using WololoPrueba.DbContexts;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.Repositories;
using WololoPrueba.Services;
using WololoPrueba.Excepciones;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

//Configurar Entity Framework y la conexi�n con SQL Server
var conectarDb = builder.Configuration.GetConnectionString("MarioAguDB");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conectarDb));


builder.Services.AddScoped<ICivRepository, CivService>();
builder.Services.AddScoped<IColegioRepository, ColegioService>();
builder.Services.AddScoped<IParticipanteRepository, ParticipanteService>();
builder.Services.AddScoped<IEnsayoRepository, EnsayoService>();
builder.Services.AddScoped<IPremioRepository, PremioService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware(typeof(AManejarExcepciones));

app.MapControllers();

app.Run();
