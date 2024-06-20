using Microsoft.AspNetCore.Mvc;

using TFU5.Data;
using TFU5.Domain;
using TFU5.Domain.Competencia;

namespace TFU5.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly ILogger<DemoController> _logger;

    private readonly ICompetenciaRepository _competenciaRepository;
    private readonly IAtletaRepository _atletaRepository;
    private readonly IEquipoRepository _equipoRepository;
    private readonly IDisciplinaRepository _disciplinaRepository;

    public DemoController(ILogger<DemoController> logger,
                          ICompetenciaRepository competenciaRepository,
                          IAtletaRepository atletaRepository,
                          IEquipoRepository equipoRepository,
                          IDisciplinaRepository disciplinaRepository)
    {
        _logger = logger;
        _disciplinaRepository = disciplinaRepository;
        _atletaRepository = atletaRepository;
        _equipoRepository = equipoRepository;
        _competenciaRepository = competenciaRepository;
    }

    [HttpPost()]
    public void Crear()
    {
        var puntuacionTiempo = new PuntuacionTiempo();
        var puntuacionDistancia = new PuntuacionDistancia();
        var puntuacionPuntos = new PuntuacionPuntos();

        var natacion = new Disciplina("Natación", 
        [
            puntuacionTiempo,
        ]);

        var futbol = new Disciplina("Fútbol", 
        [
            puntuacionPuntos,
        ]);

        _disciplinaRepository.Save(natacion);
        _disciplinaRepository.Save(futbol);

        var atletaBuilder1 = new AtletaBuilder
        {
            Nombre = "Luís",
            Apellido = "Suárez",
            Genero = Genero.Masculino,
            Pais = Pais.Uruguay,
            FechaDeNacimiento = new DateOnly(1987, 1, 24),
            Disciplinas = [futbol],
        };

        var ls = atletaBuilder1.Build();

        _atletaRepository.Save(ls);

        var atletaBuilder2 = new AtletaBuilder
        {
            Nombre = "Lionel",
            Apellido = "Messi",
            Genero = Genero.Masculino,
            Pais = Pais.Argentina,
            FechaDeNacimiento = new DateOnly(1987, 6, 24),
            Disciplinas = [futbol],
        };

        var lm = atletaBuilder2.Build();

        _atletaRepository.Save(lm);

        var futbolUruguay = new Equipo();
        futbolUruguay.Atletas.Add(ls);

        var futbolArgentina = new Equipo();
        futbolArgentina.Atletas.Add(lm);

        _equipoRepository.Save(futbolUruguay);
        _equipoRepository.Save(futbolArgentina);

        var atletaBuidler3 = new AtletaBuilder
        {
            Nombre = "Rodrigo",
            Apellido = "Rodríguez",
            Genero = Genero.Masculino,
            Pais = Pais.Uruguay,
            FechaDeNacimiento = new DateOnly(2000, 1, 1),
            Disciplinas = [natacion],
        };

        var rodrigo = atletaBuidler3.Build();

        _atletaRepository.Save(rodrigo);


        var juezA = new Juez("Pepe", "Pérez", [natacion]);
        var juezB = new Juez("María", "Pérez", [futbol]);

        var compN = new CompetenciaIndividual(
            natacion, 
            new Categoria(
                Genero.Masculino, 
                CategoriaEdad.Mayor, 
                CategoriaPeso.Cualquiera
            ),
            new DateOnly(2024, 6, 20),
            [rodrigo],
            [juezA]
        );

        var compF = new CompetenciaEquipo(
            futbol, 
            new Categoria(
                Genero.Masculino, 
                CategoriaEdad.Mayor, 
                CategoriaPeso.Cualquiera
            ),
            new DateOnly(2024, 6, 20),
            [futbolUruguay, futbolArgentina],
            [juezB]
        );

        _competenciaRepository.Save(compN);
        _competenciaRepository.Save(compF);
    }
}
