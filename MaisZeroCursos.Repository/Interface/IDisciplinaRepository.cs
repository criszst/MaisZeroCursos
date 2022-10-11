using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursos.Repository.Interface
{
    public interface IDisciplinaRepository : IRepositoryBase<DisciplinasModel>
    {
        List<DisciplinasModel> Cadastrar(string name, int idStatus, string descricao, DateTime dataCadastro);

        void Atualizar(DisciplinasModel disciplinas);
    }
}
