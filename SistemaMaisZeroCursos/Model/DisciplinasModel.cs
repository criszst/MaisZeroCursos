using System.Text.Json;

namespace SistemaMaisZeroCursos.Model
{
    public class DisciplinasModel
    {
        public int Id { get; set; }
        public string? NomeDisciplina { get; set; }
        public int IdStatus { get; set; }
        public string? DescricaoStatus { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public string Serialize(DisciplinasModel container)
        {
            return JsonSerializer.Serialize(container);
        }

        public static DisciplinasModel Deserialize(string json)
        {
            return JsonSerializer.Deserialize<DisciplinasModel>(json);
        }
    }
}
