// propriedade: Duracao, Ordem, Resumo, Titulo.

// O resumo do episodio será contatenado com os valores de numero, titulo, duração e os convidados

// Metodos: AdicionarConvidados(), será chamado quantas vezes necessaria

class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int ordem, string titulo)
    {
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; set; }
    public int Ordem { get; }
    // no resumo usamos, {(convidados.Any() ? string.Join(", ", convidados) : "Nenhum convidado")}, para que caso não tenha convidados, aparece "Nenhum Convidados", e caso tenha, apareça com a ,
    public string Resumo =>
        $"{Ordem} - " +
        $"{Titulo}\n" +
        $"Duração do episódio: {Duracao} min\n" +
        $"Convidado(s): {(convidados.Any() ? string.Join(", ", convidados) : "Nenhum convidado")}";
    public string Titulo { get; }

    public void AdicionarConvidados(string nomeConvidados)
    {
        // no if(nomeConvidados == null), pode ser alterado para if (string.IsNullOrWhiteSpace(nomeConvidados)), isso anulará não apenas o null, mas tambem string vazia "" e só espaços " ", desat forma fica mais completo e mais profissional.

        if (string.IsNullOrWhiteSpace(nomeConvidados))
        {
            Console.WriteLine("Você precisa colocar um nome válido!");
            return;
        }else
        {
            convidados.Add(nomeConvidados);
        }
    }
}