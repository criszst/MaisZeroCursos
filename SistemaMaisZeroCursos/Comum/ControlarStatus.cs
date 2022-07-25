using SistemaMaisZeroCursos.Model;

namespace SistemaMaisZeroCursos.Comum
{
    public static class ControlarStatus
    {
        public static List<StatusDisciplina> CarregarStatus()
        {
            var lstStatus = new List<StatusDisciplina>();

            var stAtivo = new StatusDisciplina
            {
                Descricao = "Ativado",
                Id = 1
            };
            lstStatus.Add(stAtivo);

            var stDesativado = new StatusDisciplina
            {
                Descricao = "Desativado",
                Id = 2
            };
            lstStatus.Add(stDesativado);

            return lstStatus;
        }

        public static List<StatusDocente> StatusDocentes()
        {
            var listaStatus = new List<StatusDocente>();

            var ensinoMedio = new StatusDocente
            {
                Desc = "Ensino Médio",
                Id = 1
            };
            listaStatus.Add(ensinoMedio);

            var EnsinoSuperior = new StatusDocente
            {
                Desc = "Ensino Superior",
                Id = 2
            };
            listaStatus.Add(EnsinoSuperior);

            var posGraduacao = new StatusDocente
            {
                Desc = "Pós-Graduação",
                Id = 3
            };
            listaStatus.Add(posGraduacao);

            var Mestrado = new StatusDocente
            {
                Desc = "Mestrado",
                Id = 4
            };
            listaStatus.Add(Mestrado);

            var Doutorado = new StatusDocente
            {
                Desc = "Doutorado",
                Id = 5
            };
            listaStatus.Add(Doutorado);

            return listaStatus;
        }

        public static List<StatusSexo> statusSexo()
        {
            var lstSt = new List<StatusSexo>();

            var masculino = new StatusSexo
            {
                Desc = "Masculino",
                Id = 1
            };
            lstSt.Add(masculino);

            var feminino = new StatusSexo
            {
                Desc = "Feminino",
                Id = 2
            };
            lstSt.Add(feminino);

            return lstSt;
        }

        public static List<StatusPeriodo> statusPeriodo()
        {
            var lstPeriodo = new List<StatusPeriodo>();

            var manha = new StatusPeriodo
            {
                Desc = "Manhã",
                Id = 1
            };
            lstPeriodo.Add(manha);

            var tarde = new StatusPeriodo
            {
                Desc = "Tarde",
                Id = 2
            };
            lstPeriodo.Add(tarde);

            var noite = new StatusPeriodo
            {
                Desc = "Noite",
                Id = 3
            };
            lstPeriodo.Add(noite);

            return lstPeriodo;
        }
    }
}
