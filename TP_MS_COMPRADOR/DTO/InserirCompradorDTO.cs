namespace DTO
{
    public class InserirCompradorDTO
    {
        public required string CPF { get; set; }

        public required string Nome { get; set; }

        public required string Sexo { get; set; }

        public DateTime DtNasc { get; set; }
    }
}
