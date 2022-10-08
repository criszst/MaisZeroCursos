namespace MaisZeroCursosWebApi.DomainModel.Interface
{
    public interface IDomainModelBase <T>
        where T : class
    {
        List<T> Cadastrar(T obj);

        void Atualizar(T obj);

        List<T> CarregarTudo();
    }
}
