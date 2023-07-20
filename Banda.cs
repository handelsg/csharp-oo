class Banda
{
    private List<Album> _albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        _albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in _albuns)
        {
            Console.WriteLine($"Nome do album: {album.Nome}");
            Console.WriteLine();
        }
    }
}
