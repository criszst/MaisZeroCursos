using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisZeroCursos.DTO.Model
{
    public class EspecializacaoModel
    {
        public int Id { get; set; }
        public string? NomeProfessor { get; set; }
        public int idNomeProfessor { get; set; }
        public string? Especializacao { get; set; }
        public int idEspecializacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
