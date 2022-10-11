using MaisZeroCursos.DTO.Model;
using MaisZeroCursos.Repository.Interface;
using MaisZeroCursosWebApi.Arquivos;
using MaisZeroCursosWebApi.Constant;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace MaisZeroCursos.Class.Repository
{
    public class DiscentesRepository : IDiscentesRepository
    {
        private IConfiguration _Configuration;
        public DiscentesRepository(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }
        public List<DiscentesModel> Cadastrar(string name, string cpf, string sexoDiscente, int idSexo, DateTime dataNascimento,
            string status, int idStatus, string Periodo, int idPeriodo)
        {
            var arquivo = new ioFile(_Configuration);
            var lstDiscentes = CarregarTudo();

            var discente = new DiscentesModel();

            discente.Id = lstDiscentes != null && lstDiscentes.Any() ? lstDiscentes.Max(c => c.Id + 1) : 1;
            discente.Name = name;
            discente.Cpf = cpf;

            discente.SexoDiscente = sexoDiscente;
            discente.IdSexo = idSexo;

            discente.DataNascimento = dataNascimento;
            discente.Status = status;
            discente.IdStatus = idStatus;

            discente.Periodo = Periodo;
            discente.idPeriodo = idPeriodo;

            discente.DataCadastro = DateTime.Now;

            lstDiscentes.Add(discente);

            var arquivoJson = JsonSerializer.Serialize(lstDiscentes);
            arquivo.GravarArquivo(arquivoJson, NomeArquivos.Discentes);

            return lstDiscentes;
        }

        public void Atualizar(DiscentesModel discentes)
        {
            var lstDiscentes = CarregarTudo();

            if (lstDiscentes != null && lstDiscentes.Any() && discentes.Id > 0)
            {
                var discentesFiltro = lstDiscentes.Where(c => c.Id == discentes.Id).FirstOrDefault();
                if (discentesFiltro != null)
                {

                    discentesFiltro.Name = discentes.Name;
                    discentesFiltro.Id = discentes.Id;
                    discentesFiltro.Cpf = discentes.Cpf;
                    discentesFiltro.SexoDiscente = discentes.SexoDiscente;
                    discentesFiltro.IdSexo = discentes.IdSexo;

                    discentesFiltro.DataNascimento = discentes.DataNascimento;

                    discentesFiltro.Status = discentes.Status;
                    discentesFiltro.IdStatus = discentes.IdStatus;

                    discentesFiltro.Periodo = discentes.Periodo;
                    discentesFiltro.idPeriodo = discentes.idPeriodo;

                    discentesFiltro.DataAtualizacao = discentes.DataAtualizacao;

                    var arquivo = new ioFile(_Configuration);

                    var arquivoJson = JsonSerializer.Serialize(lstDiscentes);
                    arquivo.GravarArquivo(arquivoJson, NomeArquivos.Discentes);
                }
            }
        }

        public List<DiscentesModel> CarregarTudo()
        {
            var arquivo = new ioFile(_Configuration);

            var arquivoJson = arquivo.LerArquivo(NomeArquivos.Discentes);

            var lstDiscentes = new List<DiscentesModel>();

            if (!string.IsNullOrEmpty(arquivoJson) && arquivoJson != "[]")
            {
                lstDiscentes = JsonSerializer.Deserialize<List<DiscentesModel>>(arquivoJson);
            }

            return lstDiscentes!;
        }
    }
}
