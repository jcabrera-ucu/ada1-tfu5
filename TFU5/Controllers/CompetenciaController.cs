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

    private readonly ICompetenciaRepository _competenciaRepository;

    private readonly IAtletaRepository _atletaRepository;

    public CompetenciaController(ILogger<CompetenciaController> logger,
                                 ICompetenciaRepository competenciaRepository,
                                 IAtletaRepository atletaRepository)
    {
        _logger = logger;
        _competenciaRepository = competenciaRepository;
        _atletaRepository = atletaRepository;
    }

    [HttpGet()]
    [Route("Individuales")]
    public IEnumerable<CompetenciaIndividualDto> ListIndividuales()
    {
        var p = _competenciaRepository.ListIndividuales();
        return p.Select(x => new CompetenciaIndividualDto(x)).ToList();
    }

    [HttpGet()]
    [Route("Equipos")]
    public IEnumerable<CompetenciaEquipo> ListEquipos()
    {
        return _competenciaRepository.ListEquipos();
    }

    [HttpPost()]
    [Route("Individual/Puntuar")]
    public bool PuntuarIndividual(PuntuarCompetenciaIndividualDto puntuar)
    {
        var competencia = _competenciaRepository.GetIndividual(puntuar.IdCompetencia);

        if (competencia == null)
        {
            Console.WriteLine($"COMPETENCIA NULL");
            return false;
        }

        var juez = competencia.Jueces.Find(x => x.Id == puntuar.IdJuez);

        if (juez == null)
        {
            Console.WriteLine($"JUEZ NULL");
            return false;
        }

        var atleta = _atletaRepository.Get(puntuar.IdAtleta);

        if (atleta == null)
        {
            Console.WriteLine($"ATLETA NULL");
            return false;
        }

        var puntuacion = new PuntuacionIndividual(competencia, atleta);

        foreach (var puntuacionDto in puntuar.Puntuaciones)
        {
            if (puntuacionDto.Tiempo != null)
            {
                puntuacion.Add(new PuntuacionTiempo(puntuacionDto.Tiempo.Segundos));
            }

            if (puntuacionDto.Distancia != null)
            {
                puntuacion.Add(new PuntuacionTiempo(puntuacionDto.Distancia.Metros));
            }
        }

        competencia.AgregarPuntuacion(puntuacion);

        _competenciaRepository.Save(competencia);

        return true;
    }
}
