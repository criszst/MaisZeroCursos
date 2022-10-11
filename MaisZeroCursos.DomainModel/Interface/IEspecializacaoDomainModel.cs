using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursos.DomainModel.Interface
{
    public interface IEspecializacaoDomainModel : IDomainModelBase<EspecializacaoModel>
    {

        List<EspecializacaoModel> Pesquisar(string nome, int filtro);
        void Excluir(EspecializacaoModel especializacao);
    }
}
