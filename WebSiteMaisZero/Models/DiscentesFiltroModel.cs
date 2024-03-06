namespace WebSiteMaisZero.Models
{
    public class DiscentesFiltroModel
    {
        public DiscentesFiltroModel()
        {
            DiscentesFiltro = new List<DiscentesModel>();
        }
        public List<DiscentesModel> DiscentesFiltro { get; set; }

        public string FiltroNome { get; set; }
    }
}
