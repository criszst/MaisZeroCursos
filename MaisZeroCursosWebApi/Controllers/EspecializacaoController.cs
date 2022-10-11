using Microsoft.AspNetCore.Mvc;

namespace MaisZeroCursosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecializacaoController : ControllerBase
    {
        private readonly IConfiguration _Configuration;

        private readonly ILogger<EspecializacaoController> _logger;

        private readonly IEspecializacaoDomainModel _especializacaoDomainModel;

        public EspecializacaoController(ILogger<EspecializacaoController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _Configuration = configuration;
            _especializacaoDomainModel = new EspecializacaoDomainModel(_Configuration);
        }

        [HttpPost("Cadastrar")]
        public List<EspecializacaoModel> Cadastrar([FromBody] EspecializacaoModel especializacaoModel)
        {
            return _especializacaoDomainModel.Cadastrar(especializacaoModel);
        }

        [HttpPut("Atualizar")]
        public void Atualizar([FromBody] EspecializacaoModel especializacaoModel)
        {
            _especializacaoDomainModel.Atualizar(especializacaoModel);
        }


        [HttpDelete("Excluir")]
        public void Excluir([FromBody] EspecializacaoModel especializacaoModel)
        {
            _especializacaoDomainModel.Excluir(especializacaoModel);
        }

        [HttpGet("Pesquisar/{nome}/{filtro}")]
        public List<EspecializacaoModel> Pesquisar(string nome, int filtro)
        {
            return _especializacaoDomainModel.Pesquisar(nome, filtro);
        }

        [HttpGet("CarregarTudo")]
        public List<EspecializacaoModel> CarregarTudo()
        {
            return _especializacaoDomainModel.CarregarTudo();
        }
    }
}
