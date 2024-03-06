using MaisZeroCursos.DTO.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMaisZeroCursos.WebAPI
{
    public class DocenteWebApi
    {
        string Api = $"{ConfigurationManager.AppSettings["Api"]!}/Docentes";

        public List<DocentesModel> Cadastrar(DocentesModel docenteModel)
        {
            List<DocentesModel> dados = new List<DocentesModel>();
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Cadastrar", Method.Post).AddBody(docenteModel);

            var response = client.Execute<List<DocentesModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
        public void Atualizar(DocentesModel docente)
        {
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Atualizar", Method.Put);

            request.AddJsonBody(docente);

            client.Execute<DocentesModel>(request);
        }

        public List<DocentesModel> PesquisarNome(string nome)
        {
            List<DocentesModel> dados = new List<DocentesModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Pesquisar/{nome}", Method.Get);

            var response = client.Execute<List<DocentesModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }

        public List<DocentesModel> CarregarDados()
        {
            List<DocentesModel> dados = new List<DocentesModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/PesquisarTudo", Method.Get);

            var response = client.Execute<List<DocentesModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
    }
}
