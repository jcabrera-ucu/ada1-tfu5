using Microsoft.AspNetCore.Mvc;
using TFU5.Data;
using TFU5.Domain;

namespace TFU5.Controllers;

[ApiController]
[Route("[controller]")]
public class DisciplinasController : ControllerBase
{
    private readonly ILogger<DisciplinasController> _logger;

    private readonly IDisciplinaRepository _disciplinaRepository;

    public DisciplinasController(ILogger<DisciplinasController> logger,
                                 IDisciplinaRepository disciplinaRepository)
    {
        _logger = logger;
        _disciplinaRepository = disciplinaRepository;
    }

    [HttpGet()]
    public IEnumerable<DisciplinaDto> Get()
    {
        return _disciplinaRepository.List().Select(x => new DisciplinaDto(x)).ToList();
    }
}
