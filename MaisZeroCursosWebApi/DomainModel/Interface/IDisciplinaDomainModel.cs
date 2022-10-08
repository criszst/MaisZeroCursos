using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursosWebApi.DomainModel.Interface
{
    public interface IDisciplinaDomainModel : IDomainModelBase<DisciplinasModel>
    {
       List<DisciplinasModel> PesquisarNome(string nomeDisciplina);
       
    }
}
