using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursosWebApi.DomainModel.Interface
{
    public interface IDiscenteDomainModel : IDomainModelBase<DiscentesModel>
    {
        List<DiscentesModel> PesquisarNome(string nome);
    }
}
