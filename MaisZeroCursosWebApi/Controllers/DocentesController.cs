using Microsoft.AspNetCore.Mvc;

namespace MaisZeroCursosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        private readonly IConfiguration _Configuration;

        private readonly ILogger<DocentesController> _logger;

        private readonly IDocentesDomainModel _docentesDomainModel;

        public DocentesController(ILogger<DocentesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _Configuration = configuration;
            _docentesDomainModel = new DocentesDomainModel(_Configuration);
        }

        [HttpPost("Cadastrar")]
        public List<DocentesModel> Cadastrar([FromBody] DocentesModel docenteModel)
        {
            return _docentesDomainModel.Cadastrar(docenteModel);
        }

        [HttpPut("Atualizar")]
        public void Atualizar([FromBody] DocentesModel docenteModel)
        {
            _docentesDomainModel.Atualizar(docenteModel);
        }


        [HttpGet("Pesquisar/{nome}")]
        public List<DocentesModel> PesquisarNome(string nome)
        {
            return _docentesDomainModel.PesquisarNome(nome);
        }

        [HttpGet("PesquisarTudo")]
        public List<DocentesModel> CarregarTudo()
        {
            return _docentesDomainModel.CarregarTudo();
        }
    }
}
