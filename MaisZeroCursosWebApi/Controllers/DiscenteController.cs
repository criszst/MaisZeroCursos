using MaisZeroCursos.DTO.Model;
using MaisZeroCursosWebApi.DomainModel;
using MaisZeroCursosWebApi.DomainModel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MaisZeroCursosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscenteController : ControllerBase
    {
        private readonly IConfiguration _Configuration;

        private readonly ILogger<DiscenteController> _logger;

        private readonly IDiscenteDomainModel _discenteDomainModel;

        public DiscenteController(ILogger<DiscenteController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _Configuration = configuration;
            _discenteDomainModel = new DiscenteDomainModel(_Configuration);
        }

        [HttpPost("Cadastrar")]
        public List<DiscentesModel> Cadastrar([FromBody] DiscentesModel discentesModel)
        {
            return _discenteDomainModel.Cadastrar(discentesModel);
        }

        [HttpPut("Atualizar")]
        public void Atualizar([FromBody] DiscentesModel discentesModel)
        {
            _discenteDomainModel.Atualizar(discentesModel);
        }

        [HttpGet("Pesquisar/{nome}")]   
        public List<DiscentesModel> Pesquisa(string nome)
        {
            return _discenteDomainModel.PesquisarNome(nome);
        }

        [HttpGet("PesquisarTudo")]
        public List<DiscentesModel> CarregarTudo()
        {
            return _discenteDomainModel.CarregarTudo();
        }
    }
}
