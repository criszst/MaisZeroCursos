using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursos.DomainModel.Interface
{
    public interface IDisciplinaDomainModel : IDomainModelBase<DisciplinasModel>
    {
        List<DisciplinasModel> PesquisarNome(string nomeDisciplina);

    }
}
