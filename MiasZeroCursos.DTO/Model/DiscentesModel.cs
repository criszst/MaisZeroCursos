namespace MaisZeroCursos.DTO.Model
{
    public class DiscentesModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Cpf { get; set; }

        public string? SexoDiscente { get; set; }
        public int IdSexo { get; set; }

        public DateTime DataNascimento { get; set; }

        public string? Status { get; set; }

        public int IdStatus { get; set; }

        public string? Periodo { get; set; }

        public int idPeriodo { get; set; }


        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
