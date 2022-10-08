using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursosWebApi.Repository.Interface
{
    public interface IDisciplinaRepository : IRepositoryBase<DisciplinasModel>
    {
        List<DisciplinasModel> Cadastrar(string name, int idStatus, string descricao, DateTime dataCadastro);

        void Atualizar(DisciplinasModel disciplinas);
    }
}
