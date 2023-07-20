class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get;}

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Músicas do álbum {Nome}:\n");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"Música : {musica.Nome})");
        }

        Console.WriteLine($"\nPara ouvir este álbum, reserve {DuracaoTotal} segundos.\n");
    }
}