namespace MaisZeroCursos.DomainModel.Interface
{
    public interface IDiscenteDomainModel : IDomainModelBase<DiscentesModel>
    {
        List<DiscentesModel> PesquisarNome(string nome);
    }
}
