using Microsoft.AspNetCore.Mvc;
using TFU5.Data;
using TFU5.Domain;

namespace TFU5.Controllers;

public class CreateAtletaSchema
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
}

[ApiController]
[Route("[controller]")]
public class AtletasController : ControllerBase
{
    private readonly ILogger<AtletasController> _logger;

    private readonly IAtletaRepository _atleta_repository;

    public AtletasController(ILogger<AtletasController> logger,
                             IAtletaRepository atleta_repository)
    {
        _logger = logger;
        _atleta_repository = atleta_repository;
    }

    [HttpGet(Name = "List")]
    public IEnumerable<AtletaDto> Get()
    {
        return _atleta_repository.List().Select(x => new AtletaDto(x)).ToList();
    }

    [HttpPost(Name = "Create")]
    public Atleta Create(CreateAtletaSchema createSchema)
    {
        var ab = new AtletaBuilder
        {
            Nombre = createSchema.Nombre,
            Apellido = createSchema.Apellido,
            Genero = Genero.Masculino,
            Pais = Pais.Uruguay,
            FechaDeNacimiento = new DateOnly(1991, 3, 27),
            Disciplinas = [new Disciplina("MIDisciplina", [])]
        };

        var atleta = ab.Build();

        _atleta_repository.Save(atleta);

        return atleta;
    }
}
