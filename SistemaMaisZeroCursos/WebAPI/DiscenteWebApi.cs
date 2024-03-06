using MaisZeroCursos.DTO.Model;
using Newtonsoft.Json;
using RestSharp;
using SistemaMaisZeroCursos.Constant;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SistemaMaisZeroCursos.WebAPI
{
    public class DiscenteWebApi
    {
        string Api = $"{ConfigurationManager.AppSettings["Api"]!}/Discente";

        public List<DiscentesModel> Cadastrar(DiscentesModel discentesModel)
        {
            List<DiscentesModel> dados = new List<DiscentesModel>();
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Cadastrar", Method.Post).AddBody(discentesModel);

            var response = client.Execute<List<DiscentesModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
        public void Atualizar(DiscentesModel discentes)
        {
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Atualizar", Method.Put);

            request.AddJsonBody(discentes);

            client.Execute<DiscentesModel>(request);
        }

        public List<DiscentesModel> PesquisarNome(string nome)
        {
            List<DiscentesModel> dados = new List<DiscentesModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Pesquisar/{nome}", Method.Get);

            var response = client.Execute<List<DiscentesModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }

        public List<DiscentesModel> CarregarDados()
        {
            List<DiscentesModel> dados = new List<DiscentesModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/PesquisarTudo", Method.Get);

            var response = client.Execute<List<DiscentesModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
    }
}