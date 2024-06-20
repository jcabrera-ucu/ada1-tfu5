using Microsoft.AspNetCore.Mvc;
using TFU5.Data;
using TFU5.Domain;

namespace TFU5.Controllers;

[ApiController]
[Route("[controller]")]
public class AtletasController : ControllerBase
{
    private readonly ILogger<AtletasController> _logger;

    private readonly IAtletaRepository _atleta_repository;
    private readonly IDisciplinaRepository _disciplinaRepository;

    public AtletasController(ILogger<AtletasController> logger,
                             IAtletaRepository atleta_repository,
                             IDisciplinaRepository disciplinaRepository)
    {
        _logger = logger;
        _atleta_repository = atleta_repository;
        _disciplinaRepository = disciplinaRepository;
    }

    [HttpGet(Name = "List")]
    public IEnumerable<AtletaDto> Get()
    {
        return _atleta_repository.List().Select(x => new AtletaDto(x)).ToList();
    }

    [HttpPost(Name = "Create")]
    public ActionResult<Atleta> Create(CrearAtletaDto createSchema)
    {
        List<IDisciplina> disciplinas = [];
        foreach (var nombreDisciplina in createSchema.Disciplinas)
        {
            var disciplina = _disciplinaRepository.Get(nombreDisciplina);
            if (disciplina == null)
            {
                return NotFound();
            }
            else
            {
                disciplinas.Add(disciplina);
            }
        }

        var ab = new AtletaBuilder
        {
            Nombre = createSchema.Nombre,
            Apellido = createSchema.Apellido,
            Genero = Genero.Masculino,
            Pais = Pais.Uruguay,
            FechaDeNacimiento = new DateOnly(1991, 3, 27),
            Disciplinas = disciplinas,
        };

        var atleta = ab.Build();

        _atleta_repository.Save(atleta);

        return atleta;
    }
}
