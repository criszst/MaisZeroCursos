using MaisZeroCursos.DTO.Model;
using MaisZeroCursos.Repository.Interface;
using MaisZeroCursosWebApi.Arquivos;
using MaisZeroCursosWebApi.Constant;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace MaisZeroCursos.Repository.Class
{
    public class DisciplinaRespository : IDisciplinaRepository
    {
        private IConfiguration _Configuration;
        public DisciplinaRespository(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public List<DisciplinasModel> Cadastrar(string name, int idStatus, string descricao, DateTime dataCadastro)
        {
            var arquivo = new ioFile(_Configuration);

            var lstDisciplina = CarregarTudo();

            var Disciplina = new DisciplinasModel();

            Disciplina.NomeDisciplina = name;
            Disciplina.Id = lstDisciplina != null && lstDisciplina.Any() ? lstDisciplina.Max(c => c.Id + 1) : 1;
            Disciplina.IdStatus = idStatus;
            Disciplina.DescricaoStatus = descricao;
            Disciplina.DataCadastro = dataCadastro;

            lstDisciplina.Add(Disciplina);

            var arquivoJson = JsonSerializer.Serialize(lstDisciplina);
            arquivo.GravarArquivo(arquivoJson, NomeArquivos.Disciplina);

            return lstDisciplina;
        }

        public void Atualizar(DisciplinasModel disciplinas)
        {
            var lstDisciplinasArquivo = CarregarTudo();
            if (lstDisciplinasArquivo != null && lstDisciplinasArquivo.Any() && disciplinas.Id > 0)
            {
                var disciplinaFiltrada = lstDisciplinasArquivo.Where(c => c.Id == disciplinas.Id).FirstOrDefault();
                if (disciplinaFiltrada != null)
                {
                    disciplinaFiltrada.NomeDisciplina = disciplinas.NomeDisciplina;
                    disciplinaFiltrada.IdStatus = disciplinas.IdStatus;
                    disciplinaFiltrada.DescricaoStatus = disciplinas.DescricaoStatus;
                    disciplinaFiltrada.DataAtualizacao = disciplinas.DataAtualizacao;

                    var arquivo = new ioFile(_Configuration);

                    var arquivoJson = JsonSerializer.Serialize(lstDisciplinasArquivo);
                    arquivo.GravarArquivo(arquivoJson, NomeArquivos.Disciplina);
                }
            }
        }

        public List<DisciplinasModel> CarregarTudo()
        {
            var arquivo = new ioFile(_Configuration);

            var arquivoJson = arquivo.LerArquivo(NomeArquivos.Disciplina);

            var lstDisciplina = new List<DisciplinasModel>();

            if (!string.IsNullOrEmpty(arquivoJson) && arquivoJson != "[]")
            {
                lstDisciplina = JsonSerializer.Deserialize<List<DisciplinasModel>>(arquivoJson);
            }

            return lstDisciplina!;
        }
    }
}
