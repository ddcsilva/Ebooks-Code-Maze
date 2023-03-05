using FuncionariosCompanhia.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FuncionariosCompanhia.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInformativo("Aqui est� uma mensagem informativa dos valores da Controller.");
            _logger.LogDepuracao("Aqui est� uma mensagem de depura��o dos valores da Controller.");
            _logger.LogAdvertencia("Aqui est� uma mensagem de advert�ncia dos valores da Controller.");
            _logger.LogErro("Aqui est� uma mensagem de erro dos valores da Controller.");

            return new string[] { "valor1", "valor2" };
        }
    }
}