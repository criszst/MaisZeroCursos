using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursos.Repository.Interface
{
    public interface IDiscentesRepository : IRepositoryBase<DiscentesModel>
    {
        List<DiscentesModel> Cadastrar(string name, string cpf, string sexoDiscente, int idSexo, DateTime dataNascimento,
            string status, int idStatus, string Periodo, int idPeriodo);

        void Atualizar(DiscentesModel discentes);
    }
}
