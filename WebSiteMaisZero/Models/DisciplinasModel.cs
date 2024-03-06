namespace WebSiteMaisZero.Models
{
    public class DisciplinasModel
    {
        public int Id { get; set; }
        public string? NomeDisciplina { get; set; }
        public int IdStatus { get; set; }
        public string? DescricaoStatus { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
