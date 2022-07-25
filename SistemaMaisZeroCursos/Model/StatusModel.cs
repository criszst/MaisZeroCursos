namespace SistemaMaisZeroCursos.Model
{
    public class StatusDisciplina
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
    }

    public class StatusDocente
    {
        public int Id { get; set; }
        public string? Desc { get; set; }
    }

    public class StatusSexo
    {
        public int Id { get; set; }
        public string? Desc { get; set; }
    }

    public class StatusPeriodo
    {
        public int Id { get; set; }
        public string? Desc { get; set; }
    }
}
