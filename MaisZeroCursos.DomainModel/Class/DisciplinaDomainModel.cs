

namespace MaisZeroCursos.DomainModel.Class
{
    public class DisciplinaDomainModel : IDisciplinaDomainModel
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        private readonly IConfiguration _Configuration;

        public DisciplinaDomainModel(IConfiguration configuration)
        {
            _Configuration = configuration;
            _disciplinaRepository = new DisciplinaRespository(_Configuration);
        }

        public List<DisciplinasModel> Cadastrar(DisciplinasModel disciplinasModel)
        {
            if (!string.IsNullOrEmpty(disciplinasModel.NomeDisciplina) &&
               !string.IsNullOrEmpty(disciplinasModel.DescricaoStatus) &&
               disciplinasModel.IdStatus != 0)
            {
                disciplinasModel.DataCadastro = disciplinasModel.DataCadastro <= DateTime.MinValue ? DateTime.Now : disciplinasModel.DataCadastro;

                return _disciplinaRepository.Cadastrar(disciplinasModel.NomeDisciplina, disciplinasModel.IdStatus, disciplinasModel.DescricaoStatus!, disciplinasModel.DataCadastro);
            }

            return new List<DisciplinasModel>();

        }

        public void Atualizar(DisciplinasModel disciplinas)
        {
            _disciplinaRepository.Atualizar(disciplinas);
        }

        public List<DisciplinasModel> PesquisarNome(string nomeDisciplina)
        {
            return _disciplinaRepository.CarregarTudo()
                .Where(n => n.NomeDisciplina!.ToUpper().Contains(nomeDisciplina.ToUpper())).ToList();
        }

        public List<DisciplinasModel> CarregarTudo()
        {
            return _disciplinaRepository.CarregarTudo();
        }
    }
}
