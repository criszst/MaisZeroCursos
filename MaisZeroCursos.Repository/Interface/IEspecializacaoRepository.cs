using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursos.Repository.Interface
{
    public interface IEspecializacaoRepository : IRepositoryBase<EspecializacaoModel>
    {
        List<EspecializacaoModel> Cadastrar(string nomeProfessor, int idProfessor, string especializacao, int idEspecializacao,
           DateTime dataCadastro);
        void Atualizar(EspecializacaoModel especializacao);

        void Excluir(EspecializacaoModel especializacao);
    }
}
