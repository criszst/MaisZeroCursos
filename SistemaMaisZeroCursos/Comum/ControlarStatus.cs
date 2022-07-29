using SistemaMaisZeroCursos.Model;
using SistemaMaisZeroCursos.Repository;

namespace SistemaMaisZeroCursos.Comum
{
    public static class ControlarStatus
    {
        public static List<ComboBoxCampo> CarregarStatus()
        {
            var lstStatus = new List<ComboBoxCampo>();

            var stAtivo = new ComboBoxCampo
            {
                Descricao = "Ativado",
                Id = 1
            };
            lstStatus.Add(stAtivo);

            var stDesativado = new ComboBoxCampo
            {
                Descricao = "Desativado",
                Id = 2
            };
            lstStatus.Add(stDesativado);

            return lstStatus;
        }

        public static List<ComboBoxCampo> StatusDocentes()
        {
            var listaStatus = new List<ComboBoxCampo>();

            var ensinoMedio = new ComboBoxCampo
            {
                Descricao = "Ensino Médio",
                Id = 1
            };
            listaStatus.Add(ensinoMedio);

            var EnsinoSuperior = new ComboBoxCampo
            {
                Descricao = "Ensino Superior",
                Id = 2
            };
            listaStatus.Add(EnsinoSuperior);

            var posGraduacao = new ComboBoxCampo
            {
                Descricao = "Pós-Graduação",
                Id = 3
            };
            listaStatus.Add(posGraduacao);

            var Mestrado = new ComboBoxCampo
            {
                Descricao = "Mestrado",
                Id = 4
            };
            listaStatus.Add(Mestrado);

            var Doutorado = new ComboBoxCampo
            {
                Descricao = "Doutorado",
                Id = 5
            };
            listaStatus.Add(Doutorado);

            return listaStatus;
        }

        public static List<ComboBoxCampo> statusSexo()
        {
            var lstSt = new List<ComboBoxCampo>();

            var masculino = new ComboBoxCampo
            {
                Descricao = "Masculino",
                Id = 1
            };
            lstSt.Add(masculino);

            var feminino = new ComboBoxCampo
            {
                Descricao = "Feminino",
                Id = 2
            };
            lstSt.Add(feminino);

            return lstSt;
        }

        public static List<ComboBoxCampo> statusPeriodo()
        {
            var lstPeriodo = new List<ComboBoxCampo>();

            var manha = new ComboBoxCampo
            {
                Descricao = "Manhã",
                Id = 1
            };
            lstPeriodo.Add(manha);

            var tarde = new ComboBoxCampo
            {
                Descricao = "Tarde",
                Id = 2
            };
            lstPeriodo.Add(tarde);

            var noite = new ComboBoxCampo
            {
                Descricao = "Noite",
                Id = 3
            };
            lstPeriodo.Add(noite);

            return lstPeriodo;
        }

        public static List<DisciplinasModel> DisciplinaEspecializada()
        {
            var repository = new DisciplinaRespository();
            var carregarDados = repository.CarregarTodosDados();

            return carregarDados.Where(l => l.IdStatus != 2).ToList();
        }
     
        public static List<DocentesModel> NomeProfessor()
        {
            var repository = new DocentesRepository();
            var carregarDados = repository.CarregarDados();

            return carregarDados.Where(l => l.IdStatus != 2).ToList(); ;
        }

        public static List<ComboBoxCampo> BuscaFiltro()
        {
            var lstFiltro = new List<ComboBoxCampo>();

            var professor = new ComboBoxCampo
            {
                Descricao = "Professor",
                Id = 1
            };
            lstFiltro.Add(professor);

            var disciplina = new ComboBoxCampo
            {
                Descricao = "Disciplina",
                Id = 2
            };
            lstFiltro.Add(disciplina);

            return lstFiltro;
        }
    }
}
