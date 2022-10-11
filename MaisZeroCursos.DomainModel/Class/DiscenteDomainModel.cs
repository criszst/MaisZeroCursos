

namespace MaisZeroCursos.DomainModel.Class
{
    public class DiscenteDomainModel : IDiscenteDomainModel
    {
        private readonly IDiscentesRepository _discentesRepository;

        private readonly IConfiguration _Configuration;

        public DiscenteDomainModel(IConfiguration configuration)
        {
            _Configuration = configuration;
            _discentesRepository = new DiscentesRepository(_Configuration);
        }

        public List<DiscentesModel> Cadastrar(DiscentesModel discentesModel)
        {
            if (!string.IsNullOrEmpty(discentesModel.Name) &&
                !string.IsNullOrEmpty(discentesModel.Cpf) &&
                !string.IsNullOrEmpty(discentesModel.SexoDiscente) &&
                !string.IsNullOrEmpty(discentesModel.Status) &&
                !string.IsNullOrEmpty(discentesModel.Periodo) &&

                discentesModel.DataNascimento > DateTime.MinValue &&

                discentesModel.IdSexo > 0 &&
                discentesModel.idPeriodo > 0 &&
                discentesModel.IdStatus > 0
                )
            {
                return _discentesRepository.Cadastrar(discentesModel.Name!, discentesModel.Cpf!, discentesModel.SexoDiscente!, discentesModel.IdSexo,
                    discentesModel.DataNascimento, discentesModel.Status!, discentesModel.IdStatus,
                    discentesModel.Periodo!, discentesModel.idPeriodo);
            }

            return new List<DiscentesModel>();
        }

        public void Atualizar(DiscentesModel discentesModel)
        {
            _discentesRepository.Atualizar(discentesModel);
        }

        public List<DiscentesModel> PesquisarNome(string nome)
        {
            var lstDiscentes = new List<DiscentesModel>();

            lstDiscentes = _discentesRepository.CarregarTudo();

            return lstDiscentes.Where(n => n.Name.ToUpper() == nome.ToUpper()).ToList();
        }

        public List<DiscentesModel> CarregarTudo()
        {
            return _discentesRepository.CarregarTudo();
        }
    }
}
