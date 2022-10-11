using Microsoft.AspNetCore.Mvc;

namespace MaisZeroCursosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IConfiguration _Configuration;

        private readonly ILogger<DisciplinaController> _logger;

        private readonly IDisciplinaDomainModel _disciplinaDomainModel;

        public DisciplinaController(ILogger<DisciplinaController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _Configuration = configuration;
            _disciplinaDomainModel = new DisciplinaDomainModel(_Configuration);
        }

        [HttpPost("Cadastrar")]
        public List<DisciplinasModel> Cadastrar([FromBody] DisciplinasModel disciplinasModel)
        {
            return _disciplinaDomainModel.Cadastrar(disciplinasModel);
        }

        [HttpPut("Atualizar")]

        public StatusCodeResult Atualizar(DisciplinasModel disciplinas)
        {
            bool atualizou = false;
            try
            {
                _disciplinaDomainModel.Atualizar(disciplinas);
                atualizou = true;
            }
            catch
            {
                atualizou = false;
            }
            if (atualizou)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("Pesquisar/{nome}")]
        public List<DisciplinasModel> PesquisarNome(string nomeDisciplina)
        {
            return _disciplinaDomainModel.PesquisarNome(nomeDisciplina);
        }

        [HttpGet("CarregarTudo")]
        public List<DisciplinasModel> CarregarTudo()
        {
            return _disciplinaDomainModel.CarregarTudo();
        }
    }
}
