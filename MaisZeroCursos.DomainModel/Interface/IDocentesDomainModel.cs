

namespace MaisZeroCursos.DomainModel.Interface
{
    public interface IDocentesDomainModel : IDomainModelBase<DocentesModel>
    {
        List<DocentesModel> PesquisarNome(string nomeDoscente);
    }
}
