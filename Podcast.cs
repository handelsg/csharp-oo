class Podcast
{

    private List<Episodio> episodios = new();
    public Podcast ( string nome, string host ) 
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void  ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
        Console.WriteLine($"Episódios: ");
        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}