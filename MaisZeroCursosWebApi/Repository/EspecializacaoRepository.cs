using MaisZeroCursos.DTO.Model;
using MaisZeroCursosWebApi.Arquivos;
using MaisZeroCursosWebApi.Constant;
using MaisZeroCursosWebApi.Repository.Interface;
using System.Text.Json;

namespace MaisZeroCursosWebApi.Repository
{
    public class EspecializacaoRepository : IEspecializacaoRepository
    {

        private IConfiguration _Configuration;
        public EspecializacaoRepository(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public List<EspecializacaoModel> Cadastrar(string nomeProfessor, int idProfessor, string especializacao, int idEspecializacao,
           DateTime dataCadastro)
        {
            var arquivo = new ioFile(_Configuration);

            var lstEspecializacao = CarregarTudo();

            var especialization = new EspecializacaoModel();

            especialization.NomeProfessor = nomeProfessor;
            especialization.idNomeProfessor = idProfessor;
            especialization.Id = lstEspecializacao != null && lstEspecializacao.Any() ? lstEspecializacao.Max(c => c.Id + 1) : 1;
            especialization.Especializacao = especializacao;
            especialization.idEspecializacao = idEspecializacao;
            especialization.DataCadastro = dataCadastro;

            lstEspecializacao.Add(especialization);

            var arquivoJson = JsonSerializer.Serialize(lstEspecializacao);
            arquivo.GravarArquivo(arquivoJson, NomeArquivos.Especializacao);

            return lstEspecializacao;
        }

        public void Atualizar(EspecializacaoModel especializacao)
        {
            var lstEspecializacao = CarregarTudo();
            if (lstEspecializacao != null && lstEspecializacao.Any() && especializacao.Id > 0)
            {
                var espFiltrada = lstEspecializacao.Where(c => c.Id == especializacao.Id).FirstOrDefault();
                if (espFiltrada != null)
                {
                    espFiltrada.NomeProfessor = especializacao.NomeProfessor;
                    espFiltrada.Id = especializacao.Id;
                    espFiltrada.idNomeProfessor = especializacao.idNomeProfessor;
                    espFiltrada.Especializacao = especializacao.Especializacao;
                    espFiltrada.idEspecializacao = especializacao.idEspecializacao;
                    espFiltrada.DataAtualizacao = especializacao.DataAtualizacao;

                    var arquivo = new ioFile(_Configuration);

                    var arquivoJson = JsonSerializer.Serialize(lstEspecializacao);
                    arquivo.GravarArquivo(arquivoJson, NomeArquivos.Especializacao);
                }
            }
        }

        public void Excluir(EspecializacaoModel especializacao)
        {
            var lstEspecializacao = CarregarTudo();

            if (lstEspecializacao != null && lstEspecializacao.Any() && especializacao.Id > 0)
            {
                var espFiltrada = lstEspecializacao.Where(c => c.Id == especializacao.Id).FirstOrDefault();

                if (espFiltrada != null)
                {
                    lstEspecializacao.Remove(espFiltrada);
                }

                var arquivo = new ioFile(_Configuration);

                var arquivoJson = JsonSerializer.Serialize(lstEspecializacao);
                arquivo.GravarArquivo(arquivoJson, NomeArquivos.Especializacao);
            }
        }

        public List<EspecializacaoModel> CarregarTudo()
        {
            var arquivo = new ioFile(_Configuration);

            var arquivoJson = arquivo.LerArquivo(NomeArquivos.Especializacao);

            var lstEspecializacao = new List<EspecializacaoModel>();

            if (!string.IsNullOrEmpty(arquivoJson) && arquivoJson != "[]")
            {
                lstEspecializacao = JsonSerializer.Deserialize<List<EspecializacaoModel>>(arquivoJson);
            }

            return lstEspecializacao!;
        }
    }
}
