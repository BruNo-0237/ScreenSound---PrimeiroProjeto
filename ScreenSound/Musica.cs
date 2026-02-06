class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    // Propriedade apenas de leitura, o sinal => faz o mesmo que usar o get { return $"A música {Nome} pertence a banda {Artista}"}, só que de forma mais resumida. Recurso chamado de Lambda.
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("A música esta disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o Plano Plus+.");
        }
    }
}
