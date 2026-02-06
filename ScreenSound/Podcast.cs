// propriedades: Host, Nome, TotalEpisodios

// Nasce com nome e Host definidos.

// Metodos: AdicionarEpisodio() e o ExibirDetalhes() que deve exibir o nome do podcast e o host na primeira linha e na sequencia a lista de episodios e por fim o TotalEpisodios
class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nomePodcast, string host)
    {
        NomePodcast = nomePodcast;
        Host = host;
    }
    public string NomePodcast { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\n\nNome do Podcast: {NomePodcast}");
        Console.WriteLine($"Apresentado por: {Host}\n");

        // Count == 0 e !Any() fazem a mesma coisa, então da para usar: if (!episodios.Any())
        if (episodios.Count == 0)
        {
            Console.WriteLine("Nenhum episódio cadastrado.");
        }
        else
        {
            foreach(var episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
                Console.WriteLine(); // linha em branco entre episódios
            }
        }
        Console.WriteLine($"Total de episódios do Podcast: {TotalEpisodios}");
    }
}


