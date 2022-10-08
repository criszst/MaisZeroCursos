using MaisZeroCursos.DTO.Model;
using MaisZeroCursosWebApi.Arquivos;
using MaisZeroCursosWebApi.Constant;
using MaisZeroCursosWebApi.Repository.Interface;
using System.Text.Json;

namespace MaisZeroCursosWebApi.Repository
{
    public class DocentesRepository : IDocentesRepository
    {
        private IConfiguration _Configuration;
        public DocentesRepository(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public List<DocentesModel> Cadastrar(string name, string cpf, string sexo, int idSexo,
           DateTime dtNascimento, string DescStatus, int idStatus, string DescGrauEscolar, int idGrauEscolar, DateTime dtCadastro)
        {
            var arquivo = new ioFile(_Configuration);

            var lstDocentes = CarregarTudo();

            var docente = new DocentesModel();

            docente.Name = name;
            docente.Id = lstDocentes != null && lstDocentes.Any() ? lstDocentes.Max(c => c.Id + 1) : 1;
            docente.Cpf = cpf;

            docente.SexoDocente = sexo;
            docente.IdSexo = idSexo;

            docente.DataNascimento = dtNascimento;

            docente.DescStatus = DescStatus;
            docente.IdStatus = idStatus;

            docente.GrauEscolar = DescGrauEscolar;
            docente.IdGrauEscolar = idGrauEscolar;

            docente.DataCadastro = dtCadastro;

            lstDocentes.Add(docente);

            var arquivoJson = JsonSerializer.Serialize(lstDocentes);
            arquivo.GravarArquivo(arquivoJson, NomeArquivos.Docentes);

            return lstDocentes;
        }

        public void Atualizar(DocentesModel docentes)
        {
            var lstDocentes = CarregarTudo();

            if (lstDocentes != null && lstDocentes.Any() && docentes.Id > 0)
            {
                var docentesFiltro = lstDocentes.Where(c => c.Id == docentes.Id).FirstOrDefault();
                if (docentesFiltro != null)
                {

                    docentesFiltro.Name = docentes.Name;
                    docentesFiltro.Id = docentes.Id;
                    docentesFiltro.Cpf = docentes.Cpf;
                    docentesFiltro.SexoDocente = docentes.SexoDocente;
                    docentesFiltro.IdSexo = docentes.IdSexo;

                    docentesFiltro.DataNascimento = docentes.DataNascimento;

                    docentesFiltro.DescStatus = docentes.DescStatus;
                    docentesFiltro.IdStatus = docentes.IdStatus;

                    docentesFiltro.GrauEscolar = docentes.GrauEscolar;
                    docentesFiltro.IdGrauEscolar = docentes.IdGrauEscolar;

                    docentesFiltro.DataAtualizacao = docentes.DataAtualizacao;

                    var arquivo = new ioFile(_Configuration);

                    var arquivoJson = JsonSerializer.Serialize(lstDocentes);
                    arquivo.GravarArquivo(arquivoJson, NomeArquivos.Docentes);
                }
            }
        }

        public List<DocentesModel> CarregarTudo()
        {
            var arquivo = new ioFile(_Configuration);

            var arquivoJson = arquivo.LerArquivo(NomeArquivos.Docentes);

            var lstDocente = new List<DocentesModel>();

            if (!string.IsNullOrEmpty(arquivoJson) && arquivoJson != "[]")
            {
                lstDocente = JsonSerializer.Deserialize<List<DocentesModel>>(arquivoJson);
            }

            return lstDocente!;
        }
    }
}
