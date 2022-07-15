using SistemaMaisZeroCursos.Model;

namespace SistemaMaisZeroCursos.Comum
{
    public static class ControlarStatus
    {
        public static List<StatusModel> CarregarStatus()
        {
            var lstStatus = new List<StatusModel>();

            var stAtivo = new StatusModel
            {
                Descricao = "Ativado",
                Id = 1
            };
            lstStatus.Add(stAtivo);

            var stDesativado = new StatusModel
            {
                Descricao = "Desativado",
                Id = 2
            };
            lstStatus.Add(stDesativado);

            return lstStatus;
        }
    }
}
