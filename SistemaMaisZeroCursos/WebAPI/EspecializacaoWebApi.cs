using MaisZeroCursos.DTO.Model;
using RestSharp;
using System.Configuration;

namespace SistemaMaisZeroCursos.WebAPI
{
    public class EspecializacaoWebApi
    {
        string Api = $"{ConfigurationManager.AppSettings["Api"]!}/Especializacao";

        public List<EspecializacaoModel> Cadastrar(EspecializacaoModel especializacaoModel)
        {
            List<EspecializacaoModel> dados = new List<EspecializacaoModel>();
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Cadastrar", Method.Post).AddBody(especializacaoModel);

            var response = client.Execute<List<EspecializacaoModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
        public void Atualizar(EspecializacaoModel especializacao)
        {
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Atualizar", Method.Put);

            request.AddJsonBody(especializacao);

            client.Execute<EspecializacaoModel>(request);
        }

        public void Excluir(EspecializacaoModel especializacao)
        {
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Excluir", Method.Delete);

            request.AddJsonBody(especializacao);

            request.AddHeader("Content-Type", "application/json");

            client.Delete(request);
        }

        public List<EspecializacaoModel> Pesquisar(string nome, int filtro)
        {
            List<EspecializacaoModel> dados = new List<EspecializacaoModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Pesquisar/{nome}/{filtro}", Method.Get);

            var response = client.Execute<List<EspecializacaoModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }

        public List<EspecializacaoModel> CarregarDados()
        {
            List<EspecializacaoModel> dados = new List<EspecializacaoModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/CarregarTudo", Method.Get);

            var response = client.Execute<List<EspecializacaoModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
    }
}
