using TFU5.Data;
using TFU5.Domain;
using TFU5.Domain.Competencia;
using TFU5.Infra;

var builder = WebApplication.CreateBuilder(args);

var atletasRepository = new AtletaMemRepository();
var competenciaRepository = new CompetenciaMemRepository();

var pt = new PuntuacionTiempo();
var natacion = new Disciplina("Natación", [pt]);

var ab = new AtletaBuilder
{
    Nombre = "Juan",
    Apellido = "Cabrera",
    Genero = Genero.Masculino,
    Pais = Pais.Uruguay,
    FechaDeNacimiento = new DateOnly(1991, 3, 27),
    Disciplinas = [natacion],
};

var at1 = ab.Build();

atletasRepository.Save(at1);

var j = new Juez("JJ", "AA", [natacion]);

var comp = new CompetenciaIndividual(
    natacion, 
    new Categoria(Genero.Masculino, CategoriaEdad.Mayor, CategoriaPeso.Cualquiera),
    new DateOnly(2024, 6, 19),
    [at1],
    [j]
);

competenciaRepository.Save(comp);

builder.Services.AddSingleton<IAtletaRepository>(atletasRepository);
builder.Services.AddSingleton<ICompetenciaRepository>(competenciaRepository);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
