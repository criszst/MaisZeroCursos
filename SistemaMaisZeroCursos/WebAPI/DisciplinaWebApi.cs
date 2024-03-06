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
    public class DisciplinaWebApi
    {
        string Api = $"{ConfigurationManager.AppSettings["Api"]!}/Disciplinas";

        public List<DisciplinasModel> Cadastrar(DisciplinasModel disciplinasModel)
        {
            List<DisciplinasModel> dados = new List<DisciplinasModel>();
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Cadastrar", Method.Post).AddBody(disciplinasModel);

            var response = client.Execute<List<DisciplinasModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
        public void Atualizar(DisciplinasModel disciplina)
        {
            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Atualizar", Method.Put);

            request.AddJsonBody(disciplina);

            client.Execute<DisciplinasModel>(request);
        }

        public List<DisciplinasModel> PesquisarNome(string nome)
        {
            List<DisciplinasModel> dados = new List<DisciplinasModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/Pesquisar/{nome}?nomeDisciplina={nome}", Method.Get);

            var response = client.Execute<List<DisciplinasModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }

        public List<DisciplinasModel> CarregarDados()
        {
            List<DisciplinasModel> dados = new List<DisciplinasModel>();

            RestClient client = new RestClient(Api);

            RestRequest request = new RestRequest($"{Api}/CarregarTudo", Method.Get);

            var response = client.Execute<List<DisciplinasModel>>(request);

            if (response.IsSuccessStatusCode)
            {
                dados = response.Data!;
            }

            return dados;
        }
    }
}
