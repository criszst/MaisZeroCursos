using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursosWebApi.Repository.Interface
{
    public interface IDocentesRepository : IRepositoryBase<DocentesModel>
    {
        List<DocentesModel> Cadastrar(string name, string cpf, string sexo, int idSexo,
           DateTime dtNascimento, string DescStatus, int idStatus, string DescGrauEscolar, int idGrauEscolar, DateTime dtCadastro);
        void Atualizar(DocentesModel docentes);
    }
}
