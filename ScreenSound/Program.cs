Console.WriteLine("======== Lista de Músicas ========\n");

// código das bandas, álbuns, músicas


Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();


Console.WriteLine("\n\n======== Lista de Podcasts ========");

// criando o podcast
Podcast podcast = new Podcast("DevCast", "Bruno Rosa");

// criando episódios
Episodio ep1 = new Episodio(1, "Introdução ao C#")
{
    Duracao = 47
};

ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Carlos");

Episodio ep2 = new Episodio(2, "POO na prática")
{
    Duracao = 60
};

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();
