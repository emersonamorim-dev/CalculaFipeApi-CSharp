using CalculaFipeApi.Model;
using CalculaFipeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculaFipeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoFipeController : ControllerBase
    {
        private readonly ICalculoFipeService _calculoFipeService;

        public CalculoFipeController(ICalculoFipeService calculoFipeService)
        {
            _calculoFipeService = calculoFipeService;
        }

        [HttpPost]
        public ActionResult<CalculoFipeResponse> CalcularJuros([FromBody] CalculoFipeRequest request)
        {
            var valorFinal = _calculoFipeService.CalcularJuros(request.ValorBase, request.Dias, request.TaxaJuros);
            return new CalculoFipeResponse { ValorFinal = valorFinal };
        }
    }

}
