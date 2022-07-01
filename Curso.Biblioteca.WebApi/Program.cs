using Curso.Biblioteca.Aplicacion.ServicioImplementacion;
using Curso.Biblioteca.Aplicacion.ServiciosAplicacion;
using Curso.Biblioteca.Dominio.IRepositorios;
using Curso.Biblioteca.Infraestructura.Context;
using Curso.Biblioteca.Infraestructura.RepositoriosImplementacion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<BibliotecaDbContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ILibroRepositorio, LibroRepositorio>();
builder.Services.AddTransient<ILibroServicio, LibroServicio>();
builder.Services.AddTransient<IAutorRepositorio, AutorRepositorio>();
builder.Services.AddTransient<IAutorServicio, AutorServicio>();
builder.Services.AddTransient<IEditorialRepositorio, EditorialRepositorio>();
builder.Services.AddTransient<IEditorialServicio, EditorialServicio>();
var app = builder.Build();

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
