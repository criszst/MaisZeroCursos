using SistemaMaisZeroCursos.Model;
using SistemaMaisZeroCursos.Constant;
using SistemaMaisZeroCursos.Arquivos;
using System.Text.Json;

namespace SistemaMaisZeroCursos.Repository
{
    public class DocentesRepository
    {
        public List<DocentesModel> Cadastrar(string name, string cpf, string sexo, int idSexo,
            DateTime dtNascimento, string DescStatus, int idStatus,   string DescGrauEscolar, int idGrauEscolar, DateTime dtCadastro)
        {
            var arquivo = new ioFile();

            var lstDocentes = CarregarDados();

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
            var lstDocentes = CarregarDados();

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

                    var arquivo = new ioFile();

                    var arquivoJson = JsonSerializer.Serialize(lstDocentes);
                    arquivo.GravarArquivo(arquivoJson, NomeArquivos.Docentes);
                }
            }
        }

        public List<DocentesModel> CarregarDados()
        {
            var arquivo = new ioFile();

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
