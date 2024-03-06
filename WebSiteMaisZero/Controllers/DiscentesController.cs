using Microsoft.AspNetCore.Mvc;
using WebSiteMaisZero.Models;

namespace WebSiteMaisZero.Controllers
{
    public class DiscentesController : Controller
    {
        private readonly IConfiguration _Configuration;
        private readonly ILogger<DiscentesController> _logger;

        public DiscentesController(ILogger<DiscentesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _Configuration = configuration;
        }

        public IActionResult Index()
        {
            var model = new DiscentesFiltroModel();
            model.DiscentesFiltro = MockDiscente(10);
            return View(model);
        }

        public IActionResult Pesquisar()
        {
            return View();
        }

        private List<DiscentesModel> MockDiscente(int qtd)
        {
            var list = new List<DiscentesModel>();

            for (int i = 0; i < qtd; i++)
            {
                var discente = new DiscentesModel()
                {
                    Name = $"Nome {i}",
                    Cpf = $"CPF {i}",
                    SexoDiscente = $"Sexo do Discente {i}"
                };

                list.Add(discente);
            }

            return list;
        }
    }
}
