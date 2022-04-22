using EndPointsRest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPointsRest.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private static readonly string[] Nomes = new[]
        {
        "Rodrigo", "Lucas", "Gabriela", "Tânia", "Amy", "Jake", "Charles", "Isis"
        };

        private readonly ILogger<ConsultaController> _logger;

        public ConsultaController(ILogger<ConsultaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/[controller]/GetConsulta")]
        public IEnumerable<Pessoa> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Pessoa
            {
                Nome = Nomes[Random.Shared.Next(Nomes.Length)],
                Altura = Random.Shared.Next(148, 185),
                Peso = Random.Shared.Next(50, 90),
            })
            .ToArray();
        }

    }
}