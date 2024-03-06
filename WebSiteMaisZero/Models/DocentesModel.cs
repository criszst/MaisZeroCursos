using System.Text.Json;

namespace WebSiteMaisZero.Models
{
    public class DocentesModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Cpf { get; set; }

        public string? SexoDocente { get; set; }
        public int IdSexo { get; set; }

        public DateTime DataNascimento { get; set; }

        public string DescStatus { get; set; }

        public int IdStatus { get; set; }

        public string? GrauEscolar { get; set; }

        public int IdGrauEscolar { get; set; }


        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public string Serialize(DocentesModel container)
        {
            return JsonSerializer.Serialize(container);
        }

        public static DocentesModel Deserialize(string json)
        {
            return JsonSerializer.Deserialize<DocentesModel>(json);
        }


    }
}
