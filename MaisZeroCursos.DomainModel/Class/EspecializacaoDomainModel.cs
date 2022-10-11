using MaisZeroCursos.DomainModel.Interface;
using MaisZeroCursos.DTO.Model;
using MaisZeroCursos.Repository.Class;
using MaisZeroCursos.Repository.Interface;
using Microsoft.Extensions.Configuration;

namespace MaisZeroCursos.DomainModel.Class
{
    public class EspecializacaoDomainModel : IEspecializacaoDomainModel
    {

        private readonly IEspecializacaoRepository _especializacaoRepository;

        private readonly IConfiguration _Configuration;

        public EspecializacaoDomainModel(IConfiguration configuration)
        {
            _Configuration = configuration;
            _especializacaoRepository = new EspecializacaoRepository(_Configuration);
        }


        public void Atualizar(EspecializacaoModel especializacao)
        {
            _especializacaoRepository.Atualizar(especializacao);
        }

        public List<EspecializacaoModel> Cadastrar(EspecializacaoModel especializacaoModel)
        {

            if (!string.IsNullOrEmpty(especializacaoModel.NomeProfessor) &&
                especializacaoModel.Id != 0 &&
                !string.IsNullOrEmpty(especializacaoModel.Especializacao) &&
                 especializacaoModel.idEspecializacao != 0
                )
            {
                return _especializacaoRepository.Cadastrar(especializacaoModel.NomeProfessor!, especializacaoModel.idNomeProfessor,
                especializacaoModel.Especializacao!, especializacaoModel.idEspecializacao!, especializacaoModel.DataCadastro);
            }
            // nomeProfessor, idProfessor, especializacao, idEspecializacao, dataCadastro

            return new List<EspecializacaoModel>();
        }

        public List<EspecializacaoModel> CarregarTudo()
        {
            return _especializacaoRepository.CarregarTudo();
        }

        public void Excluir(EspecializacaoModel especializacao)
        {
            _especializacaoRepository.Excluir(especializacao);
        }

        public List<EspecializacaoModel> Pesquisar(string nome, int filtro)
        {
            if (filtro == 1)
                return _especializacaoRepository.CarregarTudo().Where(n => n.NomeProfessor.ToUpper().Contains(nome.ToUpper())).ToList();
            else
                return _especializacaoRepository.CarregarTudo().Where(n => n.Especializacao.ToUpper().Contains(nome.ToUpper())).ToList();
        }
    }
}
