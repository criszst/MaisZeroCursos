using System.ComponentModel.DataAnnotations;

namespace WebSiteMaisZero.Models 
{
    public class DiscentesModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser informado")]
        [Display(Description = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "{0} precisa ser informado")]
        [Display(Description = "Número do CPF")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "{0} precisa ser informado")]
        [Display(Description ="Sexo do discente")]
        public string? SexoDiscente { get; set; }
        public int IdSexo { get; set; }

        [Required(ErrorMessage = "{0} precisa ser informado")]
        [Display(Description = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} precisa ser informado")]
        [Display(Description = "Status")]
        public string? Status { get; set; }

        public int IdStatus { get; set; }

        public string? Periodo { get; set; }

        public int idPeriodo { get; set; }


        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
