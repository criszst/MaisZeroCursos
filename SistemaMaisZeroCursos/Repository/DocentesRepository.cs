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

        public void Atualizar()
        {
            // TODO: Função atualizar registro
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
