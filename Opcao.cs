namespace CSdw
{
    internal class Opcao
    {
        public int Id { get; set; }

        public string? Pergunta { get; set; }

        public List<Resposta> Respostas { get; set; }
    }
}
