using TFU5.Data;
using TFU5.Domain;
using TFU5.Infra;

var builder = WebApplication.CreateBuilder(args);

var atletasRepository = new AtletaMemRepository();

var natacion = new Disciplina("Natación", 
[
    new PuntuacionTiempo(),
]);

var ab = new AtletaBuilder
{
    Nombre = "Juan",
    Apellido = "Cabrera",
    Genero = Genero.Masculino,
    Pais = Pais.Uruguay,
    FechaDeNacimiento = new DateOnly(1991, 3, 27),
    Disciplinas = [natacion],
};

atletasRepository.Save(ab.Build());

builder.Services.AddSingleton<IAtletaRepository>(atletasRepository);

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
