using TFU5.Data;
using TFU5.Domain;
using TFU5.Domain.Competencia;
using TFU5.Infra;

var builder = WebApplication.CreateBuilder(args);

var atletasRepository = new AtletaMemRepository();
var competenciaRepository = new CompetenciaMemRepository();
var equiposRepository = new EquipoMemRepository();
var disciplinasRepository = new DisciplinaMemRepository();

builder.Services.AddSingleton<IAtletaRepository>(atletasRepository);
builder.Services.AddSingleton<ICompetenciaRepository>(competenciaRepository);
builder.Services.AddSingleton<IEquipoRepository>(equiposRepository);
builder.Services.AddSingleton<IDisciplinaRepository>(disciplinasRepository);

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
