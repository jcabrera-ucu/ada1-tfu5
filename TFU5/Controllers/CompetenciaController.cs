using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TFU5.Data;
using TFU5.Domain;
using TFU5.Domain.Competencia;

namespace TFU5.Controllers;

[ApiController]
[Route("[controller]")]
public class CompetenciaController : ControllerBase
{
    private readonly ILogger<CompetenciaController> _logger;

    private readonly ICompetenciaRepository _repository;

    public CompetenciaController(ILogger<CompetenciaController> logger,
                                 ICompetenciaRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet()]
    [Route("Individuales")]
    public IEnumerable<CompetenciaIndividualDto> ListIndividuales()
    {
        var p = _repository.ListIndividuales();
        return p.Select(x => new CompetenciaIndividualDto(x)).ToList();
    }

    [HttpGet()]
    [Route("Equipos")]
    public IEnumerable<CompetenciaEquipo> ListEquipos()
    {
        return _repository.ListEquipos();
    }

    [HttpPost()]
    [Route("Individual/Puntuar")]
    public bool PuntuarIndividual()
    {
        return true;
    }
}
