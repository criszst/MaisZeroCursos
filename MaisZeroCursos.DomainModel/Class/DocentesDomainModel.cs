
namespace MaisZeroCursos.DomainModel.Class
{
    public class DocentesDomainModel : IDocentesDomainModel
    {
        private readonly IDocentesRepository _docentesRepository;

        private readonly IConfiguration _Configuration;

        public DocentesDomainModel(IConfiguration configuration)
        {
            _Configuration = configuration;
            _docentesRepository = new DocentesRepository(_Configuration);
        }
        public void Atualizar(DocentesModel docentes)
        {
            _docentesRepository.Atualizar(docentes);
        }

        public List<DocentesModel> Cadastrar(DocentesModel docentes)
        {
            if (!string.IsNullOrEmpty(docentes.Name) &&
                !string.IsNullOrEmpty(docentes.Cpf) &&
                !string.IsNullOrEmpty(docentes.SexoDocente) &&

                docentes.IdSexo != 0 &&
                !string.IsNullOrEmpty(docentes.DescStatus) &&
                docentes.IdStatus != 0 &&

                !string.IsNullOrEmpty(docentes.GrauEscolar) &&
                docentes.IdGrauEscolar != 0)
            {
                docentes.DataNascimento = docentes.DataNascimento <= DateTime.MinValue ? DateTime.Now : docentes.DataNascimento;
                docentes.DataCadastro = docentes.DataCadastro <= DateTime.MinValue ? DateTime.Now : docentes.DataCadastro;

                return _docentesRepository.Cadastrar(docentes.Name!, docentes.Cpf!, docentes.SexoDocente!, docentes.IdSexo, docentes.DataNascimento,
                docentes.DescStatus, docentes.IdStatus, docentes.GrauEscolar!, docentes.IdGrauEscolar, docentes.DataCadastro);
            }

            return new List<DocentesModel>();
        }

        public List<DocentesModel> CarregarTudo()
        {
            return _docentesRepository.CarregarTudo();
        }

        public List<DocentesModel> PesquisarNome(string nomeDoscente)
        {
            var lstDocentes = _docentesRepository.CarregarTudo();

            return lstDocentes.Where(n => n.Name!.ToUpper().Contains(nomeDoscente.ToUpper())).ToList();
        }
    }
}
